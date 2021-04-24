using CapaDatos.Modelo;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	public class ClsCompras
	{
		public List<ListaCompras> GetCompras()
		{
			var lista = new List<ListaCompras>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select c.Id, c.FechaFactura, c.Codigo, CONCAT(u.Apellidos, ' ', u.Nombres, ' (', u.RazonSocial,')') as Proveedor, 
									e.Descripcion as Estado, c.EstadoId, c.Observacion, c.Factura, count(dc.Id) as TotalItem from Compras c
									inner join Usuarios u on (u.Id = c.ProveedorId)
									inner join EstadoMovimiento e on (e.Id = c.EstadoId)
									inner join DetalleCompra dc on (dc.CompraId = c.Id)
									group by c.Id, c.FechaFactura, c.Codigo, CONCAT(u.Apellidos, ' ', u.Nombres, ' (', u.RazonSocial,')'), 
									e.Descripcion, c.EstadoId, c.Observacion, c.Factura";

						lista = db.Query<ListaCompras>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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
		public List<ListaDetalleCompras> GetDetalleCompra(int idCompra)
		{
			var lista = new List<ListaDetalleCompras>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select dc.Id, dc.ProductoId as IdEquipo, e.Codigo, e.Descripcion, dc.Cantidad,
									dc.Costo from Compras c
									inner join DetalleCompra dc on (dc.CompraId = c.Id) 
									inner join Producto e on (e.Id = dc.ProductoId)" +
									$" where c.Id = {idCompra}";

						lista = db.Query<ListaDetalleCompras>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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

		public void CrearCompra(ref OperacionResult result, CapaDatos.Modelo.Compras compra, BindingList<ListaDetalleCompras> detalle)
		{
			if (ValidarExistenciaFactura(compra.Factura) == false)
			{
				using (var db = new BDContext())
				{
					try
					{
						var lista = detalle.ToList();
						if (lista.Count() > 0)
						{
							var com = new Compras();
							com = compra;
							db.Compras.Add(com);
							db.SaveChanges();
							int idCompra = com.Id;
							com = null;
						
							CrearListaDetalle(ref result, idCompra, lista);
							result.success = 1;
						}
						else
						{
							result.success = 0;
							result.ErrorMensaje = "No se pudo guardar los datos porque no ingresaste ningún registro.";
							result.InnerException = "Por favor, intenta nuevamente.";
							result.InformacionAdicional = "ClsCompras.CrearCompra()";
							return;
						}
					}
					catch (Exception e)
					{
						result.success = 0;
						result.ErrorMensaje = e.Message;
						result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
						result.InformacionAdicional = "ClsCompras.CrearCompra()";
						return;
					}
					finally
					{
						((IDisposable)db).Dispose();
					}
				}
			}
			else
			{
				result.success = 0;
				result.ErrorMensaje = "Ya se encuentra creado un registro con la misma factura.\n";
				result.InnerException = "Por favor intenta con otra factura";
				result.InformacionAdicional = "ClsCompras.CrearCompra()";
				return;
			}
		}

		private void CrearListaDetalle(ref OperacionResult result, int idCompra, List<ListaDetalleCompras> lista)
		{
			using (var db = new BDContext())
			{
				try
				{
					for (int i = 0; i < lista.Count(); i++)
					{
						var det = new DetalleCompra();
						det.CompraId = idCompra;
						det.Cantidad = lista[i].Cantidad;
						det.Costo = lista[i].Costo;
						det.ProductoId = lista[i].IdEquipo;
						det.Estado = true;					

						db.DetalleCompra.Add(det);
						db.SaveChanges();
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsCompras.CrearListaDetalle()";
					return;
				}
			}
		}

		public static bool ArchivarCompra(int id)
		{
			using (var db = new BDContext())
			{
				var com = db.Compras.FirstOrDefault(a => a.Id == id);
				if (com == null)
				{
					return false;
				}else
				{
					com.EstadoId = 3;
					com.FechaModificacion = DateTime.Now;
					db.SaveChanges();
				}
				return true;
			}
		}

		public bool ValidarExistenciaFactura(string factura)
		{
			using (var db = new BDContext())
			{
				var empleado = db.Compras.FirstOrDefault(a => a.Factura == factura);
				if (empleado == null)
				{
					return false;
				}
				return true;
			}
		}
		public static int GetSecuencial()
		{
			using (var db = new BDContext())
			{
				try
				{
					var data = db.Compras.FirstOrDefault();
					if (data != null)
					{
						return db.Compras.Max(a => a.Codigo) + 1;
					}
					else
					{
						return 1;
					}

				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
	}

	public class ListaCompras
	{
		public int Id { get; set; }
		public string Factura { get; set; }
		public int Codigo { get; set; }
		public string CodigoCompra
		{
			get { return Codigo.ToString("000000"); }
		}
		public DateTime FechaFactura { get; set; }
		public string Observacion { get; set; }
		public string Proveedor { get; set; }
		public string Estado { get; set; }
		public int EstadoId { get; set; }
		public int TotalItem { get; set; }
	}


	public class ListaDetalleCompras
	{
		public int Id { get; set; }
		public int IdEquipo { get; set; }
		public int Codigo { get; set; }
		public string CodigoEquipo { get; set; }
		public string Descripcion { get; set; }
		public int Cantidad { get; set; }
		public double Costo { get; set; }
	}
}
