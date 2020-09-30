using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BancoController : MonoBehaviour
{

    [SerializeField] Button buttonRegistrarCuenta;
    [SerializeField] InputField inputNombres;
    [SerializeField] InputField inputApellidos;
    [SerializeField] InputField inputDNI;
    [SerializeField] InputField inputClave;

    private Banco myBanco;

    void Start()
    {
        myBanco = new Banco("N00113540", "Banco ChumpiBrazzer");
    }

    void Update()
    {
        
    }

    public void crearCuenta()
    {
        Usuario usuario = new Usuario();

        usuario.NombreUsuario = inputNombres.text;
        usuario.ApellidoUsuario = inputApellidos.text;

        Debug.Log("Nombre: " + usuario.NombreUsuario);
        Debug.Log("Apellidos: " + usuario.ApellidoUsuario);

        Cuenta cuenta = new Cuenta();

        cuenta.Usuario = usuario;

        //myBanco.agregarCuenta(cuenta);

        //List<Cuenta> listaDeCuentas = myBanco.ListaDeCuentas;

        //Debug.Log("Nombre: " + listaDeCuentas[0].Usuario.NombreUsuario);
        //Debug.Log("Apellidos: " + listaDeCuentas[0].Usuario.ApellidoUsuario);

    }
}
