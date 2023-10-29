using MyProject.DAL.DBContext;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public static class CategoriaRepository
    {
        public static void Add(Categorium _categoria)
        {
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                dbContext.Categoria.Add(_categoria);
                dbContext.SaveChanges();
            }
        }

        public static Categorium GetById(int id)
        {
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var categoria = dbContext.Categoria.SingleOrDefault(c => c.Id == id);
                return categoria;
            }
        }

        public static List<Categorium> GetAll()
        {
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var categorias = dbContext.Categoria.ToList();
                return categorias;
            }
        }

        public static void Excluir(Categorium _categoria)
        {
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var existingCategoria = dbContext.Categoria.SingleOrDefault(c => c.Id == _categoria.Id);
                if (existingCategoria != null)
                {
                    dbContext.Categoria.Remove(existingCategoria);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}