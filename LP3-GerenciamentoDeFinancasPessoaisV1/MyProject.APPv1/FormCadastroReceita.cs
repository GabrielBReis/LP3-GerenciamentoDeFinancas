using MyProject.BLL;
using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class FormCadastroReceita : Form
    {
        public FormCadastroReceita()
        {
            InitializeComponent();
            PreencherComboBoxCategorias();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse(txtData.Text);
            double valor = double.Parse(txtValor.Text);
            string descricao = txtDescricao.Text;
            string nomeCategoria = comboBox1.SelectedItem.ToString();
            string senha = txtSenha.Text;
            Usuario usuario = UsuarioRepository.GetBySenha(senha);

            if (usuario != null)
            {

                Categorium categoria = CategoriaRepository.GetByNome(nomeCategoria);


                if (categoria != null)
                {
                    int nextDespesaId = ReceitaRepository.GetLastReceitaId() + 1;
                    Receita receita = new Receita
                    {
                        Id = nextDespesaId,
                        Data = data,
                        Valor = valor,
                        Descricao = descricao,
                        Idcategoria = categoria.Id,
                        Idusuario = usuario.Id
                    };

                    ReceitaRepository.Add(receita);
                    MessageBox.Show("Receita cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado. Verifique o login.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma categoria válida.");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
