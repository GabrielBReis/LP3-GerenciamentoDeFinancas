using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.MODEL;

namespace MyProject.BLL
{
    public static class SaldoRepository
    {
        public static void AtualizarSaldo(int usuarioId, double novoSaldo)
        {
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var saldo = dbContext.Saldos.SingleOrDefault(s => s.Idusuario == usuarioId);

                if (saldo != null)
                {
                    saldo.Valor = novoSaldo;
                }
                else
                {
                    // Se não existir um saldo para o usuário, crie um novo.
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
            using (var dbContext = new CUsersPichauSourceReposLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabaseMdfContext())
            {
                var saldo = dbContext.Saldos.SingleOrDefault(s => s.Idusuario == usuarioId);
                if (saldo != null)
                {
                    return saldo.Valor;
                }
                else
                {
                    return 0; // Se o saldo não existir, retorne zero.
                }
            }
        }
    }
}