using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IUsuario
    {
        Usuario buscarPorNumeroUsuario(string numero);
    }
}
