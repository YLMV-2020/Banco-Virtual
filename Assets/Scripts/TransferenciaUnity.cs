using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using CapaPersistencia.FabricaDatos;
using CapaPersistencia.ADO_SQLServer;
using CapaDominio.Contratos;
using CapaDominio.Entidades;
using UnityEngine.UI;
using CapaAplicacion.Servicios;

public class TransferenciaUnity : MonoBehaviour
{
    public InputField inputMonto;
    public InputField inputCuentaDestino;
    public Text textResultado;

    public static TransferenciaUnity sharedInstance;
    private void Awake()
    {
        sharedInstance = this;
    }

    void Start()
    {

    }
    

    string generarCodigo()
    {
        int codigo = UnityEngine.Random.Range(0, 100);
        int codigoX = UnityEngine.Random.Range(0, 1000);
        return (codigo + codigoX).ToString();
    }

    int generarCodigoDeMovimiento()
    {
        return UnityEngine.Random.Range(0, 10000);
    }

    public void guardarTransaccion()
    {
        Usuario usuario = InicioUnity.sharedInstance.user;

        Transaccion transaccion = new Transaccion();
        transaccion.Codigo = generarCodigo();
        transaccion.CodigoDeMovimiento = generarCodigoDeMovimiento();
        transaccion.Cuenta = new Cuenta();
        transaccion.Cuenta.Usuario = usuario;
        transaccion.Cuenta.Usuario.Dni = usuario.Dni;
        transaccion.Fecha = DateTime.Now;

        transaccion.Monto = float.Parse(inputMonto.text);

        RealizarTransaccionServicio transaccionServicio = new RealizarTransaccionServicio();
        transaccionServicio.guardarTransaccion(transaccion);
        StartCoroutine("Fade");


    }

    IEnumerator Fade()
    {
        textResultado.text = "Transferencia exitosa";
        yield return new WaitForSeconds(3.0f);
        textResultado.text = "";
        inputMonto.text = "";
        inputCuentaDestino.text = "";
    }


}
