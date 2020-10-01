using System;
using System.Collections;
using System.Collections.Generic;

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

    public float calcularComision()
    {
        float comision = 0.0f;
        comision += tipo == TipoTransaccion.CUENTA_PROPIA ? 0.5f : 0.0f;
        comision += tipo == TipoTransaccion.OTRA_CUENTA ? monto * 015f : 0.0f;
        return comision;
    }
    public float calcularMontoTotal()
    {
        return monto + calcularComision();
    }

    public bool validarValoracion()
    {
        return valoracion >= 1 && valoracion <= 5;
    }

}
