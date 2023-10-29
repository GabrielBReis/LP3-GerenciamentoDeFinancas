using MyProject.DAL.DBContext;
using MyProject.BLL;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Código para abrir o FormCadastroDespesa
            FormCadastroDespesa formCadastroDespesa = new FormCadastroDespesa();
            formCadastroDespesa.ShowDialog(); // Use ShowDialog para exibir o formulário de forma modal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Código para abrir o FormCadastroReceita
            FormCadastroReceita formCadastroReceita = new FormCadastroReceita();
            formCadastroReceita.ShowDialog(); // Use ShowDialog para exibir o formulário de forma modal

        }
    }
}
