namespace Financas.view.relatorios
{
    partial class Relatorios
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 167);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(489, 31);
            button1.TabIndex = 0;
            button1.Text = "Gerar relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 206);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(862, 484);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 113);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 3;
            label1.Text = "DE:";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(67, 115);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(204, 113);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 7;
            label2.Text = "ATÉ:";
            label2.Click += label2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(258, 114);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(123, 27);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 40);
            label3.Name = "label3";
            label3.Size = new Size(348, 35);
            label3.TabIndex = 9;
            label3.Text = "GERAR RELATÓRIOS";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(624, 113);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 10;
            label4.Text = "CATEGORIA";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(745, 111);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(323, 735);
            label5.Name = "label5";
            label5.Size = new Size(186, 28);
            label5.TabIndex = 12;
            label5.Text = "DESPESAS TOTAIS:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 735);
            label6.Name = "label6";
            label6.Size = new Size(175, 28);
            label6.TabIndex = 13;
            label6.Text = "GANHOS TOTAIS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(646, 735);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 14;
            label7.Text = "DIFERENÇA:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(195, 735);
            label8.Name = "label8";
            label8.Size = new Size(24, 28);
            label8.TabIndex = 15;
            label8.Text = "0";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(506, 735);
            label9.Name = "label9";
            label9.Size = new Size(24, 28);
            label9.TabIndex = 16;
            label9.Text = "0";
            label9.Click += label9_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(417, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Entradas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(527, 115);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 24);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Saidas";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 192);
            label10.Location = new Point(768, 735);
            label10.Name = "label10";
            label10.Size = new Size(24, 28);
            label10.TabIndex = 19;
            label10.Text = "0";
            label10.Click += label10_Click;
            // 
            // Relatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 788);
            Controls.Add(label10);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Relatorios";
            Text = "Relatórios";
            Load += relatorios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private NotifyIcon notifyIcon1;
        private VScrollBar vScrollBar1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label10;
    }
}