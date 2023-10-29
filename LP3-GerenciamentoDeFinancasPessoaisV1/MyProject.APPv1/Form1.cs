using MyProject.BLL;
using MyProject.DAL.DBContext;
using MyProject.MODEL;


namespace MyProject.APPv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aqui voc� pode configurar sua interface, se necess�rio.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recolha o ID e a senha do TextBox
            int id = int.Parse(txtUsuarioID.Text);
            string senha = txtSenha.Text;
            string nome = txtNome.Text;

            // Verifique se o usu�rio est� cadastrado no banco de dados
            Usuario usuario = UsuarioRepository.GetById(id);

            if (usuario == null)
            {
                // Se o usu�rio n�o existe, crie um novo usu�rio
                usuario = new Usuario
                {
                    Id = id,
                    Nome = nome,
                    Senha = senha
                };

                UsuarioRepository.Add(usuario);

                MessageBox.Show("Bem-vindo! Seu usu�rio foi criado com sucesso.");
            }
            else
            {
                // Se o usu�rio existe, exiba uma mensagem de boas-vindas
                MessageBox.Show("Bem-vindo!");
            }

            // Agora voc� pode prosseguir para a pr�xima tela
            Form2 form2 = new Form2(usuario);
            form2.Show(); // Use Show() para abrir o formul�rio sem bloquear o Form1
            this.Hide(); // Oculta a tela de login
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
