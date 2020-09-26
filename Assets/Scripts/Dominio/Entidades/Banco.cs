using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco 
{
    private string idBanco;
    private string nombreBanco;

    private List<Cuenta> listaDeCuentas;

    public string IdBanco { get => idBanco; set => idBanco = value; }
    public string NombreBanco { get => nombreBanco; set => nombreBanco = value; }

    public bool validarUsuario()
    {
        return true;
    }
}
