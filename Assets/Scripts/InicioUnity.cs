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

    public Usuario user = null;

    public void iniciarSesion()
    {
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
                break;
            }
        }

    }

    
}
