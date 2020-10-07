using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public CapaDominio.Contratos
{
	public interface IUsuario()
	{
		Usuario buscarPorNumeroUsuario(string numero);
	}
}
