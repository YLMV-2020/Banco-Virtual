using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface IMovimiento
    {
        List<Movimiento> buscarMovimiento(string codigo);
    }
}
