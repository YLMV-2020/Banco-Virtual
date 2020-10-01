using System.Collections;
using System.Collections.Generic;

public class Usuario
{
    private string nombres;
    private string apellidos;
    private string dni;
    private string numeroDeTarjeta;
    private string clave;
    private bool estado;

    private List<Cuenta> listaDeCuentas;

    public Usuario() { }

    public Usuario(string nombres, string apellidos, string dni, string numeroDeTarjeta, string clave, bool estado)
    {
        listaDeCuentas = new List<Cuenta>();
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.dni = dni;
        this.numeroDeTarjeta = numeroDeTarjeta;
        this.clave = clave;
        this.estado = estado;
    }

    public string Nombres { get => nombres; set => nombres = value; }
    public string Apellidos { get => apellidos; set => apellidos = value; }
    public string Dni { get => dni; set => dni = value; }
    public string NumeroDeTarjeta { get => numeroDeTarjeta; set => numeroDeTarjeta = value; }
    public string Clave { get => clave; set => clave = value; }
    public bool Estado { get => estado; set => estado = value; }
    public List<Cuenta> ListaDeCuentas { get => listaDeCuentas; set => listaDeCuentas = value; }

    public double calcularComisionUsuario()
    {
        return 0.0f;
    }

    public double calcularComisionCuentas()
    {
        return 0.0f;
    }

}
