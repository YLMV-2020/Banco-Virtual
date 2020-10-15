using CapaDominio.Contratos;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaPersistencia.ADO_SQLServer
{
    public class CuentaDAO : ICuenta
    {
        private GestorSQL gestorSQL;

        public CuentaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //public Cuenta buscarPorNumeroCuenta(string numero)
        //{
        //    Cuenta cuenta;
        //    string consultaSQL = "select numeroDeCuenta, nombre from Cuenta where numeroDeCuenta = '" + numero + "'";
        //    try
        //    {
        //        SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
        //        if (resultadoSQL.Read())
        //        {
        //            cuenta = obtenerCuenta(resultadoSQL);
        //        }
        //        else
        //        {
        //            throw new Exception("No existe cuenta.");
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        throw err;
        //    }
        //    return cuenta;
        //}

        //public List<Transaccion> buscarTransaccion(string numero)
        //{
        //    return null;
        //}

        private Cuenta obtenerCuenta(IDataReader resultadoSQL)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Numero = resultadoSQL.GetString(0);
            cuenta.NumeroInterbancario = resultadoSQL.GetString(1);
            cuenta.Saldo = resultadoSQL.GetFloat(2);
            return cuenta;
        }
    }
}
