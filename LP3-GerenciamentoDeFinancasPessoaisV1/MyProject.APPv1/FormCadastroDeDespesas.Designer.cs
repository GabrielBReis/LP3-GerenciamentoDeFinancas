namespace MyProject.APPv1
{
    partial class FormCadastroDeDespesas
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(593, 355);
            button1.Name = "button1";
            button1.Size = new Size(173, 72);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 342);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 197);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 245);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Descrição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 152);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 294);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Senha";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 291);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 342);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 11;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(122, 27);
            label6.Name = "label6";
            label6.Size = new Size(553, 72);
            label6.TabIndex = 12;
            label6.Text = "Cadastro de Despesas";
            label6.Click += label6_Click;
            // 
            // FormCadastroDeDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "FormCadastroDeDespesas";
            Text = "FormCadastroDeDespesas";
            Load += FormCadastroDeDespesas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        //private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
    }
}