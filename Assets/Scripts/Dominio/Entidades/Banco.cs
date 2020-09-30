using System.Collections;
using System.Collections.Generic;
using System.Data;

public class Banco
{
    private string idBanco;
    private string nombreBanco;

    private List<Cuenta> listaDeCuentas;

    public Banco(string idBanco, string nombreBanco)
    {
        this.idBanco = idBanco;
        this.nombreBanco = nombreBanco;
    }

    public string IdBanco { get => idBanco; set => idBanco = value; }
    public string NombreBanco { get => nombreBanco; set => nombreBanco = value; }
    public List<Cuenta> ListaDeCuentas { get => listaDeCuentas; set => listaDeCuentas = value; }

    public void agregarCuenta(Cuenta cuenta)
    {
        ListaDeCuentas.Add(cuenta);
    }

    // validamos que un usuario no tenga más de 1 cuenta
    public bool validarCuenta()
    {
        //for (int i = 0; i < listaDeCuentas.Count; i++) 
        //{
        //    for (int j = 0; j < listaDeCuentas.Count; j++)
        //    {
        //        if (listaDeCuentas[i] == listaDeCuentas[j])
        //            return false;
        //    }
        //}
        return true;
    }

    //public void 
}
