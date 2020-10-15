using CapaDominio.Contratos;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;

namespace CapaPersistencia.ADO_SQLServer
{
    public class MovimientoDAO : IMovimiento
    {
        private GestorSQL gestorSQL;

        public MovimientoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //public List<Movimiento> buscarMovimiento(string numero)
        //{
        //    List<Movimiento> listaDeMovimientos = new List<Movimiento>();
        //    Movimiento movimiento;
        //    string consultaSQL = "select * from Movimiento where nombre like '%" + codigoDeMovimiento + "'";
        //    try
        //    {
        //        SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
        //        while (resultadoSQL.Read())
        //        {
        //            moviento = obtenerMovimiento(resultadoSQL);
        //            listaDeMovimientos.Add(movimiento);
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        throw err;
        //    }
        //    return listaDeMovimientos;
        //}



        //private Movimiento obtenerMovimiento(SqlDataReader resultadoSQL)
        //{
        //    Movimiento movimiento = new Movimiento();
        //    movimiento.CodigoDeMovimiento = resultadoSQL.GetString(0);
        //    movimiento.TipoDeMoneda = resultadoSQL.GetString(1);
        //    movimiento.TipoMovimiento = resultadoSQL.GetString(2);
        //    return movimiento;
        //}

    }
}