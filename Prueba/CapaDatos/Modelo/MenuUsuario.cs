using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("MenuUsuario")]
	public class MenuUsuario
	{
		[Key]
		public int Id { get; set; }
		public int UsuarioId { get; set; }
		[ForeignKey("UsuarioId")]
		public virtual Usuarios usuario { get; set; }
		public int MenuId { get; set; }
		[ForeignKey("MenuId")]
		public virtual Menu menu { get; set; }
		public bool Estado { get; set; }
	}
}
