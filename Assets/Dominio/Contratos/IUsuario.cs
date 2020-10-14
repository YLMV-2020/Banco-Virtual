using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface IUsuario
    {
        //Usuario buscarPorNumeroUsuario(string numero);
        List<Usuario> obtenerUsuarios();
    }
}
