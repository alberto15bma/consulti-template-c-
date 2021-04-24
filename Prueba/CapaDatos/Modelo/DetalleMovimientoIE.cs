using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("DetalleMovimientoIE")]
	public class DetalleMovimientoIE
	{
		[Key]
		public int Id { get; set; }
		public int MovimientoIEid { get; set; }
		[ForeignKey("MovimientoIEid")]
		public MovimientoIE movimientoIE { get; set; }
		public int ProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public Producto producto { get; set; }
	
		public int EstadoId { get; set; }
		[ForeignKey("EstadoId")]
		public Estado estado { get; set; }
		public int Cantidad { get; set; }
	}
}
