using MyProject.BLL;
using MyProject.DAL.DBContext;

namespace MyProject.APPv1
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aqui você pode configurar sua interface, se necessário.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recolha o ID e a senha do TextBox
            int id = int.Parse(txtUsuarioID.Text);
            string senha = txtSenha.Text;
            string nome = txtNome.Text;

            // Verifique se o usuário está cadastrado no banco de dados
            Usuario usuario = UsuarioRepository.GetById(id);

            if (usuario == null)
            {
                // Se o usuário não existe, crie um novo usuário
                usuario = new Usuario
                {
                    Id = id,
                    Nome = nome,
                    Senha = senha
                };

                UsuarioRepository.Add(usuario);

                MessageBox.Show("Bem-vindo! Seu usuário foi criado com sucesso.");
            }
            else
            {
                // Se o usuário existe, exiba uma mensagem de boas-vindas
                MessageBox.Show("Bem-vindo!");
            }

            // Agora você pode prosseguir para a próxima tela
            form2.Usuario = usuario;
            form2.Show(); // Use Show() para abrir o formulário sem bloquear o Form1
            this.Hide(); // Oculta a tela de login
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
