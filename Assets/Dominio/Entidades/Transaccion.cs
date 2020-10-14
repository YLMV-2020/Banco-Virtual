using System;

namespace CapaDominio.Entidades
{
    public enum TipoTransaccion
    {
        OTRA_CUENTA,
        OTRO_BANCO,
        CUENTA_PROPIA,
        EXTERIOR
    }

    public class Transaccion
    {
        private string codigo;
        private DateTime fecha;
        private float monto;
        private TipoTransaccion tipo;
        private int valoracion;
        private Cuenta cuenta;

        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Monto { get => monto; set => monto = value; }
        public TipoTransaccion Tipo { get => tipo; set => tipo = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public Cuenta Cuenta { get => cuenta; set => cuenta = value; }

        public bool validarMonto()
        {
            return monto <= cuenta.Saldo;
        }

        public float calcularComision(TipoTransaccion a, float montoaux)
        {
            float comision = 0.0f;
            if (a == TipoTransaccion.CUENTA_PROPIA)
                comision = 0.5f;

            else
                comision = montoaux * 0.15f;

            return comision;
        }

        public bool validarMonto(float monto1, float cuenta1)
        {
            return monto1 <= cuenta1;
        }

        public float calcularMontoTotal(TipoTransaccion a, float montoaux)
        {
            monto = montoaux;
            return monto + calcularComision(a, montoaux);
        }

        public bool validarValoracion()
        {
            return valoracion >= 1 && valoracion <= 5;
        }

        public float calcularTransferencia(float monto, string tipomoneda1)
        {

            if (tipomoneda1.Equals("DOLAR"))
            {
                monto *= 3.45f;
            }

            return monto;
        }

        public bool verificarCodigo(string codigoaux, string codigoaux2)
        {
            codigo = codigoaux2;
            return (codigo == codigoaux);

        }

    }
}