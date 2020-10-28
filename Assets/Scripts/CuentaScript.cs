using CapaDominio.Entidades;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaScript : MonoBehaviour
{
    public GameObject numeroDeCuenta;
    public GameObject tipoDeMoneda;
    public GameObject saldo;

    public void AgregarCuenta(string numero, float saldo, string moneda)
    {
        this.numeroDeCuenta.GetComponent<Text>().text = numero;
        this.saldo.GetComponent<Text>().text = saldo.ToString();
        this.tipoDeMoneda.GetComponent<Text>().text = moneda;
    }
   
}
