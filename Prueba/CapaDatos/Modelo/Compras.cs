using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Compras")]
	public class Compras
	{
		[Key]
		public int Id { get; set; }
		public DateTime FechaFactura { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime FechaModificacion { get; set; }
		public int Codigo { get; set; }
		public int ProveedorId { get; set; }
		[ForeignKey("ProveedorId")]
		public Usuarios proveedor { get; set; }
		public string Factura { get; set; }
		public string Observacion { get; set; }
		public int EstadoId { get; set; }
		[ForeignKey("EstadoId")]
		public EstadoMovimiento estado { get; set; }
		public int? UsuarioId { get; set; }
		[ForeignKey("UsuarioId")]
		public Usuarios usuario { get; set; }
	}
}
