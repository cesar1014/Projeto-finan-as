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
            groupBox1 = new GroupBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(573, 528);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRINCIPAL";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(309, 33);
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
            dataGridView1.Location = new Point(0, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 334);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 164);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "TRANSAÇÕES DO DIA";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(427, 31);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 21);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 31);
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
            label2.Location = new Point(11, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Saldo do dia";
            label2.Click += label2_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 528);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Load += PaginaPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}