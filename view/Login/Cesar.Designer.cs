namespace Financas.view
{
    partial class Cesar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            TBsenha = new TextBox();
            label2 = new Label();
            GBsenha = new GroupBox();
            GBsenha.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Playbill", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 53);
            label1.Name = "label1";
            label1.Size = new Size(242, 70);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(243, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 6;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(76, 89);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 7;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TBsenha
            // 
            TBsenha.Cursor = Cursors.Hand;
            TBsenha.Location = new Point(76, 47);
            TBsenha.MaxLength = 20;
            TBsenha.Name = "TBsenha";
            TBsenha.Size = new Size(242, 23);
            TBsenha.TabIndex = 8;
            TBsenha.Text = "Digite a senha do sistema";
            TBsenha.UseSystemPasswordChar = true;
            TBsenha.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // GBsenha
            // 
            GBsenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GBsenha.AutoSize = true;
            GBsenha.Controls.Add(TBsenha);
            GBsenha.Controls.Add(label2);
            GBsenha.Controls.Add(button2);
            GBsenha.Controls.Add(button1);
            GBsenha.Location = new Point(208, 161);
            GBsenha.Name = "GBsenha";
            GBsenha.Size = new Size(351, 148);
            GBsenha.TabIndex = 9;
            GBsenha.TabStop = false;
            // 
            // Cesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GBsenha);
            Controls.Add(label1);
            Name = "Cesar";
            Text = "APP Finacas";
            Load += Cesar_Load;
            GBsenha.ResumeLayout(false);
            GBsenha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox TBsenha;
        private Label label2;
        private GroupBox GBsenha;
    }
}