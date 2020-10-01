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
    private double monto;
    private TipoTransaccion tipo;
    private int valoracion;

    public string Codigo { get => codigo; set => codigo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public double Monto { get => monto; set => monto = value; }
    public TipoTransaccion Tipo { get => tipo; set => tipo = value; }
    public int Valoracion { get => valoracion; set => valoracion = value; }

    public float calcularComision()
    {
        return 0.0f;
    }
    public float calcularMontoTotal()
    {
        return 0.0f;
    }

}
