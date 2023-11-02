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

namespace MyProject.APPv1
{
    public partial class FormCadastroDeCategoria : Form
    {
        public FormCadastroDeCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCategoria = txtNome.Text;
            string descricao = txtDescricao.Text;

            int proximoId = CategoriaRepository.GetNextCategoryId();

            Categorium novaCategoria = new Categorium
            {
                Id = proximoId,
                Nome = nomeCategoria,
                Descricao = descricao
            };

            CategoriaRepository.Add(novaCategoria);
            MessageBox.Show("Categoria cadastrada com sucesso!");
        }

    }
}
