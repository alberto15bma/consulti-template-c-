using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	public class OperacionResult
	{
		public int success { get; set; }
		public string ErrorMensaje { get; set; }
		public string InnerException { get; set; }
		public string InformacionAdicional { get; set; }
	}
	public class Registro
	{
		public int Id { get; set; }
		public string tipo { get; set; }
	}
}
