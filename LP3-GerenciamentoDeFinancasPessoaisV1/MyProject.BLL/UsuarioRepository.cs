using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.MODEL;

namespace MyProject.BLL
{
    public static class UsuarioRepository
    {

        public static void Add(Usuario _usuario)
        {
            using (var DbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                DbContext.Add(_usuario);
                DbContext.SaveChanges();
            }
        }

        public static Usuario GetById(int id)
        {
            using (var DbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
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

        public static List<Usuario> getAll()
        {
            using (var DbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var usuario =DbContext.Usuarios.ToList();
                return usuario;
            }

        }

        public static void Excluir(Usuario _usuario)
        {
            using (var DbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var usuario = DbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                DbContext.Remove(usuario);
                DbContext.SaveChanges();
            }

        }


    }
}
