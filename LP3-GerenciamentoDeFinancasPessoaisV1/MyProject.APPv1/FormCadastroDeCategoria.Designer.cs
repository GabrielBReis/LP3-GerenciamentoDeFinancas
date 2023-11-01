namespace MyProject.APPv1
{
    partial class FormCadastroDeCategoria
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 35);
            label1.Name = "label1";
            label1.Size = new Size(560, 72);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 200);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 259);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 323);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Descrição";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(207, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(207, 256);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(207, 315);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(224, 23);
            txtDescricao.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(602, 362);
            button1.Name = "button1";
            button1.Size = new Size(155, 66);
            button1.TabIndex = 7;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCadastroDeCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroDeCategoria";
            Text = "FormCadastroDeCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private Button button1;
    }
}