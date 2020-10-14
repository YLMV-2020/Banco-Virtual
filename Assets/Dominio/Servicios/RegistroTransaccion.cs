using System;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroTransaccion
    {
        public void validarTrasaccion(Transaccion transaccion, Banco banco, Usuario usuario)
        {
            if (!transaccion.validarMonto())
            {
                throw new Exception("ERROR");
            }
            if (!banco.validarUsuario(usuario))
            {
                throw new Exception("No se puede transferir, usuario inválido.");
            }
        }
    }
}
