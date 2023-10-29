using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public static class DespesaRepository
    {
        public static void Add(Despesa _despesa)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Despesas.Add(_despesa);
                dbContext.SaveChanges();
            }
        }

        public static Despesa GetById(int id)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var despesa = dbContext.Despesas.SingleOrDefault(d => d.Id == id);
                return despesa;
            }
        }

        public static List<Despesa> GetAll()
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var despesas = dbContext.Despesas.ToList();
                return despesas;
            }
        }

        public static void Excluir(Despesa _despesa)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var existingDespesa = dbContext.Despesas.SingleOrDefault(d => d.Id == _despesa.Id);
                if (existingDespesa != null)
                {
                    dbContext.Despesas.Remove(existingDespesa);
                    dbContext.SaveChanges();
                }
            }
        }

        public static List<Despesa> GetDespesasByUsuario(int usuarioId)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var despesas = dbContext.Despesas.Where(d => d.Idusuario == usuarioId).ToList();
                return despesas;
            }
        }
    }
}

