namespace Financas.view
{
    partial class EntradasSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasSaidas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            button4 = new Button();
            label9 = new Label();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/YY ";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Data do Lançamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 30);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Categoria";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lançamentos";
            // 
            // button1
            // 
            button1.Location = new Point(239, 174);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 5;
            button1.Text = "Registrar Lançamento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 175);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "0,00";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "Valor (R$) : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(18, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(178, 72);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo da Transação";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(100, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Saídas";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Entradas";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 98);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição do Lançamento";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Escolha", "Mais um" });
            comboBox1.Location = new Point(243, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(630, 482);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(622, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Novo Lançamento";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(622, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar Lançamentos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(7, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(603, 105);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selecionado";
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(561, 64);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 70);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 11;
            label9.Text = "Data :";
            // 
            // button3
            // 
            button3.AccessibleDescription = "Edita o Lançamento selecionado";
            button3.AccessibleName = "Editar";
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(561, 22);
            button3.Name = "button3";
            button3.Size = new Size(33, 33);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Control;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Escolha", "Mais um" });
            comboBox2.Location = new Point(367, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 23);
            comboBox2.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 31);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 10;
            label8.Text = "Categoria :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/YY ";
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(367, 67);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(169, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 70);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 7;
            label7.Text = "Descrição : ";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(78, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(196, 28);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 31);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor (R$) :";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(33, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(39, 23);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 2;
            label5.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, valor, descricao, data, Categoria });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(7, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(603, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 40;
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 100;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            descricao.Width = 200;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 120;
            // 
            // EntradasSaidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(643, 506);
            Controls.Add(tabControl1);
            Name = "EntradasSaidas";
            Text = "'";
            Load += EntradasSaidas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn Categoria;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
    }
}