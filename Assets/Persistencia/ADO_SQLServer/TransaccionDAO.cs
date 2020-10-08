using CapaDominio.Contratos;
using CapaDominio.Entidades;
using System;

namespace CapaPersistencia.ADO_SQLServer
{
    public class TransaccionDAO /*: ITransaccion*/
    {
        //private GestorSQL gestorSQL;

        //public TransaccionDAO(IGestorAccesoDatos gestorSQL)
        //{
        //    this.gestorSQL = (GestorSQL)gestorSQL;
        //}

        //public void guardarTransaccion(Transaccion transaccion)
        //{
        //    // CREANDO LAS SENTENCIAS SQL
        //    string insertarMovimiento1SQL, insertarMovimiento2SQL, insertarTransaccionSQL, actualizarCuentaSQL;

        //    insertarMovimiento1SQL = "insert into Venta(codigoDeMovimiento,tipoDeMoneda,tipoMovimiento) " +
        //        "values(@codigoDeMovimiento,@tipoDeMoneda,@tipoMovimiento)";

        //    insertarMovimiento2SQL = "insert into Venta(codigoDeMovimiento,tipoDeMoneda,tipoMovimiento) " +
        //        "values(@codigoDeMovimiento,@tipoDeMoneda,@tipoMovimiento)";

        //    insertarTransaccionSQL = "insert into Transaccion(numeroDeTransaccion,fechaTransaccion,montoDeTrasferencia,valoracion,codigoDeMovimiento) " +
        //        "values(@numeroDeTransaccion,@fechaTransaccion,@montoDeTrasferencia,@valoracion,@codigoDeMovimiento)";

        //    actualizarCuentaSQL = "update Cuenta set montoActual = @montoActual where numeroDeCuenta = @numeroDeCuenta";

        //    try
        //    {
        //        SqlCommand comando;
        //        Movimiento movimiento;
        //        // GUARDANDO EL OBJETO 
        //        if (venta.Cliente != null)
        //        {
        //            comando = gestorSQL.obtenerComandoSQL(insertarTransaccion1SQL);
        //            comando.Parameters.AddWithValue("@numeroDeCuenta", transaccion.Cuenta.NumeroDeCuenta);
        //        }
        //        else
        //        {
        //            comando = gestorSQL.obtenerComandoSQL(insertarVenta2SQL);
        //        }
        //        comando.Parameters.AddWithValue("@numeroDetransaccion", transaccion.NumeroDetransaccion);
        //        comando.Parameters.AddWithValue("@fecha", transaccion.FechaTrasaccion.Date);
        //        comando.ExecuteNonQuery();

        //        // GUARDANDO LOS OBJETOS 
        //        foreach (Movimiento movimiento in transaccion.ListaMovimientos)
        //        {

        //            movimiento = transaccion.Movimiento;
        //            cuenta = transaccion.Cuenta;

        //            comando = gestorSQL.obtenerComandoSQL(insertarLineaDeVentaSQL);
        //            comando.Parameters.AddWithValue("@numero", transaccion.Numero);
        //            comando.Parameters.AddWithValue("@codigo", movimiento.Codigo);
        //            comando.Parameters.AddWithValue("@montoDetransferencia", transaccion.MontoDeTransferencia);
        //            comando.Parameters.AddWithValue("@tipoDeMoneda", transaccion.TipoDeMoneda);
        //            comando.ExecuteNonQuery();
        //            // Actualizando
        //            comando = gestorSQL.obtenerComandoSQL(actualizarProductoSQL);
        //            comando.Parameters.AddWithValue("@montoActual", cuenta.MontoActual);
        //            comando.Parameters.AddWithValue("@numeroDeCuenta", cuenta.NumeroDeCuenta);
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Ocurrio un problema al intentar guardar.", err);
        //    }
        //}
    }
}

