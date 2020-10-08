using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using CapaPersistencia.ADO_SQLServer;

namespace CapaPersistencia.FabricaDatos
{
    public class FabricaSQLServer : FabricaAbstracta
    {
        public override ICuenta crearCuentaDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new CuentaDAO(gestorAccesoDatos);
        }

        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSQL();
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