using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public static class UsuarioRepository
    {

        public static void Add(Usuario _usuario)
        {
            using (var DbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                DbContext.Add(_usuario);
                DbContext.SaveChanges();
            }
        }

        public static Usuario GetById(int id)
        {
            using (var DbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {

                Usuario usuario = DbContext.Usuarios.SingleOrDefault(p => p.Id == id);

                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    return null; // Retorna null se o usuário não for encontrado
                }
            }

        }

        public static Usuario GetBySenha(String _senha)
        {
            using (var DbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {

                Usuario usuario = DbContext.Usuarios.SingleOrDefault(p => p.Senha == _senha);

                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    return null; 
                }
            }

        }

        public static List<Usuario> getAll()
        {
            using (var DbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario =DbContext.Usuarios.ToList();
                return usuario;
            }

        }

        public static void Excluir(Usuario _usuario)
        {
            using (var DbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario = DbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                DbContext.Remove(usuario);
                DbContext.SaveChanges();
            }

        }


    }
}
