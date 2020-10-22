using CapaDominio.Entidades;
using System.Collections.Generic;

namespace CapaDominio.Contratos
{
    public interface ICuenta
    {
        void guardarCuenta(Cuenta cuenta);
        List<Cuenta> obtenerListaDeCuentas();
        Cuenta buscarPorNumeroCuenta(string numero);
        Cuenta buscarPorNumeroInterbancario(string numero);

    } 
}
