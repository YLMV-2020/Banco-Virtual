using CapaDominio.Entidades;
using System;

namespace CapaDominio.Servicios
{
    public class RegistroDeUsuario
    {
        public void validarUsuario(Usuario usuario)
        {
            if (!usuario.validarInicioSesion(usuario))
            {
                throw new Exception("ERROR");
            }

        }
    }
}
