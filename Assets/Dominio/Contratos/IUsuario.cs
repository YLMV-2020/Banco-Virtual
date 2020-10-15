using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface IUsuario
    {
        List<Usuario> obtenerUsuarios();
        Usuario buscarPorDni(string dni);
        void guardarUsuario(Usuario usuario);
    }
}
