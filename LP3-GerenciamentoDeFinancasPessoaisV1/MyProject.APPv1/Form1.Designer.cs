using MyProject.BLL;
namespace MyProject.APPv1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConectar = new Button();
            checkBox1 = new CheckBox();
            txtUsuarioID = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-73, 38);
            label1.Name = "label1";
            label1.Size = new Size(779, 92);
            label1.TabIndex = 0;
            label1.Text = "                                            Bem Vindo!\r\n                 Ao seu gerenciador de Finanças Pessoais\r\n";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(276, 337);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(191, 64);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(319, 280);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Manter Conectado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.ForeColor = SystemColors.WindowFrame;
            txtUsuarioID.Location = new Point(253, 159);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(234, 23);
            txtUsuarioID.TabIndex = 3;
            txtUsuarioID.Text = "login";
            // 
            // txtSenha
            // 
            txtSenha.ForeColor = SystemColors.WindowFrame;
            txtSenha.Location = new Point(253, 242);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(234, 23);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.ForeColor = SystemColors.WindowFrame;
            txtNome.Location = new Point(253, 200);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 23);
            txtNome.TabIndex = 5;
            txtNome.Text = "Nome";
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuarioID);
            Controls.Add(checkBox1);
            Controls.Add(btnConectar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConectar;
        private CheckBox checkBox1;
        private TextBox txtUsuarioID;
        private TextBox txtSenha;
        private TextBox txtNome;
    }
}