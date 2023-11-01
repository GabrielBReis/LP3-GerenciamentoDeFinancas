using MyProject.BLL;
using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class Form2 : Form
    {
        public Usuario Usuario { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Usuario usuario)
        {
            Usuario = usuario;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
            AtualizarSaldoTotal(); // Atualiza o saldo total ao carregar o formulário
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.Rows.Clear();

            // 1. Obter as receitas e despesas associadas ao usuário logado
            List<Receita> receitas = ReceitaRepository.GetReceitasByUsuario(Usuario.Id);
            List<Despesa> despesas = DespesaRepository.GetDespesasByUsuario(Usuario.Id);

            // 2. Preencher o DataGridView com os dados das receitas
            foreach (Receita receita in receitas)
            {
                Categorium categoria = CategoriaRepository.GetById(receita.Idcategoria);
                string nomeCategoria = categoria != null ? categoria.Nome : "Categoria não encontrada";

                dataGridView1.Rows.Add("Receita", receita.Data, receita.Valor, receita.Descricao, nomeCategoria);
            }

            // 3. Preencher o DataGridView com os dados das despesas
            foreach (Despesa despesa in despesas)
            {
                Categorium categoria = CategoriaRepository.GetById(despesa.Idcategoria);
                string nomeCategoria = categoria != null ? categoria.Nome : "Categoria não encontrada";

                dataGridView1.Rows.Add("Despesa", despesa.Data, despesa.Valor, despesa.Descricao, nomeCategoria);
            }

            // Após atualizar o DataGridView, também atualize o saldo total
            AtualizarSaldoTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCadastroDeCategoria formCadastroDeCategoria = new FormCadastroDeCategoria();
            formCadastroDeCategoria.ShowDialog(); // Use ShowDialog para exibir o formulário de forma modal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCadastroDeDespesas formCadastroDeDespesa = new FormCadastroDeDespesas();
            formCadastroDeDespesa.ShowDialog(); // Use ShowDialog para exibir o formulário de forma modal
            AtualizarDataGridView(); // Atualiza o DataGridView após adicionar uma despesa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroReceita formCadastroReceita = new FormCadastroReceita();
            formCadastroReceita.ShowDialog(); // Use ShowDialog para exibir o formulário de forma modal
            AtualizarDataGridView(); // Atualiza o DataGridView após adicionar uma receita
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Categoria"].Index)
            {
                // Verifique se a célula atual é a coluna de Categoria
                ComboBox comboBox = e.Control as ComboBox;

                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manipular a seleção no ComboBox

            ComboBox comboBox = (ComboBox)sender;
            string novaCategoria = comboBox.SelectedItem.ToString();

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string tipo = dataGridView1.Rows[rowIndex].Cells["Tipo"].Value.ToString();

            if (tipo == "Receita")
            {
                int receitaId = GetReceitaIdFromRow(rowIndex);
                if (receitaId != -1)
                {
                    UpdateCategoriaDaReceita(receitaId, novaCategoria);
                    AtualizarDataGridView();
                }
            }
            else if (tipo == "Despesa")
            {
                int despesaId = GetDespesaIdFromRow(rowIndex);
                if (despesaId != -1)
                {
                    UpdateCategoriaDaDespesa(despesaId, novaCategoria);
                    AtualizarDataGridView();
                }
            }
        }

        private int GetReceitaIdFromRow(int rowIndex)
        {
            // Obtenha o ID da receita com base no valor da célula do grid na coluna da ID da receita
            if (int.TryParse(dataGridView1.Rows[rowIndex].Cells["ID da Receita"].Value.ToString(), out int receitaId))
            {
                return receitaId;
            }
            return -1; // Ou outra ação apropriada em caso de erro
        }

        private void UpdateCategoriaDaReceita(int receitaId, string novaCategoria)
        {
            Receita receita = ReceitaRepository.GetById(receitaId);

            if (receita != null)
            {
                Categorium categoria = CategoriaRepository.GetByNome(novaCategoria);
                if (categoria != null)
                {
                    receita.Idcategoria = categoria.Id;
                    ReceitaRepository.Update(receita); // Implemente esta função para atualizar a receita
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada. Verifique a seleção.");
                }
            }
            else
            {
                MessageBox.Show("Receita não encontrada. Verifique a seleção.");
            }
        }

        private int GetDespesaIdFromRow(int rowIndex)
        {
            // Obtenha o ID da despesa com base no valor da célula do grid na coluna da ID da despesa
            if (int.TryParse(dataGridView1.Rows[rowIndex].Cells["ID da Despesa"].Value.ToString(), out int despesaId))
            {
                return despesaId;
            }
            return -1; // Ou outra ação apropriada em caso de erro
        }

        private void UpdateCategoriaDaDespesa(int despesaId, string novaCategoria)
        {
            Despesa despesa = DespesaRepository.GetById(despesaId);

            if (despesa != null)
            {
                Categorium categoria = CategoriaRepository.GetByNome(novaCategoria);
                if (categoria != null)
                {
                    despesa.Idcategoria = categoria.Id;
                    DespesaRepository.Update(despesa); // Implemente esta função para atualizar a despesa
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada. Verifique a seleção.");
                }
            }
            else
            {
                MessageBox.Show("Despesa não encontrada. Verifique a seleção.");
            }
        }


        private void AtualizarSaldoTotal()
        {
            List<Receita> receitas = ReceitaRepository.GetReceitasByUsuario(Usuario.Id);
            List<Despesa> despesas = DespesaRepository.GetDespesasByUsuario(Usuario.Id);

            double totalReceitas = receitas.Sum(receita => receita.Valor);
            double totalDespesas = despesas.Sum(despesa => despesa.Valor);

            double saldoTotal = totalReceitas - totalDespesas;

            labelSaldoTotal.Visible = true; // Torna o Label visível
            if (saldoTotal >= 0)
            {
                labelSaldoTotal.ForeColor = Color.Green; // Define a cor verde para valores positivos
            }
            else
            {
                labelSaldoTotal.ForeColor = Color.Red; // Define a cor vermelha para valores negativos
            }
            labelSaldoTotal.Text = "Saldo Total: " + saldoTotal.ToString("C");
        }
    }
}
