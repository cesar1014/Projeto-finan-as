using Financas.controller;
using Financas.models;
using Financas.models.Financas.models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Financas.view
{
    public partial class EntradasSaidas : Form
    {
        private DataContext context;
        private List<Categorias> todasAsCategorias;
        private UsuarioController usuarioController;
        private TransacoesController transacoesController;
        private List<Transacoes> transacoes;
        private int? editingRowIndex = null;


        public EntradasSaidas()
        {
            InitializeComponent();
            if (context == null)
            {
                context = new DataContext();
            }

            todasAsCategorias = context.Categorias.ToList();
            transacoesController = new TransacoesController(context);
            usuarioController = new UsuarioController(context);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EntradasSaidas_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            CarregarTransacoes(1);
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

        public class TransacoesViewModel
        {
            public int ID { get; set; }
            public string Valor { get; set; }
            public string Descricao { get; set; }
            public DateTime Data { get; set; }
            public string CategoriaDescricao { get; set; }
        }

        private void CarregarTransacoes(int opt)
        {

            try
            {
                // Limpa o DataGridView
                if (opt == 1)
                {
                    dataGridView1.Rows.Clear();
                }

                var transacoes = context.Transacoes
                    .Select(t => new TransacoesViewModel
                    {
                        ID = t.id,
                        Valor = t.valor.ToString("F2"),
                        Descricao = t.descricao,
                        Data = t.data,
                        CategoriaDescricao = t.categoria.descricao // ou qualquer propriedade que você queira exibir
                    })
                    .ToList();

                dataGridView1.AutoGenerateColumns = false;

                // Defina os nomes das colunas para corresponder às propriedades do ViewModel
                dataGridView1.Columns["id"].DataPropertyName = "ID";
                dataGridView1.Columns["valor"].DataPropertyName = "Valor";
                dataGridView1.Columns["descricao"].DataPropertyName = "Descricao";
                dataGridView1.Columns["data"].DataPropertyName = "Data";
                dataGridView1.Columns["Categoria"].DataPropertyName = "CategoriaDescricao";

                dataGridView1.DataSource = transacoes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar transações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public static void FormatacaoMoeda(ref System.Windows.Forms.TextBox textBox)
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox2.Text == "" || textBox1.Text == "")
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Valor não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox1.Text == "")
                    MessageBox.Show("Adicione uma descrição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = dateTimePicker1.Value;
                var valor = Convert.ToDouble(textBox2.Text);
                var descricao = textBox1.Text;
                var categoria = (Categorias)comboBox1.SelectedItem;

                if (valor == 0)
                {
                    MessageBox.Show("Valor não pode ser zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Console.WriteLine(valor);

                var transcao = new Transacoes
                {
                    data = data,
                    valor = ((float)valor),
                    descricao = descricao,
                    categoria = categoria
                };

                transacoesController.CreateTransacao(transcao);
                usuarioController.AtualizaSaldo((float)valor, categoria.tipo, "insert");
                MessageBox.Show("Transação lançada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZeraDados();
                CarregarTransacoes(0);

            }
        }
        void ZeraDados()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        void ZeraDados2()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.SelectedIndex = 0;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CarregarTransacoes(1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                if (button4.Enabled == true)
                {
                    MessageBox.Show("Termine a edição antes de selecionar outra transação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Restaura a seleção para a linha anterior
                    if (editingRowIndex.HasValue)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[editingRowIndex.Value].Selected = true;
                    }

                    return;
                }

                // Salva o índice da linha que está sendo editada
                editingRowIndex = e.RowIndex;

                if (button3.Enabled == false)
                {
                    button3.Enabled = true;
                }

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Atribui os valores das células aos campos de edição
                textBox3.Text = row.Cells["id"].Value.ToString();
                textBox4.Text = row.Cells["valor"].Value.ToString();
                textBox5.Text = row.Cells["descricao"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["data"].Value);

                string categoriaDescricao = row.Cells["Categoria"].Value.ToString();

                // Encontra a categoria correspondente na lista de todas as categorias
                var categoria = todasAsCategorias.FirstOrDefault(c => c.descricao == categoriaDescricao);
                if (categoria != null)
                {
                    // Filtra as categorias de acordo com o tipo da categoria encontrada
                    var categoriasFiltradas = todasAsCategorias.Where(c => c.tipo == categoria.tipo).ToList();

                    // Define o DataSource do ComboBox com a lista filtrada
                    comboBox2.DataSource = null; // Limpa o DataSource antes de atribuir
                    comboBox2.DisplayMember = "descricao";
                    comboBox2.ValueMember = "ID";
                    comboBox2.DataSource = categoriasFiltradas;

                    // Seleciona a categoria correspondente no ComboBox
                    comboBox2.SelectedIndex = comboBox2.FindStringExact(categoriaDescricao);
                }
                else
                {
                    MessageBox.Show("Erro, Categoria não encontrada.");
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        void AlternarCampos()
        {
            textBox4.Enabled = !textBox4.Enabled;
            textBox5.Enabled = !textBox5.Enabled;
            button4.Enabled = !button4.Enabled;
            button3.Enabled = !button3.Enabled;
            button5.Enabled = !button5.Enabled;
            comboBox2.Enabled = !comboBox2.Enabled;
            dateTimePicker2.Enabled = !dateTimePicker2.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlternarCampos();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlternarCampos();

            if (textBox4.Text == "" || textBox5.Text == "")
            {
                if (textBox4.Text == "")
                {

                    MessageBox.Show("Valor não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox5.Text == "")
                {

                    MessageBox.Show("Adicione uma descrição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var id = Convert.ToInt32(textBox3.Text);
                var data = dateTimePicker2.Value;
                var valor = ((float)Convert.ToDouble(textBox4.Text));
                var descricao = textBox5.Text;
                var categoria = (Categorias)comboBox2.SelectedItem;

                if (valor == 0)
                {
                    MessageBox.Show("Valor não pode ser zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                transacoesController.UpdateTransacao(id, valor, descricao, data, categoria.ID);
                CarregarTransacoes(0);
                button3.Enabled = false;
                ZeraDados2();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            FormatacaoMoeda(ref textBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Selecione uma transação para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var id = Convert.ToInt32(textBox3.Text);
                var result = MessageBox.Show("Deseja realmente excluir a transação?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    transacoesController.DeleteTransacao(id);
                    AlternarCampos();
                    CarregarTransacoes(0);
                    button3.Enabled = false;
                    var categoria = (Categorias)comboBox2.SelectedItem;
                    usuarioController.AtualizaSaldo((float)Convert.ToDouble(textBox4.Text), categoria.tipo, "delete"); 
                    ZeraDados2();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
