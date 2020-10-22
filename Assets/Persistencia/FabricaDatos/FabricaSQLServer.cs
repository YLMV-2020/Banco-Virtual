using CapaDominio.Contratos;
using CapaPersistencia.ADO_SQLServer;

namespace CapaPersistencia.FabricaDatos
{
    public class FabricaSQLServer : FabricaAbstracta
    {
        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSQL();
        }

        public override IUsuario crearUsuarioDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new UsuarioDAO(gestorAccesoDatos);
        }

        public override ICuenta crearCuentaDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new CuentaDAO(gestorAccesoDatos);
        }

        public override ITransaccion crearTransaccionDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new TransaccionDAO(gestorAccesoDatos);
        }

        public override IMovimiento crearMovimientoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new MovimientoDAO(gestorAccesoDatos);
        }
    }
}