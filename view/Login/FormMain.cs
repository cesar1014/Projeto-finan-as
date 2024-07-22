using Financas.controller;
using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormMain : Form
    {
        private string senha;
        private string usuario;
        private UsuarioController usuarioController; // Adicione esta variável

        public FormMain(string usuario, string senha, UsuarioController usuarioController)
        {
            InitializeComponent();
            this.senha = senha;
            this.usuario = usuario;
            this.usuarioController = usuarioController;
            lblBemVindo.Text = "Bem-vindo " + usuario;
        }

        private void InitializeComponent()
        {
            this.lblBemVindo = new Label();
            this.btnAlterarSenha = new Button();
            this.SuspendLayout();

            // lblBemVindo
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(12, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(64, 13);
            this.lblBemVindo.TabIndex = 0;

            // btnAlterarSenha
            this.btnAlterarSenha.Location = new System.Drawing.Point(12, 35);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(260, 23);
            this.btnAlterarSenha.TabIndex = 1;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new EventHandler(this.btnAlterarSenha_Click);

            // FormMain
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "FormMain";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblBemVindo;
        private Button btnAlterarSenha;

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword(usuario, usuarioController);
            formChangePassword.ShowDialog();
        }
    }
}