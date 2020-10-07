sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDominio.Entidades;
using CapaDominio.Contratos;

namespace CapaPersistencia.ADO_SQLServer
{
    public class CuentaDAO : ICuenta
    {
        private GestorSQL gestorSQL;

        public CuentaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public Cuenta buscarPorNumero(string numero)
        {
            Cliente cliente;
            string consultaSQL = "select numeroDeCuenta, nombre from Cuenta where numeroDeCuenta = '" + numeroDeCuenta + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cliente = obtenerCuenta(resultadoSQL);
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
            return cliente;
        }

        private Cuenta obtenerCuenta(SqlDataReader resultadoSQL)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.NumeroDeCuenta = resultadoSQL.GetString(0);
            cuenta.MontoActual = resultadoSQL.GetString(1);
            return cuenta;
        }
    }
}
