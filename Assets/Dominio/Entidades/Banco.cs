using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace CapaDominio.Entidades
{
    public class Banco
    {
        private string idBanco;
        private string nombreBanco;

        private List<Usuario> listaDeUsuarios;

        public Banco(string idBanco, string nombreBanco)
        {
            listaDeUsuarios = new List<Usuario>();
            this.idBanco = idBanco;
            this.nombreBanco = nombreBanco;
        }

        public string IdBanco { get => idBanco; set => idBanco = value; }
        public string NombreBanco { get => nombreBanco; set => nombreBanco = value; }
        public List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; set => listaDeUsuarios = value; }
        public bool validarUsuario(Usuario usuario)
        {
            foreach (var user in listaDeUsuarios)
            {
                if (user == usuario)
                    return false;
            }
            return true;
        }
        public void agregarUsuario(Usuario usuario)
        {
            listaDeUsuarios.Add(usuario);
        }

        public Usuario iniciarSesion(string numeroTajeta, string dni, string clave)
        {
            foreach (var usuario in listaDeUsuarios)
            {
                if (usuario.NumeroDeTarjeta == numeroTajeta && usuario.Dni == dni && usuario.Clave == clave)
                    return usuario;
            }
            return null;
        }

    }
}
