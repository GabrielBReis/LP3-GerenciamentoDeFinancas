using MyProject.BLL;
using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class FormCadastroDeDespesas : Form
    {
        public FormCadastroDeDespesas()
        {
            InitializeComponent();
            
        }

        private void FormCadastroDeDespesas_Load(object sender, EventArgs e)
        {
            PreencherComboBoxCategorias();
        }


        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse(textBox1.Text);
            double valor = double.Parse(textBox2.Text);
            string descricao = textBox3.Text;
            string nomeCategoria = comboBox1.SelectedItem.ToString();
            string senha = textBox4.Text;

            Usuario usuario = UsuarioRepository.GetBySenha(senha);

            if (usuario != null)
            {
                Categorium categoria = CategoriaRepository.GetByNome(nomeCategoria);

                if (categoria != null)
                {
                    int nextDespesaId = DespesaRepository.GetLastDespesaId() + 1;

                    Despesa despesa = new Despesa
                    {
                        Id = nextDespesaId,
                        Data = data,
                        Valor = valor,
                        Descricao = descricao,
                        Idcategoria = categoria.Id,
                        Idusuario = usuario.Id,
                    };

                    DespesaRepository.Add(despesa);
                    MessageBox.Show("Despesa cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada. Verifique a seleção.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado. Verifique a senha.");
            }
        }

        private void PreencherComboBoxCategorias()
        {
            comboBox1.Items.Clear();
            List<Categorium> categorias = CategoriaRepository.GetAll();
            foreach (Categorium categoria in categorias)
            {
                comboBox1.Items.Add(categoria.Nome);
            }
        }
    }
}
