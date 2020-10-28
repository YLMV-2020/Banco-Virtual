using CapaDominio.Contratos;
using System;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine;

namespace CapaPersistencia.ADO_SQLServer
{
    public class GestorSQL : IGestorAccesoDatos
    {

        private IDbConnection conexion;
        private IDbTransaction transaccion;

        string nombreDB = "BancoDB.db";

        public void abrirConexion()
        {
            try
            {
                string rutaDB = Application.dataPath + "/StreamingAssets/" + nombreDB;
                string conexionURI = "URI=file:" + rutaDB;
                conexion = new SqliteConnection(conexionURI);
                conexion.Open();
            }
            catch(Exception err)
            {
                throw new Exception("Error en la conexión con la Base de Datos.", err);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                conexion = null;
            }
            catch (Exception err)
            {
                throw new Exception("Error al cerrar la conexión con la Base de Datos.", err);
            }
        }

        public void iniciarTransaccion()
        {
            try
            {
                abrirConexion();
                transaccion = conexion.BeginTransaction();
            }
            catch (Exception err)
            {
                throw new Exception("Error al iniciar la transacción con la Base de Datos.", err);
            }
        }

        public void terminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                cerrarConexion();
            }
            catch (Exception err)
            {
                throw new Exception("Error al terminar la transacción con la Base de Datos.", err);
            }
        }

        public void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                cerrarConexion();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cancelar la transacción con la Base de Datos.", err);
            }
        }

        public IDataReader ejecutarConsulta(string sentenciaSQL)
        {
            try
            {
                IDbCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL.ExecuteReader();
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar consulta en la Base de Datos.", err);
            }
        }

        public IDbCommand obtenerComandoSQL(string sentenciaSQL)
        {
            try
            {
                IDbCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

        public IDbCommand obtenerComandoDeProcedimiento(string procedimientoAlmacenado)
        {
            try
            {
                IDbCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = procedimientoAlmacenado;
                comandoSQL.CommandType = CommandType.StoredProcedure;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }
    }
}
