using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientos 
{
    private int codigoDeMovimiento;
    private string tipoDeMoneda;
    private string tipoDeMovimiento;

    public Movimientos(int codigoDeMovimiento, string tipoDeMoneda, string tipoDeMovimiento)
    {
        this.codigoDeMovimiento = codigoDeMovimiento;
        this.tipoDeMoneda = tipoDeMoneda;
        this.tipoDeMovimiento = tipoDeMovimiento;
    }

    public int CodigoDeMovimiento { get => codigoDeMovimiento; set => codigoDeMovimiento = value; }
    public string TipoDeMoneda { get => tipoDeMoneda; set => tipoDeMoneda = value; }
    public string TipoDeMovimiento { get => tipoDeMovimiento; set => tipoDeMovimiento = value; }

    public void calcularNivelDeMovimiento()
    {

    }
}
