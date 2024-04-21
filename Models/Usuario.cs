using System;
using System.Collections.Generic;

namespace Proyecto_Login_MVC_.NET.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }
}
