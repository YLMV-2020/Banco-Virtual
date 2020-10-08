namespace CapaDominio.Contratos
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
