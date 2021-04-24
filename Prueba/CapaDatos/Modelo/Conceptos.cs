using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Conceptos")]
	public class Conceptos
	{
		[Key]
		public int Id { get; set; }
		public string Descripcion { get; set; }
		public string Tipo { get; set; }
		public bool Inventario { get; set; }
	}
}
