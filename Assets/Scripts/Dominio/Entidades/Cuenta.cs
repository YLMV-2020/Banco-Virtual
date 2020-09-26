using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuenta 
{
    private int clave;
    private bool estadoDeCuenta;
    private float montoActual;
    private string numeroDeCuenta;
    private string tipoDeMoneda;

    public int Clave { get => clave; set => clave = value; }
    public bool EstadoDeCuenta { get => estadoDeCuenta; set => estadoDeCuenta = value; }
    public float MontoActual { get => montoActual; set => montoActual = value; }
    public string NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
    public string TipoDeMoneda { get => tipoDeMoneda; set => tipoDeMoneda = value; }

    public bool validarClave()
    {
        return true;
    }

    public bool validarCuenta()
    {
        return true;
    }
}
