using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormLogin : Form
    {
        private static string senha;
        private static string usuario;

        public FormLogin()
        {
            InitializeComponent();
            SetPlaceholderText(txtSenha, "Senha");

            // Verifique se já existe um usuário registrado
            if (string.IsNullOrEmpty(senha))
            {
                FormRegister formRegister = new FormRegister();
                formRegister.ShowDialog();
            }
        }

        private void InitializeComponent()
        {
            this.txtSenha = new TextBox();
            this.btnLogin = new Button();
            this.lblErro = new Label();
            this.SuspendLayout();

            // txtSenha
            this.txtSenha.Location = new System.Drawing.Point(12, 12);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(260, 20);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(12, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // lblErro
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 64);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 2;

            // FormLogin
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblErro;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senhaDigitada = txtSenha.Text;
            string hashedSenhaDigitada = ComputeSha256Hash(senhaDigitada);

            if (hashedSenhaDigitada == senha)
            {
                FormMain formMain = new FormMain(senha, usuario);
                formMain.Show();
                this.Hide();
            }
            else
            {
                lblErro.Text = "Senha incorreta!";
            }
        }

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

        public static void Setsenha(string novaSenha)
        {
            senha = novaSenha;
        }

        public static void Setusuario(string novoUsuario)
        {
            usuario = novoUsuario;
        }

        private void RemoverTextoPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Senha")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
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
                textBox.Text = "Senha";
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.PasswordChar = '\0';
            textBox.Text = placeholderText;
        }
    }
}
