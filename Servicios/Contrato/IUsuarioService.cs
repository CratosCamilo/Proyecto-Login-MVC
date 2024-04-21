using Microsoft.EntityFrameworkCore;
using Proyecto_Login_MVC_.NET.Models;

namespace Proyecto_Login_MVC_.NET.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave);

        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
