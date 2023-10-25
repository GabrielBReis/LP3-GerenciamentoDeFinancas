using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string Senha { get; set; } = null!;
}
