using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.DAL.DBContext
{
    public partial class Categorium
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; } = new List<Despesa>();
        public virtual ICollection<Receita> Receita { get; set; } = new List<Receita>();
    }
}
