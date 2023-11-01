namespace MyProject.APPv1
{
    partial class FormCadastroReceita
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
            txtSenha = new TextBox();
            txtData = new TextBox();
            txtValor = new TextBox();
            button2 = new Button();
            txtDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listViewCategorias = new ListView();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(142, 116);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(167, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Location = new Point(142, 159);
            txtData.Name = "txtData";
            txtData.Size = new Size(167, 23);
            txtData.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(142, 200);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(167, 23);
            txtValor.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(623, 388);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 4;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(142, 245);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(167, 23);
            txtDescricao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 124);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 167);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 208);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 253);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 302);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Categoria";
            // 
            // listViewCategorias
            // 
            listViewCategorias.Location = new Point(504, 134);
            listViewCategorias.Name = "listViewCategorias";
            listViewCategorias.Size = new Size(262, 183);
            listViewCategorias.TabIndex = 12;
            listViewCategorias.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 9);
            label6.Name = "label6";
            label6.Size = new Size(506, 72);
            label6.TabIndex = 13;
            label6.Text = "Cadastro De Receita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(504, 103);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 14;
            label7.Text = "Categorias ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormCadastroReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listViewCategorias);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(button2);
            Controls.Add(txtValor);
            Controls.Add(txtData);
            Controls.Add(txtSenha);
            Name = "FormCadastroReceita";
            Text = "FormCadastroReceita";
            ResumeLayout(false);
            PerformLayout();
        }

      
        #endregion
        private TextBox txtSenha;
        private TextBox txtData;
        private TextBox txtValor;
        private Button button2;
        private TextBox txtDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listViewCategorias;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}
