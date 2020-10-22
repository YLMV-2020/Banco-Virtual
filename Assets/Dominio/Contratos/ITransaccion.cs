using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface ITransaccion
    {
        void guardarTransaccion(Transaccion transaccion);
        List<Transaccion> obtenerListaDeTransacciones();
        Transaccion buscarPorCodigo(string codigo);
    }
}
