﻿using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Despesa
{
    public int Id { get; set; }

    public DateTime Data { get; set; }

    public double Valor { get; set; }

    public string? Descricao { get; set; }

    public int Idcategoria { get; set; }

    public virtual Categorium IdcategoriaNavigation { get; set; } = null!;
}