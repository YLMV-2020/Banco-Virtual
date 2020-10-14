using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mono.Data.Sqlite;
using CapaDominio.Contratos;
using CapaDominio.Entidades;

namespace CapaPersistencia.ADO_SQLServer
{
    public class UsuarioDAO : IUsuario
    {

        private GestorSQL gestorSQL;
        public UsuarioDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string consultaSQL = "select * from Usuario";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombres = resultadoSQL.GetString(1);
                    usuario.Apellidos = resultadoSQL.GetString(2);
                    usuario.Dni = resultadoSQL.GetString(3);
                    usuario.NumeroDeTarjeta = resultadoSQL.GetString(4);
                    usuario.Clave = resultadoSQL.GetString(5);
                    usuarios.Add(usuario);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return usuarios;
        }       

        public Usuario buscarPorDni(string dni)
        {
            Usuario usuario;
            string consultaSQL = "select * from Usuario where dni = \"" + dni + "\"";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = obtenerUsuario(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe usuario.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return usuario;
        }

        private Usuario obtenerUsuario(IDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
            usuario.Nombres = resultadoSQL.GetString(1);
            usuario.Apellidos = resultadoSQL.GetString(2);
            usuario.Dni = resultadoSQL.GetString(3);
            usuario.NumeroDeTarjeta = resultadoSQL.GetString(4);
            usuario.Clave = resultadoSQL.GetString(5);
            return usuario;
        }
    }
}
