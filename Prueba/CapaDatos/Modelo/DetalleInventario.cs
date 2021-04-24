using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("DetalleInventario")]
	public class DetalleInventario
	{
		[Key]
		public int Id { get; set; }
		public int InventarioId { get; set; }
		[ForeignKey("InventarioId")]
		public Inventario inventario { get; set; }
		public int ProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public Producto producto { get; set; }
		public int EstadoId { get; set; }
		[ForeignKey("EstadoId")]
		public Estado estado { get; set; }
		public int Cantidad { get; set; }
		public int StockActual { get; set; }
	}
}
