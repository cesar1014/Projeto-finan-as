using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            SetPlaceholderText(txtSenha, "Senha");
            SetPlaceholderText(txtConfirmarSenha, "Confirmar Senha");
        }

        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.txtSenha = new TextBox();
            this.txtConfirmarSenha = new TextBox();
            this.btnRegister = new Button();
            this.lblErro = new Label();
            this.SuspendLayout();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtNome.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // txtSenha
            this.txtSenha.Location = new System.Drawing.Point(12, 38);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(260, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // txtConfirmarSenha
            this.txtConfirmarSenha.Location = new System.Drawing.Point(12, 64);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(260, 20);
            this.txtConfirmarSenha.TabIndex = 2;
            this.txtConfirmarSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtConfirmarSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(12, 90);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(260, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // lblErro
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 116);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 4;

            // FormRegister
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Name = "FormRegister";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnRegister;
        private Label lblErro;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (senha == confirmarSenha)
            {
                string hashedSenha = ComputeSha256Hash(senha);
                FormLogin.Setsenha(hashedSenha);
                FormLogin.Setusuario(nome);
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
    }
}
