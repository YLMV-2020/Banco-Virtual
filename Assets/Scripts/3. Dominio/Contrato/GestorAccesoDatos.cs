using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public CapaDominio.Contratos
{
	public interface IGestorAccesoDatos
	{
        void abrirConexion();
        void cerrarConexion();
        void iniciarTransaccion();
        void terminarTransaccion();
        void cancelarTransaccion();
    }
}
