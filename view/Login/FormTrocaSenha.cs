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
        private Label label3;
        private Label label1;
        private Label label2;
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
            txtSenhaAtual = new TextBox();
            txtNovaSenha = new TextBox();
            txtConfirmarNovaSenha = new TextBox();
            btnAlterarSenha = new Button();
            lblErro = new Label();
            lblTitulo = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Font = new Font("Segoe UI", 10F);
            txtSenhaAtual.Location = new Point(60, 150);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(350, 25);
            txtSenhaAtual.TabIndex = 0;
            txtSenhaAtual.Enter += RemoverTextoPlaceholder;
            txtSenhaAtual.Leave += DefinirTextoPlaceholder;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 10F);
            txtNovaSenha.Location = new Point(60, 200);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(350, 25);
            txtNovaSenha.TabIndex = 1;
            txtNovaSenha.Enter += RemoverTextoPlaceholder;
            txtNovaSenha.Leave += DefinirTextoPlaceholder;
            // 
            // txtConfirmarNovaSenha
            // 
            txtConfirmarNovaSenha.Font = new Font("Segoe UI", 10F);
            txtConfirmarNovaSenha.Location = new Point(60, 250);
            txtConfirmarNovaSenha.Name = "txtConfirmarNovaSenha";
            txtConfirmarNovaSenha.Size = new Size(350, 25);
            txtConfirmarNovaSenha.TabIndex = 2;
            txtConfirmarNovaSenha.Enter += RemoverTextoPlaceholder;
            txtConfirmarNovaSenha.Leave += DefinirTextoPlaceholder;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.BackColor = Color.LightSkyBlue;
            btnAlterarSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAlterarSenha.ForeColor = Color.White;
            btnAlterarSenha.Location = new Point(60, 300);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(350, 40);
            btnAlterarSenha.TabIndex = 3;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = false;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI", 9F);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(60, 350);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 20.25F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(110, 52);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 38);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "ALTERAR SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 232);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 9;
            label3.Text = "Confirmar Nova Senha";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 182);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 10;
            label1.Text = "Nova Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 132);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 11;
            label2.Text = "Senha Atual";
            // 
            // FormChangePassword
            // 
            ClientSize = new Size(470, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblTitulo);
            Controls.Add(lblErro);
            Controls.Add(btnAlterarSenha);
            Controls.Add(txtConfirmarNovaSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtSenhaAtual);
            Name = "FormChangePassword";
            Text = "Alterar Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtSenhaAtual;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarNovaSenha;
        private Button btnAlterarSenha;
        private Label lblErro;
        private Label lblTitulo;

        private string senha;

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

