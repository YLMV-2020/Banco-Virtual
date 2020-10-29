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
        public List<Usuario> obtenerListaDeUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string consultaSQL = "select * from Usuario";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    usuarios.Add(obtenerUsuario(resultadoSQL));
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
                    resultadoSQL.Close();
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

        public void guardarUsuario(Usuario usuario)
        {
            string consultaSQL = String.Format("insert into Usuario(nombres, apellidos, dni, numeroTarjeta, clave) values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", usuario.Nombres, usuario.Apellidos, usuario.Dni, usuario.NumeroDeTarjeta, usuario.Clave);

            try
            {
                IDbCommand resultadoSQL = gestorSQL.obtenerComandoSQL(consultaSQL);
                resultadoSQL.ExecuteScalar();
                resultadoSQL.Dispose();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }
        }

        private Usuario obtenerUsuario(IDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
            usuario.Dni = resultadoSQL.GetString(0);
            usuario.Nombres = resultadoSQL.GetString(2);
            usuario.Apellidos = resultadoSQL.GetString(3);
            usuario.NumeroDeTarjeta = resultadoSQL.GetString(4);
            usuario.Clave = resultadoSQL.GetString(5);
            usuario.Estado = resultadoSQL.GetInt16(6) == 1 ? true : false;
            return usuario;
        }
    }
}
