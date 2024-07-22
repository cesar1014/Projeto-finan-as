using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Financas.controller;
using Financas.models;

namespace LoginApp
{
    public partial class FormChangePassword : Form
    {
        private string nomeUsuario;
        private readonly UsuarioController usuarioController;

        public FormChangePassword(string nomeUsuario, UsuarioController usuarioController)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            this.usuarioController = usuarioController;

            SetPlaceholderText(txtSenhaAtual, "Senha Atual");
            SetPlaceholderText(txtNovaSenha, "Nova Senha");
            SetPlaceholderText(txtConfirmarNovaSenha, "Confirmar Nova Senha");
        }

        public FormChangePassword(string senha)
        {
            this.senha = senha;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string senhaAtual = txtSenhaAtual.Text;
            string novaSenha = txtNovaSenha.Text;
            string confirmarNovaSenha = txtConfirmarNovaSenha.Text;

            // Validação da nova senha
            if (!IsValidPassword(novaSenha))
            {
                lblErro.Text = "Senha: mínimo de 8 caracteres, uma maiúscula e um caractere especial.";
                return;
            }

            // Verifica se a nova senha é diferente da senha atual
            if (novaSenha == senhaAtual)
            {
                lblErro.Text = "A nova senha não pode ser a mesma que a senha atual.";
                return;
            }

            if (novaSenha == confirmarNovaSenha)
            {
                string hashedSenhaAtual = ComputeSha256Hash(senhaAtual);

                var usuario = usuarioController.ReadUsuario(nomeUsuario);
                if (usuario != null && usuario.senha == hashedSenhaAtual)
                {
                    usuarioController.UpdateUsuario(nomeUsuario, novaSenha);
                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Close();
                }
                else
                {
                    lblErro.Text = "Senha atual incorreta!";
                }
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

        private void RemoverTextoPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Senha Atual" || textBox.Text == "Nova Senha" || textBox.Text == "Confirmar Nova Senha")
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
                if (textBox == txtSenhaAtual) textBox.Text = "Senha Atual";
                else if (textBox == txtNovaSenha) textBox.Text = "Nova Senha";
                else if (textBox == txtConfirmarNovaSenha) textBox.Text = "Confirmar Nova Senha";
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
            this.txtSenhaAtual = new TextBox();
            this.txtNovaSenha = new TextBox();
            this.txtConfirmarNovaSenha = new TextBox();
            this.btnAlterarSenha = new Button();
            this.lblErro = new Label();
            this.SuspendLayout();

            // txtSenhaAtual
            this.txtSenhaAtual.Font = new Font("Segoe UI", 10F);
            this.txtSenhaAtual.Location = new System.Drawing.Point(12, 30);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(260, 25);
            this.txtSenhaAtual.TabIndex = 0;
            this.txtSenhaAtual.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtSenhaAtual.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // txtNovaSenha
            this.txtNovaSenha.Font = new Font("Segoe UI", 10F);
            this.txtNovaSenha.Location = new System.Drawing.Point(12, 70);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(260, 25);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtNovaSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // txtConfirmarNovaSenha
            this.txtConfirmarNovaSenha.Font = new Font("Segoe UI", 10F);
            this.txtConfirmarNovaSenha.Location = new System.Drawing.Point(12, 110);
            this.txtConfirmarNovaSenha.Name = "txtConfirmarNovaSenha";
            this.txtConfirmarNovaSenha.Size = new System.Drawing.Size(260, 25);
            this.txtConfirmarNovaSenha.TabIndex = 2;
            this.txtConfirmarNovaSenha.Enter += new EventHandler(this.RemoverTextoPlaceholder);
            this.txtConfirmarNovaSenha.Leave += new EventHandler(this.DefinirTextoPlaceholder);

            // btnAlterarSenha
            this.btnAlterarSenha.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAlterarSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSenha.Location = new System.Drawing.Point(12, 150);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(260, 30);
            this.btnAlterarSenha.TabIndex = 3;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new EventHandler(this.btnAlterarSenha_Click);

            // lblErro
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new Font("Segoe UI", 9F);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 190);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 15);
            this.lblErro.TabIndex = 4;

            // FormChangePassword
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txtConfirmarNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Name = "FormChangePassword";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtSenhaAtual;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarNovaSenha;
        private Button btnAlterarSenha;
        private Label lblErro;
        private string senha;
    }
}
