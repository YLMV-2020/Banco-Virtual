using CapaDominio.Contratos;
using CapaDominio.Entidades;
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

            //cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            //movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

            //transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public List<Movimiento> buscarMovimientos(string codigoDeMovimiento)
        {
            gestorDatos.abrirConexion();
            //List<Movimiento> listaDeMovimientos = movimientoDAO.buscar(codigoDeMovimiento);
            gestorDatos.cerrarConexion();
            //return listaDeMovimientos;
            return null;
        }
        public void guardarTransaccion(Transaccion transaccion)
        {
            //RegistroDeTransaccion registroDeTransaccion = new RegistroDeMovimiento();
            //registroDeTransaccion.validarTransaccion(transaccion);
            //gestorDatos.iniciarTransaccion();
            //transaccionDAO.guardar(transaccion);
            //gestorDatos.terminarTransaccion();
        }
    }
}
