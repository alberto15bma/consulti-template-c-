using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	class ClsConexionBD
	{
		public string Conexion()
		{
			return "Data Source=192.168.100.9;Initial Catalog=PRUEBAPRACTICA;User ID=sa;Password=12345678";

		}
	}
}
