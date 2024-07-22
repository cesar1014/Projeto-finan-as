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
        public bool RegistroBemSucedido { get; private set; } = false;
        public FormRegister()
        {
            InitializeComponent();
            SetPlaceholderText(txtSenha, "Senha");
            SetPlaceholderText(txtConfirmarSenha, "Confirmar Senha");
        }





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

            // Validação da senha
            if (!IsValidPassword(senha))
            {
                lblErro.Text = "Senha: mínimo de 8 caracteres, uma maiúscula e um caractere especial.";
                return;
            }

            if (senha == confirmarSenha)
            {
                string hashedSenha = ComputeSha256Hash(senha);
                var usuario = new Usuario
                {
                    usuario = nome,
                    senha = senha,
                    saldo = 0
                };
                usuarioController.CreateUsuario(usuario);
                RegistroBemSucedido = true;
                MessageBox.Show("Usuário registrado com sucesso!");
                this.Close();
            }
            else
            {
                lblErro.Text = "As senhas não coincidem!";
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpperCase = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                if (!char.IsLetterOrDigit(c))
                    hasSpecialChar = true;
            }

            return hasUpperCase && hasSpecialChar;
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
        private void FormRegister_Load(object sender, EventArgs e)
        {
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
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnRegister = new Button();
            lblErro = new Label();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(60, 170);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 25);
            txtNome.TabIndex = 0;
            txtNome.Enter += RemoverTextoPlaceholder;
            txtNome.Leave += DefinirTextoPlaceholder;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(60, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(350, 25);
            txtSenha.TabIndex = 1;
            txtSenha.Enter += RemoverTextoPlaceholder;
            txtSenha.Leave += DefinirTextoPlaceholder;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 10F);
            txtConfirmarSenha.Location = new Point(60, 270);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(350, 25);
            txtConfirmarSenha.TabIndex = 2;
            txtConfirmarSenha.Enter += RemoverTextoPlaceholder;
            txtConfirmarSenha.Leave += DefinirTextoPlaceholder;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSkyBlue;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(60, 320);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 40);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI", 9F);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(50, 370);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 20.25F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(160, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 38);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "REGISTRO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 152);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 202);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 252);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 8;
            label3.Text = "Confirmar Senha";
            // 
            // FormRegister
            // 
            ClientSize = new Size(470, 420);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
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

        private UsuarioController usuarioController;
        private DataContext context;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnRegister;
        private Label lblErro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTitulo;
    }
}
