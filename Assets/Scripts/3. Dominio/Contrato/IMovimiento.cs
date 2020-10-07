using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public CapaDominio.Contratos
{
	public interface IMovimiento
	{
		List<Movimiento> buscarMovimiento(string codigo);
	}
}
