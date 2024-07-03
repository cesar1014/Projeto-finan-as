namespace Financas.view.relatorios
{
    partial class relatorios
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(651, 107);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 0;
            button1.Text = "Gerar relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Data, Categoria, Descrição });
            dataGridView1.Location = new Point(12, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(754, 398);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Valor
            // 
            Valor.FillWeight = 200F;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // Descrição
            // 
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            Descrição.Width = 400;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 107);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 3;
            label1.Text = "De:";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(58, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(221, 108);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 7;
            label2.Text = "Até:";
            label2.Click += label2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(263, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(136, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(279, 27);
            label3.Name = "label3";
            label3.Size = new Size(243, 32);
            label3.TabIndex = 9;
            label3.Text = "GERAR RELATÓRIOS";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(414, 107);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(497, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(775, 181);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(16, 398);
            vScrollBar1.TabIndex = 12;
            // 
            // relatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(vScrollBar1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "relatorios";
            Text = "Relatórios";
            Load += relatorios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Descrição;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private NotifyIcon notifyIcon1;
        private VScrollBar vScrollBar1;
    }
}