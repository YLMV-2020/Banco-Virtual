using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaPersistencia.ADO_SQLServer;
using CapaPersistencia.FabricaDatos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioUnity : MonoBehaviour
{
    public static InicioUnity sharedInstance;
    private void Awake()
    {
        sharedInstance = this;
    }

    public InputField inputNumeroTarjeta;
    public InputField inputDNI;
    public InputField inputClave;
    public Text textResultado;

    public Usuario user = null;

    public void iniciarSesion()
    {
        bool encontrado = false;
        FabricaSQLServer fabrica = new FabricaSQLServer();
        IGestorAccesoDatos gestorSQL = fabrica.crearGestorAccesoDatos();
        UsuarioDAO usuarioDAO = (UsuarioDAO)fabrica.crearUsuarioDAO(gestorSQL);

        gestorSQL.abrirConexion();
        List<Usuario> listaDeUsuarios = usuarioDAO.obtenerListaDeUsuarios();
        gestorSQL.cerrarConexion();

        foreach(var usuario in listaDeUsuarios)
        {
            if (usuario.Clave == inputClave.text && usuario.Dni == inputDNI.text && usuario.NumeroDeTarjeta == inputNumeroTarjeta.text)
            {
                Debug.Log("Usuario Encontrado: " + usuario.Nombres);
                user = usuario;
                encontrado = true;
                break;
            }
        }

        if(!encontrado)
        {
            StartCoroutine("Fade");
        }
        else
        {
            SceneManagerScript.sharedInstance.cambioEscena("Transferencia");
        }

    }

    IEnumerator Fade()
    {
        textResultado.text = "Usuario no registrado";
        yield return new WaitForSeconds(3.0f);
        textResultado.text = "";
        inputNumeroTarjeta.text = "";
        inputDNI.text = "";
        inputClave.text = "";
    }


}
