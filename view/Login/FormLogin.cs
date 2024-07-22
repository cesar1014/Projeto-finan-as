using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Financas.controller;
using Financas.models;

namespace LoginApp
{
    public partial class FormLogin : Form
    {
        private DataContext context;

        public FormLogin()
        {
            InitializeComponent();
            SetPlaceholderText(txtSenha, "Senha");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (context == null)
            {
                context = new DataContext();
            }

            string usuario = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;
            string hashedSenhaDigitada = ComputeSha256Hash(senhaDigitada);

            var usuarioExistente = context.Usuario.FirstOrDefault(u => u.usuario == usuario);

            if (usuarioExistente != null && usuarioExistente.senha == hashedSenhaDigitada)
            {
                // Se for necessário, inicialize o UsuarioController
                UsuarioController usuarioController = new UsuarioController(context);

                MessageBox.Show("Login bem-sucedido!");

                // Passe o UsuarioController para o FormMain
                FormMain formMain = new FormMain(usuario, usuarioExistente.senha, usuarioController);
                formMain.Show();
                this.Hide();
            }
            else
            {
                lblErro.Text = "Usuário ou senha incorretos!";
            }
        }

        // Método para fazer o hashing da senha
        private static string ComputeSha256Hash(string rawData)
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
            if (textBox.Text == "Usuário" || textBox.Text == "Senha")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
                if (textBox == txtSenha)
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
                if (textBox == txtUsuario) textBox.Text = "Usuário";
                else if (textBox == txtSenha) textBox.Text = "Senha";
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.PasswordChar = '\0';
            textBox.Text = placeholderText;
        }

        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lblErro = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            
            // txtUsuario
            
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(60, 180);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(350, 25);
            txtUsuario.TabIndex = 0;
            txtUsuario.Enter += RemoverTextoPlaceholder;
            txtUsuario.Leave += DefinirTextoPlaceholder;
            
            // txtSenha
            
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(60, 230);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(350, 25);
            txtSenha.TabIndex = 1;
            txtSenha.Enter += RemoverTextoPlaceholder;
            txtSenha.Leave += DefinirTextoPlaceholder;
            
            // btnLogin
            
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            
            // lblErro
             
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI", 9F);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(60, 330);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 3;
            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 20.25F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(180, 80);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(112, 38);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "LOGIN";
            
            // label2
            
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 212);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Senha";
            
            // label1
            
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 162);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuário";
            
            // FormLogin
            
            ClientSize = new Size(470, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(lblErro);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        // Declaração dos campos e componentes do formulário

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblErro;
        private Label label2;
        private Label label1;
        private Label lblTitulo;
    }
}
