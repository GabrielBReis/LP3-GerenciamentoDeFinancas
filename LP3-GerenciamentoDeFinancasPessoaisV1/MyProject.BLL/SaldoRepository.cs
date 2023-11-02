using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public static class SaldoRepository
    {
        public static void AtualizarSaldo(int usuarioId, double novoSaldo)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var saldo = dbContext.Saldos.SingleOrDefault(s => s.Idusuario == usuarioId);

                if (saldo != null)
                {
                    saldo.Valor = novoSaldo;
                }
                else
                {
                    
                    saldo = new Saldo
                    {
                        Idusuario = usuarioId,
                        Valor = novoSaldo
                    };
                    dbContext.Saldos.Add(saldo);
                }

                dbContext.SaveChanges();
            }
        }

        public static double ObterSaldo(int usuarioId)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var saldo = dbContext.Saldos.SingleOrDefault(s => s.Idusuario == usuarioId);
                if (saldo != null)
                {
                    return saldo.Valor;
                }
                else
                {
                    return 0; 
                }
            }
        }
    }
}