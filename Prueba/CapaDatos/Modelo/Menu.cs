using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Menu")]
	public class Menu
	{
		[Key]
		public int Id { get; set; }
		public int ParentId { get; set; }
		public int Nivel { get; set; }
		public string Descripcion { get; set; }
		[StringLength(50)]
		public string Nombre { get; set; }
		[StringLength(200)]
		public string Accion { get; set; }
	
	}
}
