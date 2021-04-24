using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Producto")]
	public class Producto
	{
		[Key]
		public int Id { get; set; }
		public int Codigo { get; set; }
		public string CodigoBarras { get; set; }
		public string Descripcion { get; set; }
		public int? UbicacionId { get; set; }
		[ForeignKey("UbicacionId")]
		public Ubicacion ubicacion { get; set; }
		public bool Estado { get; set; }
		[ScaffoldColumn(true)]
		[UIHint("Image")]
		public byte[] Foto { get; set; }
		public int StockMin { get; set; }
		public int StockMax { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaModificacion { get; set; }
	}
}
