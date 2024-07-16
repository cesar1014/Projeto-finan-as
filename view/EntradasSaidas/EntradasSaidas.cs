using Financas.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas.view
{
    public partial class EntradasSaidas : Form
    {
        private DataContext context;
        private List<Categorias> todasAsCategorias;

        public EntradasSaidas()
        {
            InitializeComponent();
            if (context == null)
            {
                context = new DataContext();
            }

            todasAsCategorias = context.Categorias.ToList();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EntradasSaidas_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {

            try
            {
                // Verifica qual RadioButton está selecionado
                var opcao = radioButton2.Checked ? "Entrada" : "Saída";

                // Filtra as categorias de acordo com a opção selecionada
                var categorias = todasAsCategorias.Where(c => c.tipo == opcao).ToList();

                // Define o DataSource, DisplayMember e ValueMember do ComboBox
                comboBox1.DataSource = null; // Limpa o DataSource antes de atribuir
                comboBox1.DisplayMember = "descricao";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = categorias; // Define o novo DataSource

                // Seleciona o primeiro item, se houver
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }

                // Exemplo de mensagem de depuração
                Console.WriteLine($"Categorias carregadas: {categorias.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCategorias();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCategorias();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FormatacaoMoeda(ref textBox2);
        }


        public static void FormatacaoMoeda(ref TextBox textBox)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = textBox.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                textBox.Text = string.Format("{0:N}", v);
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception)
            {
                textBox.Text = string.Format("{0:N}", v);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = dateTimePicker1.Value ;
            var valor = Convert.ToDouble(textBox2.Text);
            var descricao = textBox1.Text;
            var categoria = (Categorias)comboBox1.SelectedItem;


        }
    }
}
