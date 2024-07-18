using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Financas.controller;
using Financas.models;
using Financas.models.Financas.models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApp
{

    public partial class FormRegister : Form
    {
        private DataContext context;
        private UsuarioController usuarioController;

        public FormRegister()
        {
            InitializeComponent();
            SetPlaceholderText(txtSenha, "Senha");
            SetPlaceholderText(txtConfirmarSenha, "Confirmar Senha");
        }

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnRegister = new Button();
            lblErro = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.Enter += RemoverTextoPlaceholder;
            txtNome.Leave += DefinirTextoPlaceholder;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 38);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(260, 23);
            txtSenha.TabIndex = 1;
            txtSenha.Enter += RemoverTextoPlaceholder;
            txtSenha.Leave += DefinirTextoPlaceholder;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(12, 64);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(260, 23);
            txtConfirmarSenha.TabIndex = 2;
            txtConfirmarSenha.Enter += RemoverTextoPlaceholder;
            txtConfirmarSenha.Leave += DefinirTextoPlaceholder;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 90);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(260, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(12, 116);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 4;
            // 
            // FormRegister
            // 
            ClientSize = new Size(284, 141);
            Controls.Add(lblErro);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Name = "FormRegister";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnRegister;
        private Label lblErro;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (context == null)
            {
                context = new DataContext();
            }
            usuarioController = new UsuarioController(context);
        
        string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (senha == confirmarSenha)
            {
                string hashedSenha = ComputeSha256Hash(senha);
                var usuario = new Usuario
                {
                    usuario = nome,
                    senha = senha,
                    saldo = 0 };
                usuarioController.CreateUsuario(usuario);

                MessageBox.Show("Usuário registrado com sucesso!");
                this.Close();
            }
            else
            {
                lblErro.Text = "As senhas não coincidem!";
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void RemoverTextoPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Nome" || textBox.Text == "Senha" || textBox.Text == "Confirmar Senha")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
                if (textBox != txtNome)
                    textBox.PasswordChar = '*';
            }
        }

        private void DefinirTextoPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = System.Drawing.Color.Gray;
                textBox.PasswordChar = '\0';
                if (textBox == txtNome) textBox.Text = "Nome";
                else if (textBox == txtSenha) textBox.Text = "Senha";
                else if (textBox == txtConfirmarSenha) textBox.Text = "Confirmar Senha";
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.PasswordChar = '\0';
            textBox.Text = placeholderText;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
