using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Financas.controller;
using Financas.view.relatorios;
using LoginApp;
using Financas.controller;
using Financas.models;
using Financas.view;

namespace Financas.view
{
    public partial class PaginaPrincipal : Form
    {
        string connectionString = ("Server=LAPTOP-MPBBGBHD\\SQLEXPRESS;Database=Financas;Trusted_Connection=True;TrustServerCertificate=True;"); // PC LUCAS

        // string connectionString = "Server=localhost\\SQLSERVER2014ECE;Database=financas;Trusted_Connection=True;TrustServerCertificate=True";

        public PaginaPrincipal(string usuario, string senha, UsuarioController usuarioController)
        {
            InitializeComponent();
            CarregarDadosNoDataGridView();
        }

        public PaginaPrincipal()
        {
            InitializeComponent();
            CarregarDadosNoDataGridView();
        }
        private void CarregarDadosNoDataGridView()
        {
            try
            {
                // Cria a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    connection.Open();

                    // Query SQL para selecionar os dados da tabela Transacoes
                    string query = "SELECT \r\n    t.valor, \r\n    t.data, \r\n    t.descricao, \r\n    c.descricao AS CategoriaDescricao\r\nFROM \r\n    [Financas].[dbo].[Transacoes] t\r\nJOIN \r\n    [Financas].[dbo].[Categorias] c\r\nON \r\n    t.CategoriaID = c.ID;";

                    // Cria o comando SQL e o SqlDataAdapter
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Cria um DataTable para armazenar os dados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os dados do SqlDataAdapter
                    adapter.Fill(dataTable);

                    // Vincula o DataTable ao DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Define o tamanho das colunas individualmente
                    dataGridView1.Columns["t.valor"].Width = 100; // Defina o tamanho em pixels
                    dataGridView1.Columns["t.data"].Width = 120;
                    dataGridView1.Columns["c.descricao"].Width = 180;
                    dataGridView1.Columns["t.descricao"].Width = 400;


                }
            }
            catch (Exception ex)
            {
                // Trata exceções
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IrParaMovimentacoes_Click(object sender, EventArgs e)
        {
               // PaginaPrincipal movimentacoesForm = new PaginaPrincipal();
            //movimentacoesForm.ShowDialog(); 
        }

        private void IrParaRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatoriosForm = new Relatorios();
            relatoriosForm.ShowDialog(); 
        }

        private void IrParaPaginaPrincipal_Click(object sender, EventArgs e)
        {
            //PaginaInicialForm paginaInicialForm = new PaginaInicialForm();
           // paginaInicialForm.ShowDialog(); // Usar ShowDialog para abrir como popup modal
        }

        private void IrParaPerfil_Click(object sender, EventArgs e)
        {
           // PerfilForm perfilForm = new PerfilForm();
            //perfilForm.ShowDialog();
        }

    }
}
