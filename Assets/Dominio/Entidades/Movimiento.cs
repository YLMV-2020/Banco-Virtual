using System;

namespace CapaDominio.Entidades
{
    public class Movimiento
    {
        private string codigo;
        private DateTime hora;
        private Moneda moneda;
        private float monto;
        private string nombreDestinatario;

        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
        public float Monto { get => monto; set => monto = value; }
        public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }


    }
}