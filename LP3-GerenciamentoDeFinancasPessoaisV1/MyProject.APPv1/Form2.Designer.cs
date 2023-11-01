namespace MyProject.APPv1
{
    partial class Form2
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
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            labelSaldoTotal = new Label();
            Nome = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(614, 279);
            button1.Name = "button1";
            button1.Size = new Size(174, 57);
            button1.TabIndex = 1;
            button1.Text = "Adicionar Receita";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(614, 205);
            button3.Name = "button3";
            button3.Size = new Size(174, 57);
            button3.TabIndex = 3;
            button3.Text = "Adicionar Despesa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Data, valor, Descrição, Tipo });
            dataGridView1.Location = new Point(27, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 334);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(614, 132);
            button4.Name = "button4";
            button4.Size = new Size(174, 57);
            button4.TabIndex = 5;
            button4.Text = "Cadastrar Categoria";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labelSaldoTotal
            // 
            labelSaldoTotal.AutoSize = true;
            labelSaldoTotal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSaldoTotal.Location = new Point(507, 394);
            labelSaldoTotal.Name = "labelSaldoTotal";
            labelSaldoTotal.Size = new Size(188, 37);
            labelSaldoTotal.TabIndex = 7;
            labelSaldoTotal.Text = "Saldo R$------";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 10;
            Nome.Name = "Nome";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 10;
            Data.Name = "Data";
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            // 
            // Descrição
            // 
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            Descrição.Resizable = DataGridViewTriState.True;
            Descrição.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSaldoTotal);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Label labelSaldoTotal;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn Tipo;
    }
}