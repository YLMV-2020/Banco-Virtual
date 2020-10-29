using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.FabricaDatos;
using System.Collections.Generic;

namespace CapaAplicacion.Servicios
{
    public class RealizarTransaccionServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private ICuenta cuentaDAO;
        private IMovimiento movimientoDAO;
        private ITransaccion transaccionDAO;
        private IUsuario usarioDAO;

        public RealizarTransaccionServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

            cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

            transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public Movimiento buscarMovimiento(string codigo)
        {
            gestorDatos.abrirConexion();
            Movimiento movimiento = movimientoDAO.buscarPorCodigo(codigo);
            gestorDatos.cerrarConexion();
            return movimiento;
        }
        public void guardarTransaccion(Transaccion transaccion)
        {
            RegistroTransaccion registroDeTransaccion = new RegistroTransaccion();
            //registroDeTransaccion.validarTransaccion(transaccion);
            gestorDatos.iniciarTransaccion();
            transaccionDAO.guardarTransaccion(transaccion);
            gestorDatos.terminarTransaccion();
        }
    }
}
