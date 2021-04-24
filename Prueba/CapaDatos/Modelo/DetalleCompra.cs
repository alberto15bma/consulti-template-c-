using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("DetalleCompra")]
	public class DetalleCompra
	{
		[Key]
		public int Id { get; set; }
		public int CompraId { get; set; }
		[ForeignKey("CompraId")]
		public Compras compra { get; set; }
		public int ProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public Producto producto { get; set; }
		public int Cantidad { get; set; }
		public double Costo { get; set; }
		public bool Estado { get; set; }
	}
}
