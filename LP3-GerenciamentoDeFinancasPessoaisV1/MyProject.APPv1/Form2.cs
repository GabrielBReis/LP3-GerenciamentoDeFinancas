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
using MyProject.MODEL;

namespace MyProject.APPv1
{
    public partial class Form2 : Form
    {
        public Usuario? Usuario { get; }
        public Usuario Usuario1 { get; }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
