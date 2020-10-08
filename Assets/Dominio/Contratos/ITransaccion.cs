using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IVenta
    {
        void guardarTrasaccion(Transaccion transaccion);
    }
}
