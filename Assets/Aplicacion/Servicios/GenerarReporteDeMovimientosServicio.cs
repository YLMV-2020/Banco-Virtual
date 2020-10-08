using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.ADO_SQLServer;
using CapaPersistencia.FabricaDatos;


namespace CapaAplicacion.Servicios
{
	public class GenerarReporteDeMovimientosServicio
	{
		private IGestorAccesoDatos gestorDatos;
		private ICuenta	cuentaDAO;
		private IMovimiento movimientoDAO;
		//private ITransaccion transaccionDAO;
		private IUsuario usarioDAO;
	

		public GenerarReporteDeMovimientosServicio()
		{
			FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

			gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

			//cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

			//movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

			//transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

			//usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
		}

		public List<Movimiento> buscarMovimientos(string codigoDeMovimiento)
		{
			gestorDatos.abrirConexion();
			//List<Movimiento> listaDeMovimientos = movimientoDAO.buscar(codigoDeMovimiento);
			gestorDatos.cerrarConexion();
			//return listaDeMovimientos;
			return null;
		}

		/*public Cuenta buscarTransaccion(string numeroDeTransaccion)
		{
			gestorDatos.abrirConexion();
			Transaccion transaccion = transaccionDAO.buscarPorNumero(numero);
			gestorDatos.cerrarConexion();
			return transaccion;
		}*/

		public void guardarMovimiento(Movimiento movimiento)
		{
			RegistroDeMovimiento registroDeMovimiento = new RegistroDeMovimiento();
			registroDeMovimiento.validarMovimiento(movimiento);
			//gestorDatos.iniciarMovimiento();
			//movimientoDAO.guardar(movimiento);
			//gestorDatos.terminarMovimiento();
		}
	}
}
