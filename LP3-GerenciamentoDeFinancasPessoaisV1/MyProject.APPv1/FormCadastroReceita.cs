using MyProject.BLL;
using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyProject.APPv1
{
    public partial class FormCadastroReceita : Form
    {
        public FormCadastroReceita()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime data = DateTime.Parse(txtData.Text);
            double valor = double.Parse(txtValor.Text);
            string descricao = txtDescricao.Text;
            int categoria = int.Parse(txtCategoria.Text);
            string senha = txtSenha.Text;

            Usuario usuario = UsuarioRepository.GetBySenha(senha);

            if (usuario != null)
            {
                Receita receita = new Receita
                {
                    Data = data,
                    Valor = valor,
                    Descricao = descricao,
                    Idcategoria = categoria,
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

        private void AtualizarListaCategorias()
        {
 
            listViewCategorias.Items.Clear();

            List<Categorium> categorias = CategoriaRepository.GetAll();

            foreach (Categorium categoria in categorias)
            {
                ListViewItem item = new ListViewItem(categoria.Nome);
                item.SubItems.Add(categoria.Nome);
                listViewCategorias.Items.Add(item);
            }
        }
    }
}
