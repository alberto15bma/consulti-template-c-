using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Inventario")]
	public class Inventario
	{
		[Key]
		public int Id { get; set; }
		public int Codigo { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string Observacion { get; set; }
		public int ConceptoId { get; set; }
		[ForeignKey("ConceptoId")]
		public Conceptos concepto { get; set; }
		public int UsuarioId { get; set; }
		[ForeignKey("UsuarioId")]
		public Usuarios usuario { get; set; }
		public int EstadoId { get; set; }
		[ForeignKey("EstadoId")]
		public EstadoSalida estado { get; set; }
	}
}
