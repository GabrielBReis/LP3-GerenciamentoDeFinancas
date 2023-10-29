using System;
using System.Collections.Generic;

namespace MyProject.DAL.DBContext;

public partial class Saldo
{
    public int Id { get; set; }

    public double Valor { get; set; }

    public int Idusuario { get; set; }

    public virtual Usuario IdusuarioNavigation { get; set; } = null!;
}
