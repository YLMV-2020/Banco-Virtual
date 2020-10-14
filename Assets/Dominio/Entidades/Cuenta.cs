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
        private string numeroInterbancario;
        private float saldo;
        private Moneda moneda;
        private bool estado;
        private List<Transaccion> listaDeTransacciones;

        public Cuenta() { }

        public Cuenta(string numero, string numeroInterbancario, float saldo, Moneda moneda)
        {
            this.numero = numero;
            this.numeroInterbancario = numeroInterbancario;
            this.saldo = saldo;
            this.Moneda = moneda;
            this.estado = true;
            this.listaDeTransacciones = new List<Transaccion>();
        }

        public string Numero { get => numero; set => numero = value; }
        public string NumeroInterbancario { get => numeroInterbancario; set => numeroInterbancario = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
        public List<Transaccion> ListaDeTransacciones { get => listaDeTransacciones; set => listaDeTransacciones = value; }

        virtual public float calcularComision()
        {
            float comision = 0.0f;
            foreach (var transaccion in listaDeTransacciones)
            {
                comision += transaccion.calcularComision();
            }
            return comision;
        }
    }
}