using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface IUsuario
    {
        void guardarUsuario(Usuario usuario);
        List<Usuario> obtenerListaDeUsuarios();
        Usuario buscarPorDni(string dni);
    }
}
