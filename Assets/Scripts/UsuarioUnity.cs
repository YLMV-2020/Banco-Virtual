using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CapaPersistencia.FabricaDatos;
using CapaPersistencia.ADO_SQLServer;
using CapaDominio.Contratos;
using CapaDominio.Entidades;

public class UsuarioUnity : MonoBehaviour
{
    public GameObject cuentaPrefab;
    public Transform cuentaPadre;

    public static UsuarioUnity sharedInstance;

    public List<Cuenta> listaDeCuentas;

    private void Start()
    {
        mostrarCuentas();
    }

    private void Awake()
    {
        sharedInstance = this;
    }

    void mostrarCuentas()
    {

        FabricaSQLServer fabrica = new FabricaSQLServer();
        IGestorAccesoDatos gestorSQL = fabrica.crearGestorAccesoDatos();
        CuentaDAO cuentaDAO = (CuentaDAO)fabrica.crearCuentaDAO(gestorSQL);

        gestorSQL.abrirConexion();
        listaDeCuentas = cuentaDAO.obtenerListaDeCuentas();

        gestorSQL.cerrarConexion();

        for (int i = 0; i < listaDeCuentas.Count; i++)
        {
            GameObject tempPrefab = Instantiate(cuentaPrefab);
            tempPrefab.transform.SetParent(cuentaPadre);
            tempPrefab.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Cuenta cuentaTemp = listaDeCuentas[i];

            tempPrefab.GetComponent<CuentaScript>().AgregarCuenta(

                cuentaTemp.Numero,
                cuentaTemp.Saldo,
                cuentaTemp.Moneda == Moneda.SOL ? "SOL" : "DOLAR"
            );

        }
    }

}
