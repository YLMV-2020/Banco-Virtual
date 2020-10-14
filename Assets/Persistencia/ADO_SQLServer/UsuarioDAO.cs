using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;

namespace CapaPersistencia.ADO_SQLServer
{
    class UsuarioDAO/* : IUsuario*/
    {

        private GestorSQL gestorSQL;

        //public CuentaDAO(IGestorAccesoDatos gestorSQL)
        //{
        //    this.gestorSQL = (GestorSQL)gestorSQL;
        //}

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

        //private Cuenta obtenerCuenta(SqlDataReader resultadoSQL)
        //{
        //    Cuenta cuenta = new Cuenta();
        //    cuenta.NumeroDeCuenta = resultadoSQL.GetString(0);
        //    cuenta.MontoActual = resultadoSQL.GetString(1);
        //    return cuenta;
        //}
    }
}
