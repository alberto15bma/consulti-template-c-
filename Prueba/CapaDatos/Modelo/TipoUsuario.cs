using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("TipoUsuario")]
	public class TipoUsuario
	{
		[Key]
		public int Id { get; set; }
		[StringLength(40)]
		public string Descripcion { get; set; }
		public virtual List<Usuarios> Usuarios { get; set; }
	}
}
