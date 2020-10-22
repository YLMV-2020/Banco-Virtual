using CapaDominio.Contratos;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaPersistencia.ADO_SQLServer
{
    public class MovimientoDAO : IMovimiento
    {
        private GestorSQL gestorSQL;

        public MovimientoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarMovimiento(Movimiento movimiento)
        {
            string consultaSQL = String.Format("insert into Movimiento" +
                "(codigo, hora, moneda, monto, nombreDestinatario) " +
                "values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")",
                movimiento.Codigo, movimiento.Hora, movimiento.Moneda, movimiento.Monto, movimiento.NombreDestinatario);

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

        public List<Movimiento> obtenerListaDeMovimientos()
        {
            List<Movimiento> movimientos = new List<Movimiento>();

            string consultaSQL = "select * from Movimiento";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {                   
                    movimientos.Add(obtenerMovimiento(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return movimientos;
        }

        public Movimiento buscarPorCodigo(string codigo)
        {
            Movimiento movimiento;
            string consultaSQL = "select * from Movimiento where codigo = \"" + codigo + "\"";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    movimiento = obtenerMovimiento(resultadoSQL);
                    resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe movimiento.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return movimiento;
        }

        private Movimiento obtenerMovimiento(IDataReader resultadoSQL)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Codigo = resultadoSQL.GetString(1);
            //movimiento.Hora = resultadoSQL.GetString(2);
            //movimiento.Moneda = resultadoSQL.GetString(3);
            movimiento.Monto = resultadoSQL.GetFloat(4);
            movimiento.NombreDestinatario = resultadoSQL.GetString(5);
            return movimiento;
        }

    }
}