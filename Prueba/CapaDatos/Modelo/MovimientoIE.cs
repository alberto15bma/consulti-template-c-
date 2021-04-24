using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("MovimientoIE")]
	public class MovimientoIE
	{
		[Key]
		public int Id { get; set; }
		public int Codigo { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string Observacion { get; set; }
		public string Tipo { get; set; }
		public int ConceptoId { get; set; }
		[ForeignKey("ConceptoId")]
		public Conceptos concepto { get; set; }
		public int? UsuarioId { get; set; }
		[ForeignKey("UsuarioId")]
		public Usuarios usuario { get; set; }
	}
}
