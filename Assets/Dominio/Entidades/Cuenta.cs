using System.Collections.Generic;

namespace CapaDominio.Entidades
{
    public enum Moneda
    {
        SOL,
        DOLAR
    }

    public class Cuenta
    {
        private string numero;
        private float saldo;
        private Moneda moneda;
        private bool estado;
        private List<Transaccion> listaDeTransacciones;
        private Usuario usuario;

        public Cuenta() { }

        public Cuenta(string numero, float saldo, Moneda moneda, Usuario usuario)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.moneda = moneda;
            this.estado = true;
            this.usuario = usuario;
            this.listaDeTransacciones = new List<Transaccion>();
        }

        public string Numero { get => numero; set => numero = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
        public List<Transaccion> ListaDeTransacciones { get => listaDeTransacciones; set => listaDeTransacciones = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        virtual public float calcularComision()
        {
            float comision = 0.0f;
            foreach (var transaccion in listaDeTransacciones)
            {
                //comision += transaccion.calcularComision();
            }
            return comision;
        }
    }
}