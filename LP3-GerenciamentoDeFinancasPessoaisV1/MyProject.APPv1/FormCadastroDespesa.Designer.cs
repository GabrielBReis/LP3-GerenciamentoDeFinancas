namespace MyProject.APPv1
{
    partial class FormCadastroDespesa
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
            label7 = new Label();
            label6 = new Label();
            listViewCategorias = new ListView();
            txtCategoria = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            button2 = new Button();
            txtValor = new TextBox();
            txtData = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(490, 105);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 25;
            label7.Text = "Categorias ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 11);
            label6.Name = "label6";
            label6.Size = new Size(536, 72);
            label6.TabIndex = 24;
            label6.Text = "Cadastro De Despesa";
            // 
            // listViewCategorias
            // 
            listViewCategorias.Location = new Point(490, 136);
            listViewCategorias.Name = "listViewCategorias";
            listViewCategorias.Size = new Size(262, 183);
            listViewCategorias.TabIndex = 23;
            listViewCategorias.UseCompatibleStateImageBehavior = false;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(128, 296);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(167, 23);
            txtCategoria.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 304);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 21;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 255);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 20;
            label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(128, 247);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(167, 23);
            txtDescricao.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(609, 390);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 18;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(128, 202);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(167, 23);
            txtValor.TabIndex = 17;
            // 
            // txtData
            // 
            txtData.Location = new Point(128, 161);
            txtData.Name = "txtData";
            txtData.Size = new Size(167, 23);
            txtData.TabIndex = 16;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(128, 118);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(167, 23);
            txtSenha.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 210);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 28;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 169);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 27;
            label2.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 126);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 26;
            label1.Text = "Senha";
            // 
            // FormCadastroDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listViewCategorias);
            Controls.Add(txtCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescricao);
            Controls.Add(button2);
            Controls.Add(txtValor);
            Controls.Add(txtData);
            Controls.Add(txtSenha);
            Name = "FormCadastroDespesa";
            Text = "FormCadastroDespesa";
            Load += FormCadastroDespesa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private ListView listViewCategorias;
        private TextBox txtCategoria;
        private Label label5;
        private Label label4;
        private TextBox txtDescricao;
        private Button button2;
        private TextBox txtValor;
        private TextBox txtData;
        private TextBox txtSenha;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}