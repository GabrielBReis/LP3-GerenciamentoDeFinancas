using MyProject.DAL.DBContext;
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
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Categoria.Add(_categoria);
                dbContext.SaveChanges();
            }
        }

        public static Categorium GetById(int id)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var categoria = dbContext.Categoria.SingleOrDefault(c => c.Id == id);
                return categoria;
            }
        }

        public static int GetNextCategoryId()
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                // Obtenha o último ID da tabela de categorias
                int ultimoId = dbContext.Categoria.Max(c => (int?)c.Id) ?? 0;

                // Calcule o próximo ID adicionando 1 ao último ID
                int novoId = ultimoId + 1;

                return novoId;
            }
        }


        public static Categorium GetByNome(string nomeCategoria)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var categoria = dbContext.Categoria.FirstOrDefault(c => c.Nome == nomeCategoria);
                return categoria;
            }
        }

        public static List<Categorium> GetAll()
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var categorias = dbContext.Categoria.ToList();
                return categorias;
            }
        }

        public static void Excluir(Categorium _categoria)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
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
