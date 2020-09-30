using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaccion
{
    private DateTime fechaTransaccion;
    private float montoDeTransferencia;
    private string numeroDeTransacciones;
    private int valoracion;
    private Usuario usuario;
    private List<Movimientos> listaDeMovimientos;

    public Transaccion(DateTime fechaTransaccion, float montoDeTransferencia, string numeroDeTransacciones, int valoracion, Usuario usuario)
    {
        this.fechaTransaccion = fechaTransaccion;
        this.montoDeTransferencia = montoDeTransferencia;
        this.numeroDeTransacciones = numeroDeTransacciones;
        this.valoracion = valoracion;
        this.usuario = usuario;
    }

    public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
    public float MontoDeTransferencia { get => montoDeTransferencia; set => montoDeTransferencia = value; }
    public string NumeroDeTransacciones { get => numeroDeTransacciones; set => numeroDeTransacciones = value; }
    public int Valoracion { get => valoracion; set => valoracion = value; }
    public Usuario Usuario { get => usuario; set => usuario = value; }
    public List<Movimientos> ListaDeMovimientos { get => listaDeMovimientos; set => listaDeMovimientos = value; }

    public void calcularCambioDeMoneda()
    {

    }

    public double calcularComision()
    {
        return 0.0f;
    }

    public double calcularMontoTotalDeMovimientos()
    {
        return 0.0f;
    }
    
    public double calcularTotal()
    {
        return 0.0f;
    }
    
    public double calcularTotalGeneral()
    {
        return 0.0f;
    }
    public double calcularValorizacion()
    {
        return 0.0f;
    }
    public double totalDeMovimientoEnDolares()
    {
        return 0.0f;
    }
    public double totalDeMovimientoEnSoles()
    {
        return 0.0f;
    }



}
