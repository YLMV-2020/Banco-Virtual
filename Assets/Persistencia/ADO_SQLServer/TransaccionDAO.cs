using CapaDominio.Contratos;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaPersistencia.ADO_SQLServer
{
    public class TransaccionDAO : ITransaccion
    {
        private GestorSQL gestorSQL;

        public TransaccionDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarTransaccion(Transaccion transaccion)
        {
            string consultaSQL = String.Format("insert into Transaccion" +
                "(codigo, fecha, monto, tipo, valoracion) " +
                "values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")",
                transaccion.Codigo, transaccion.Fecha, transaccion.Monto, transaccion.Tipo, transaccion.Valoracion);

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

        public List<Transaccion> obtenerListaDeTransacciones()
        {
            List<Transaccion> transacciones = new List<Transaccion>();

            string consultaSQL = "select * from Movimiento";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    transacciones.Add(obtenerTransaccion(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return transacciones;
        }

        public Transaccion buscarPorCodigo(string codigo)
        {
            Transaccion transaccion;
            string consultaSQL = "select * from Transaccion where codigo = \"" + codigo + "\"";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    transaccion = obtenerTransaccion(resultadoSQL);
                    resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe transaccion.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return transaccion;
        }

        private Transaccion obtenerTransaccion(IDataReader resultadoSQL)
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Codigo = resultadoSQL.GetString(1);
            //transaccion.Fecha = resultadoSQL.GetString(2);
            transaccion.Monto = resultadoSQL.GetFloat(3);
            //transaccion.Tipo = resultadoSQL.GetString(4);
            transaccion.Valoracion = resultadoSQL.GetInt32(5);
            return transaccion;
        }

    }
}

