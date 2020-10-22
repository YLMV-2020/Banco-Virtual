using CapaDominio.Contratos;

namespace CapaPersistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {
            return new FabricaSQLServer();
        }

        public abstract IGestorAccesoDatos crearGestorAccesoDatos();
        public abstract IUsuario crearUsuarioDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract ICuenta crearCuentaDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract ITransaccion crearTransaccionDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IMovimiento crearMovimientoDAO(IGestorAccesoDatos gestorAccesoDatos);
    }
}
