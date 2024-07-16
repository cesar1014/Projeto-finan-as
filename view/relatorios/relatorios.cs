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

namespace Financas.view.relatorios
{
    public partial class relatorios : Form
    {

        private string connectionString = "Server=localhost\\SQLSERVER2014ECE;Database=financas;Trusted_Connection=True;TrustServerCertificate=True";


        public relatorios()
        {
            //INICIALIZANDO TODOS OS COMPONENTES
            InitializeComponent();


            // Associar o manipulador de eventos ao evento SelectedIndexChanged do comboBox1
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;

            // Optionally, load categories into the comboBox on form load
            LoadCategories();


            // Carrega os dados no DataGridView ao carregar o formulário
            CarregarDadosNoDataGridView();




            // TESTANDO A MINHA CONEXÃO COM O BANCO DE DADOS
            CheckDatabaseConnection();


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
                    string query = "SELECT Valor, Data, c.descricao AS Categorias, t.Descricao " +
                                   "FROM Transacoes t " +
                                   "INNER JOIN Categorias c ON t.ID = c.Id";

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
                    dataGridView1.Columns["Valor"].Width = 100; // Defina o tamanho em pixels
                    dataGridView1.Columns["Data"].Width = 120;
                    dataGridView1.Columns["Categorias"].Width = 150;
                    dataGridView1.Columns["Descricao"].Width = 400;

                    // Opcional: Ajusta as colunas no DataGridView
                    AjustarColunas();
                }
            }
            catch (Exception ex)
            {
                // Trata exceções
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

        }

        private void AjustarColunas()
        {
            // Ajusta automaticamente o tamanho das colunas no DataGridView
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void relatorios_Load(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Captura as datas selecionadas nos DateTimePickers
            DateTime dataInicio = dateTimePicker1.Value;
            DateTime dataFim = dateTimePicker2.Value;

            // Captura a Categorias selecionada no ComboBox
            string categoriaSelecionada = comboBox1.SelectedItem?.ToString();

            try
            {
                // Cria a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    connection.Open();

                    // Query SQL para selecionar os dados da tabela Transacoes com filtro de datas e Categorias
                    string query = "SELECT Valor, Data, c.descricao AS Categorias, t.Descricao " +
                                   "FROM Transacoes t " +
                                   "INNER JOIN Categorias c ON t.ID = c.Id " +
                                   "WHERE Data >= @DataInicio AND Data <= @DataFim ";

                    // Se uma Categorias foi selecionada, adicione a condição à query
                    if (!string.IsNullOrEmpty(categoriaSelecionada))
                    {
                        query += "AND c.descricao = @Categorias ";
                    }

                    // Cria o comando SQL e o SqlDataAdapter
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DataInicio", dataInicio);
                    command.Parameters.AddWithValue("@DataFim", dataFim);

                    // Adiciona o parâmetro de Categorias apenas se uma Categorias foi selecionada
                    if (!string.IsNullOrEmpty(categoriaSelecionada))
                    {
                        command.Parameters.AddWithValue("@Categorias", categoriaSelecionada);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Cria um DataTable para armazenar os dados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os dados do SqlDataAdapter
                    adapter.Fill(dataTable);

                    // Vincula o DataTable ao DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Define o tamanho das colunas individualmente (se necessário)
                    dataGridView1.Columns["Valor"].Width = 100; // Defina o tamanho em pixels
                    dataGridView1.Columns["Data"].Width = 120;
                    dataGridView1.Columns["Categorias"].Width = 150;
                    dataGridView1.Columns["Descricao"].Width = 400;


                }
            }
            catch (Exception ex)
            {
                // Trata exceções
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Você pode atualizar um label ou fazer outras operações conforme necessário
            string selectedItem = comboBox1.SelectedItem?.ToString();


            // Exibir o item selecionado no label1  (ESTUDAR MÉTODO)

            //label1.Text = "Item selecionado: " + selectedItem;

            // Realizar uma pesquisa no banco de dados baseado no item selecionado
            SearchCategory(selectedItem);


        }

        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT descricao FROM Categorias";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["descricao"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
                }
            }
        }

        private void SearchCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categorias WHERE descricao = @descricao";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@descricao", categoryName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Exibir informações da Categorias no label (ESTUDAR MÉTODO)

                        //label1.Text = $"ID: {reader["Id"]}, descricao: {reader["descricao"]}";
                    }
                    else
                    {

                        //  (ESTUDAR MÉTODO)

                        //label1.Text = "Categorias não encontrada.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar Categorias: " + ex.Message);
                }
            }
        }


        //FAZENDO A MINHA CONEXÃO COM O BANCO DE DADOS
        private void CheckDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão com o banco de dados bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar com o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
