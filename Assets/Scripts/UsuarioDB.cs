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
using UnityEngine.TestTools;

public class UsuarioDB : MonoBehaviour
{
    string rutaDB;
    string conexion;

    public GameObject cuentaPrefab;
    public Transform cuentaPadre;

    IDbConnection conexionDB;
    IDbCommand comandosDB;
    IDataReader leerDatos;

    string nombreDB = "BancoDB.db";
    
    void Start()
    {
        mostrarCuentas();
        //obtenerUsuarios();
        //comprobar();
    }

    void comprobar()
    {
        FabricaSQLServer fabrica = new FabricaSQLServer();
        IGestorAccesoDatos gestorSQL = fabrica.crearGestorAccesoDatos();
        UsuarioDAO usuarioDAO = (UsuarioDAO)fabrica.crearUsuarioDAO(gestorSQL);
        gestorSQL.abrirConexion();

        Usuario nuevo = new Usuario("Leonidjas", "Vargafss", "12345678", "987654321", "fxxx");

        usuarioDAO.guardarUsuario(nuevo);

        gestorSQL.cerrarConexion();

    }

    void mostrarCuentas()
    {

        FabricaSQLServer fabrica = new FabricaSQLServer();
        IGestorAccesoDatos gestorSQL = fabrica.crearGestorAccesoDatos();
        CuentaDAO cuentaDAO = (CuentaDAO)fabrica.crearCuentaDAO(gestorSQL);

        gestorSQL.abrirConexion();
        List<Cuenta> listaDeCuentas = cuentaDAO.obtenerListaDeCuentas();

        Debug.Log("Numeor de cuentas: " + listaDeCuentas.Count);

        gestorSQL.cerrarConexion();


        for (int i = 0; i < listaDeCuentas.Count; i++) 
        {
            Debug.Log("S");
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

    void abrirDB()
    {
        rutaDB = Application.dataPath + "/StreamingAssets/" + nombreDB;
        conexion = "URI=file:" + rutaDB;
        conexionDB = new SqliteConnection(conexion);
        conexionDB.Open();
    }

    void obtenerUsuarios()
    {
        abrirDB();
        comandosDB = conexionDB.CreateCommand();
        string sqlQuery = "select * from Usuario";
        comandosDB.CommandText = sqlQuery;

        leerDatos = comandosDB.ExecuteReader();
        while(leerDatos.Read())
        {
            int id = leerDatos.GetInt32(0);
            Debug.Log("Id: " + id);
            string name = leerDatos.GetString(1);
            Debug.Log("Name: " + name);
        }
        leerDatos.Close();
        leerDatos = null;
        cerrarDB();
    }

   

    void obtenerCuentas()
    {
        abrirDB();
        comandosDB = conexionDB.CreateCommand();
        string sqlQuery = "select * from Cuenta";
        comandosDB.CommandText = sqlQuery;

        leerDatos = comandosDB.ExecuteReader();
        while (leerDatos.Read())
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Numero = leerDatos.GetString(0);
            cuenta.Saldo = leerDatos.GetFloat(1);

            Debug.Log("Cuenta: " + cuenta.Numero);

            string tipoMoneda = leerDatos.GetString(2);

            if (tipoMoneda == "Sol")
                cuenta.Moneda = Moneda.SOL;
            else
                cuenta.Moneda = Moneda.DOLAR;

            //listaDeCuentas.Add(cuenta);

        }
        leerDatos.Close();
        leerDatos = null;
        cerrarDB();
    }

    void insertarUsuario(string nombres, string apellidos, string dni, string numeroTarjeta, string clave)
    {
        abrirDB();
        comandosDB = conexionDB.CreateCommand();
        string sqlQuery = String.Format("insert into Usuario(nombres, apellidos, dni, numeroTarjeta, clave) values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", nombres, apellidos, dni, numeroTarjeta, clave);
        comandosDB.CommandText = sqlQuery;
        comandosDB.ExecuteScalar();

        cerrarDB();
    }

    void borrarUsuario(int id)
    {
        abrirDB();
        comandosDB = conexionDB.CreateCommand();
        string sqlQuery = "delete from Usuario where id = \"" + id + "\"";
        comandosDB.CommandText = sqlQuery;
        comandosDB.ExecuteScalar();

        cerrarDB();
    }

    void cerrarDB()
    {
        comandosDB.Dispose();
        comandosDB = null;
        conexionDB.Close();
        conexionDB = null;
    }
}
