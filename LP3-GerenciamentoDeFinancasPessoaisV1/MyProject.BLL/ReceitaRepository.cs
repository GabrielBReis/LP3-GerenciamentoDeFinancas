﻿using MyProject.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public static class ReceitaRepository
    {
        public static void Add(Receita _receita)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Receitas.Add(_receita);
                dbContext.SaveChanges();
            }
        }

        public static Receita GetById(int id)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var receita = dbContext.Receitas.SingleOrDefault(r => r.Id == id);
                return receita;
            }
        }

        public static List<Receita> GetAll()
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var receitas = dbContext.Receitas.ToList();
                return receitas;
            }
        }

        public static void Excluir(Receita _receita)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var existingReceita = dbContext.Receitas.SingleOrDefault(r => r.Id == _receita.Id);
                if (existingReceita != null)
                {
                    dbContext.Receitas.Remove(existingReceita);
                    dbContext.SaveChanges();
                }
            }
        }

        public static List<Receita> GetReceitasByUsuario(int usuarioId)
        {
            using (var dbContext = new CUsersGBRDocumentsRepositoriovsLp3Gerenciamentodefinancaspessoaisv1MyprojectDalDatabaseDatabase1MdfContext())
            {
                var receitas = dbContext.Receitas.Where(r => r.Idusuario == usuarioId).ToList();
                return receitas;
            }
        }
    }
}
