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
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
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
            RELATÓRIOS.Size = new Size(106, 24);
            RELATÓRIOS.Text = "RELATÓRIOS";
            RELATÓRIOS.Click += IrParaRelatorios_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(0, 4);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1027, 704);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENU";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label5.Location = new Point(300, 24);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 13;
            label5.Text = "1.000";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(429, 23);
            label4.Name = "label4";
            label4.Size = new Size(339, 31);
            label4.TabIndex = 12;
            label4.Text = "SISTEMA FINANCEIRO";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(748, 208);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 10;
            label1.Text = "Data do movimento";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 251);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(845, 433);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 204);
            label3.Name = "label3";
            label3.Size = new Size(289, 27);
            label3.TabIndex = 8;
            label3.Text = "TRANSAÇÕES DO DIA";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(893, 206);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(118, 25);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 4;
            label2.Text = "SALDO DO DIA:";
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, RELATÓRIOS, MOVIMENTAÇÕES, PERFIL });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(2, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(155, 678);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(148, 24);
            toolStripMenuItem1.Text = "PAGINA PRINCIPAL";
            toolStripMenuItem1.Click += IrParaPaginaPrincipal_Click;
            // 
            // MOVIMENTAÇÕES
            // 
            MOVIMENTAÇÕES.Name = "MOVIMENTAÇÕES";
            MOVIMENTAÇÕES.Size = new Size(145, 24);
            MOVIMENTAÇÕES.Text = "MOVIMENTAÇÕES";
            MOVIMENTAÇÕES.Click += IrParaMovimentacoes_Click;
            // 
            // PERFIL
            // 
            PERFIL.Name = "PERFIL";
            PERFIL.Size = new Size(66, 24);
            PERFIL.Text = "PERFIL";
            PERFIL.Click += IrParaPerfil_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 704);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
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
        public Label label5;
    }
}