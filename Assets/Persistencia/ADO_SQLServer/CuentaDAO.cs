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

        public void guardarCuenta(Cuenta cuenta)
        {
            string consultaSQL = String.Format("insert into Cuenta" +
                "(numero, numeroInterbancario, saldo, moneda, estado) " +
                "values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")",
                cuenta.Numero, cuenta.NumeroInterbancario, cuenta.Saldo, cuenta.Moneda, cuenta.Estado);

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

        public List<Cuenta> obtenerListaDeCuentas()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            string consultaSQL = "select * from Usuario";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    cuentas.Add(obtenerCuenta(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cuentas;
        }

        public Cuenta buscarPorNumeroCuenta(string numero)
        {
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta where numero = \"" + numero + "\"";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);
                    resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe cuenta.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cuenta;
        }

        public Cuenta buscarPorNumeroInterbancario(string numero)
        {
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta where numeroInterbancario = \"" + numero + "\"";
            try
            {
                IDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);
                    resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe cuenta.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cuenta;
        }

        private Cuenta obtenerCuenta(IDataReader resultadoSQL)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Numero = resultadoSQL.GetString(1);
            cuenta.NumeroInterbancario = resultadoSQL.GetString(2);
            cuenta.Saldo = resultadoSQL.GetFloat(3);
            //cuenta.Moneda = resultadoSQL.GetString(4);
            //cuenta.Estado = (bool)resultadoSQL.GetInt32(5);
            return cuenta;
        }

        

    }
}
