using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CapaDominio.Entidades;

public class GameManager : MonoBehaviour
{
    public Text nombre;

    private Banco myBanco;

    void Start()
    {
        myBanco = new Banco("N00113540", "Banca Virtual");
        nombre.text = myBanco.NombreBanco;
    }

    void Update()
    {

    }

    public void crearCuenta()
    {
      

    }
}
