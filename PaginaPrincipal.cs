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
using Microsoft.VisualBasic.ApplicationServices;

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
            this.Load += new System.EventHandler(this.label5_Click_1);

        }

        public PaginaPrincipal()
        {
            InitializeComponent();
            CarregarDadosNoDataGridView();
            this.Load += new System.EventHandler(this.label5_Click_1);

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
                    string query = @"
                    SELECT 
                    t.valor, 
                    t.data, 
                    t.descricao, 
                    c.descricao AS CategoriaDescricao
                    FROM 
                    [Financas].[dbo].[Transacoes] t
                    JOIN 
                    [Financas].[dbo].[Categorias] c
                    ON 
                    t.CategoriaID = c.ID
                    WHERE
                    CONVERT(date, t.data) = CONVERT(date, GETDATE());
";

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
                    dataGridView1.Columns["valor"].Width = 100; // Defina o tamanho em pixels
                    dataGridView1.Columns["data"].Width = 120;
                    dataGridView1.Columns["descricao"].Width = 180;
                    dataGridView1.Columns["CategoriaDescricao"].Width = 400;

                    // Alterar o nome da coluna CategoriaDescricao para Categoria
                    dataGridView1.Columns["CategoriaDescricao"].HeaderText = "CATEGORIA";
                    dataGridView1.Columns["valor"].HeaderText = "VALOR";
                    dataGridView1.Columns["data"].HeaderText = "DATA";
                    dataGridView1.Columns["descricao"].HeaderText = "DESCRIÇÃO";


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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            // Define a data atual no DateTimePicker
            dateTimePicker1.Value = DateTime.Now;

            // Desabilita o DateTimePicker para impedir alterações
            dateTimePicker1.Enabled = false;

            CarregarSaldo();
        }

        private void CarregarSaldo()
        {
            string query = "SELECT saldo FROM usuario WHERE id = 1"; // ajuste o campo e condição conforme necessário

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Supondo que você tenha um ID do usuário para buscar o saldo
                        command.Parameters.AddWithValue("@id", 1); // substitua 1 pelo ID do usuário desejado

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal saldo = Convert.ToDecimal(result);
                            label5.Text = saldo.ToString("F3"); // Formata o saldo como moeda

                            // Define a cor do texto com base no valor do saldo
                            if (saldo > 0)
                            {
                                label5.ForeColor = Color.Green; // Verde para saldo positivo
                            }
                            else if (saldo < 0)
                            {
                                label5.ForeColor = Color.Red; // Vermelho para saldo negativo
                            }
                            else
                            {
                                label5.ForeColor = Color.Black; // Preto para saldo zero
                            }
                        }
                        else
                        {
                            MessageBox.Show("Saldo não encontrado para o usuário especificado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
