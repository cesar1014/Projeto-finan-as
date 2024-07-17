using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormChangePassword : Form
    {
        private string senhaAtual;

        public FormChangePassword(string senhaAtual)
        {
            InitializeComponent();
            this.senhaAtual = senhaAtual;
            SetPlaceholderText(txtNovaSenha, "Nova Senha");
            SetPlaceholderText(txtConfirmarNovaSenha, "Confirmar Nova Senha");
        }

        private void InitializeComponent()
        {
            this.txtNovaSenha = new TextBox();
            this.txtConfirmarNovaSenha = new TextBox();
            this.btnAlterarSenha = new Button();
            this.lblErro = new Label();
            this.SuspendLayout();

            // txtNovaSenha
            this.txtNovaSenha.Location = new System.Drawing.Point(12, 12);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(260, 20);
            this.txtNovaSenha.TabIndex = 0;
            this.txtNovaSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtNovaSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // txtConfirmarNovaSenha
            this.txtConfirmarNovaSenha.Location = new System.Drawing.Point(12, 38);
            this.txtConfirmarNovaSenha.Name = "txtConfirmarNovaSenha";
            this.txtConfirmarNovaSenha.Size = new System.Drawing.Size(260, 20);
            this.txtConfirmarNovaSenha.TabIndex = 1;
            this.txtConfirmarNovaSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtConfirmarNovaSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // btnAlterarSenha
            this.btnAlterarSenha.Location = new System.Drawing.Point(12, 64);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(260, 23);
            this.btnAlterarSenha.TabIndex = 2;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new EventHandler(this.btnAlterarSenha_Click);

            // lblErro
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 90);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 3;

            // FormChangePassword
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txtConfirmarNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Name = "FormChangePassword";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtNovaSenha;
        private TextBox txtConfirmarNovaSenha;
        private Button btnAlterarSenha;
        private Label lblErro;

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text;
            string confirmarNovaSenha = txtConfirmarNovaSenha.Text;

            if (novaSenha == confirmarNovaSenha)
            {
                string hashedNovaSenha = ComputeSha256Hash(novaSenha);
                FormLogin.Setsenha(hashedNovaSenha);
                MessageBox.Show("Senha alterada com sucesso!");
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
            if (textBox.Text == "Nova Senha" || textBox.Text == "Confirmar Nova Senha")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
                if (textBox != txtNovaSenha)
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
                if (textBox == txtNovaSenha) textBox.Text = "Nova Senha";
                else if (textBox == txtConfirmarNovaSenha) textBox.Text = "Confirmar Nova Senha";
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