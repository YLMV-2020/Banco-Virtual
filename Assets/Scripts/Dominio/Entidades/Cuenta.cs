using System.Collections;
using System.Collections.Generic;

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
   
    public Cuenta() { }

    public Cuenta(string numero, string numeroInterbancario, float saldo, Moneda moneda)
    {
        this.numero = numero;
        this.numeroInterbancario = numeroInterbancario;
        this.saldo = saldo;
        this.Moneda = moneda;
        this.estado = true;
    }

    public string Numero { get => numero; set => numero = value; }
    public string NumeroInterbancario { get => numeroInterbancario; set => numeroInterbancario = value; }
    public float Saldo { get => saldo; set => saldo = value; }
    public bool Estado { get => estado; set => estado = value; }
    public Moneda Moneda { get => moneda; set => moneda = value; }
    virtual public float calcularComision() 
    {
        return 0.0f;
    }
}
