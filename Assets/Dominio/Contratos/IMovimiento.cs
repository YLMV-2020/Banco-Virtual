using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface IMovimiento
    {
        void guardarMovimiento(Movimiento movimiento);
        List<Movimiento> obtenerListaDeMovimientos();
        Movimiento buscarPorCodigo(string codigo);
    }
}
