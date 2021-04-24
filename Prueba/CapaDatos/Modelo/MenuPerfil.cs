using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("MenuPerfil")]
	public class MenuPerfil
	{
		[Key]
		public int Id { get; set; }
		public int PerfilId { get; set; }
		[ForeignKey("PerfilId")]
		public Perfil perfil { get; set; }
		public int MenuId { get; set; }
		[ForeignKey("MenuId")]
		public Menu menu { get; set; }
		public bool Estado { get; set; }
	}
}
