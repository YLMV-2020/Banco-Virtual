using System.Collections;
using System.Collections.Generic;

public class Usuario 
{
    private string apellidoUsuario;
    private string dni;
    private bool estadoUsuario;
    private string nombreUsuario;
    private string nombeDeCuenta;
    private string nombeDeTarjeta;
    private int tipoDeUsuario;
    private List<Cuenta> listaDeCuentas;

    public Usuario() { }
    public Usuario(string apellidoUsuario, string dni, bool estadoUsuario, string nombreUsuario, string nombeDeCuenta, string nombeDeTarjeta, int tipoDeUsuario)
    {
        this.apellidoUsuario = apellidoUsuario;
        this.dni = dni;
        this.estadoUsuario = estadoUsuario;
        this.nombreUsuario = nombreUsuario;
        this.nombeDeCuenta = nombeDeCuenta;
        this.nombeDeTarjeta = nombeDeTarjeta;
        this.tipoDeUsuario = tipoDeUsuario;
    }

    public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
    public string Dni { get => dni; set => dni = value; }
    public bool EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string NombeDeCuenta { get => nombeDeCuenta; set => nombeDeCuenta = value; }
    public string NombeDeTarjeta { get => nombeDeTarjeta; set => nombeDeTarjeta = value; }
    public int TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
    public List<Cuenta> ListaDeCuentas { get => listaDeCuentas; set => listaDeCuentas = value; }

    public double agregarComisionCuentasPropias()
    {
        return 0.0f;
    }

    public double agregarComisionCuentaUsuario()
    {
        return 0.0f;
    }

}
