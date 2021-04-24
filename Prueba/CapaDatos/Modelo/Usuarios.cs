using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Usuarios")]
	public class Usuarios
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(13)]
		public string Cedula { get; set; }
		[StringLength(100)]
		public string Apellidos { get; set; }
		[StringLength(100)]
		public string Nombres { get; set; }
		[StringLength(20)]
		public string Usuario { get; set; }
		//[StringLength(30)]
		public string Password { get; set; }
		public DateTime FechaIngreso { get; set; }
		public DateTime FechaModificacion { get; set; }
		[StringLength(10)]
		public string Celular { get; set; }
		[StringLength(50)]
		public string Email { get; set; }
		public bool Estado { get; set; }
		public int TipoUsuarioId { get; set; }
		[ForeignKey("TipoUsuarioId")]
		public TipoUsuario tipoUsuario { get; set; }
		public int? PerfilId { get; set; }
		[ForeignKey("PerfilId")]
		public Perfil perfil { get; set; }
		public bool Notificacion { get; set; }
		public bool InicioSesion { get; set; }
		public string RazonSocial { get; set; }
		public string Direccion { get; set; }
	}
}
