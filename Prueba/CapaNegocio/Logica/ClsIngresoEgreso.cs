using CapaDatos.Modelo;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	public class ClsIngresoEgreso
	{
		public static List<Conceptos> GetConceptos()
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Conceptos.OrderBy(a => a.Descripcion).ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public  List<ListaIngresoEgreso> GetListaEquipos()
		{
			var lista = new List<ListaIngresoEgreso>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select e.Id, e.Codigo, e.CodigoBarras, e.StockMax, e.StockMin, e.Descripcion, 
									ee.Descripcion as Estado, m.EstadoId, m.Stock  from Producto e 
									left join Movimiento m on (m.ProductoId = e.Id)
									left join Estado ee on (ee.Id = m.EstadoId)";

						lista = db.Query<ListaIngresoEgreso>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
						db.Close();
						return lista;
					}
				}
				catch (Exception e)
				{
					return lista;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
			return lista;
		}
	}
}
public class ListaIngresoEgreso
{
	public int Id { get; set; }
	public string IdCompuesto {
		get { return  $"{Id}, {Codigo}, {EstadoId}"; }
	}
	public int Codigo { get; set; }
	public string CodigoEquipo
	{
		get { return Codigo.ToString("000000"); }
	}
	public string CodigoBarras { get; set; }
	public string Descripcion { get; set; }
	public int StockMin { get; set; }
	public int StockMax { get; set; }
	public int Stock { get; set; }
	public string Estado { get; set; }
	public int EstadoId { get; set; }
}
public class DetalleIngresoEgreso
{
	public int Id { get; set; }
	public int IdEquipo { get; set; }
	public int Codigo { get; set; }
	public string CodigoEquipo { get; set; }
	public string Descripcion { get; set; }
	public int Cantidad { get; set; }
	public string NombreEstado { get; set; }
	public int Estado { get; set; }
	public double Costo { get; set; }
	public int Stock { get; set; }
}