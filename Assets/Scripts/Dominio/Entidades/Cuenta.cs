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
    private Usuario usuario;
   
    public Cuenta() { }
    public Cuenta(int clave, bool estadoDeCuenta, float montoActual, string numeroDeCuenta, string tipoDeMoneda)
    {
        this.clave = clave;
        this.estadoDeCuenta = estadoDeCuenta;
        this.montoActual = montoActual;
        this.numeroDeCuenta = numeroDeCuenta;
        this.tipoDeMoneda = tipoDeMoneda;
    }

    public int Clave { get => clave; set => clave = value; }
    public bool EstadoDeCuenta { get => estadoDeCuenta; set => estadoDeCuenta = value; }
    public float MontoActual { get => montoActual; set => montoActual = value; }
    public string NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
    public string TipoDeMoneda { get => tipoDeMoneda; set => tipoDeMoneda = value; }
    public Usuario Usuario { get => usuario; set => usuario = value; }

    public bool validarClave()
    {
        return true;
    }

    // validamos que un usuario tenga más de 1 cuenta
    //public bool validarCuenta()
    //{
    //    for (int i = 0; i < listaDeCuentas.Count; i++)
    //    {
    //        for (int j = 0; j < listaDeCuentas.Count; j++)
    //        {
    //            if (listaDeCuentas[i] == listaDeCuentas[j])
    //                return false;
    //        }
    //    }
    //    return true;
    //}
}
