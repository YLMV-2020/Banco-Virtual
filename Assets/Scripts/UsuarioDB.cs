using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class UsuarioDB : MonoBehaviour
{
    string rutaDB;
    string conexion;

    IDbConnection conexionDB;
    IDbCommand comandosDB;
    IDataReader leerDatos;

    string nombreDB = "BancoVirtualDB.db";

    void Start()
    {
        //insertarUsuario("Mario", "Chumpitazi", "79194222", "4562554576547145", "111202");
        //borrarUsuario(3);
        obtenerUsuarios();
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

    void insertarUsuario(string nombres, string apellidos, string dni, string numeroTarjeta, string clave)
    {
        abrirDB();
        comandosDB = conexionDB.CreateCommand();
        string sqlQuery = String.Format("insert into Usuario(nombres, apellidos, dni, numeroTarjeta, clave) values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", nombres, apellidos, dni, numeroTarjeta, clave); ;
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
