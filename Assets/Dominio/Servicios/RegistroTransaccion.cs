using System;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroTransaccion
    {
        public void validarTransaccion(Transaccion transaccion)
        {
            if (!transaccion.validarMonto())
            {
                throw new Exception("ERROR");
            }
        }
    }
}
