namespace Financas.view
{
    partial class PaginaPrincipal
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
            ToolStripMenuItem RELATÓRIOS;
            groupBox1 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            MOVIMENTAÇÕES = new ToolStripMenuItem();
            PERFIL = new ToolStripMenuItem();
            RELATÓRIOS = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RELATÓRIOS
            // 
            RELATÓRIOS.Name = "RELATÓRIOS";
            RELATÓRIOS.Size = new Size(84, 19);
            RELATÓRIOS.Text = "RELATÓRIOS";
            RELATÓRIOS.Click += IrParaRelatorios_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(899, 528);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENU";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(396, 18);
            label4.Name = "label4";
            label4.Size = new Size(263, 24);
            label4.TabIndex = 12;
            label4.Text = "SISTEMA FINANCEIRO";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(662, 155);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 10;
            label1.Text = "Data do movimento";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(739, 334);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(410, 155);
            label3.Name = "label3";
            label3.Size = new Size(231, 21);
            label3.TabIndex = 8;
            label3.Text = "TRANSAÇÕES DO DIA";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(780, 153);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 21);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 20);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "R$";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(155, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Saldo do dia";
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, RELATÓRIOS, MOVIMENTAÇÕES, PERFIL });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(2, 18);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(127, 508);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(121, 19);
            toolStripMenuItem1.Text = "PAGINA PRINCIPAL";
            toolStripMenuItem1.Click += IrParaPaginaPrincipal_Click;
            // 
            // MOVIMENTAÇÕES
            // 
            MOVIMENTAÇÕES.Name = "MOVIMENTAÇÕES";
            MOVIMENTAÇÕES.Size = new Size(117, 19);
            MOVIMENTAÇÕES.Text = "MOVIMENTAÇÕES";
            MOVIMENTAÇÕES.Click += IrParaMovimentacoes_Click;
            // 
            // PERFIL
            // 
            PERFIL.Name = "PERFIL";
            PERFIL.Size = new Size(54, 19);
            PERFIL.Text = "PERFIL";
            PERFIL.Click += IrParaPerfil_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 528);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PaginaPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn RECEBIDO;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem RELATÓRIOS;
        private ToolStripMenuItem MOVIMENTAÇÕES;
        private ToolStripMenuItem PERFIL;
        private Label label4;
    }
}