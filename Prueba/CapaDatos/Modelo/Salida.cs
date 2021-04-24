using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Salida")]
	public class Salida
	{
		[Key]
		public int Id { get; set; }
		public int Codigo { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string Comentario { get; set; }
		public string ComentarioTicket { get; set; }
		public int? ClienteId { get; set; }
		[ForeignKey("ClienteId")]
		public Usuarios cliente { get; set; }
		public int EstadoId { get; set; }
		[ForeignKey("EstadoId")]
		public EstadoSalida estado { get; set; }
		public int UsuarioId { get; set; }
	}
}
