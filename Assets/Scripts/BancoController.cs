using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using CapaDominio.Entidades;

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

        usuario.Nombres = inputNombres.text;
        usuario.Apellidos = inputApellidos.text;

        myBanco.agregarUsuario(usuario);

        List<Usuario> listaDeUsuarios = myBanco.ListaDeUsuarios;

        Debug.Log("Nombre: " + listaDeUsuarios[0].Nombres);
        Debug.Log("Apellidos: " + listaDeUsuarios[0].Apellidos);


    }
}
