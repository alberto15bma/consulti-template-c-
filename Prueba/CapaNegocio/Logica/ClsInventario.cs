using CapaDatos.Modelo;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;

namespace CapaNegocio.Logica
{
	public class ClsInventario
	{
		public void CrearInventario(ref OperacionResult result, CapaDatos.Modelo.Inventario mov, BindingList<DetalleIngresoEgreso> detalle)
		{

			using (var db = new BDContext())
			{
				try
				{
					var lista = detalle.Where(a=>a.Estado != 0).ToList();
					if (lista.Count() > 0)
					{
						var sa = new Inventario();
						sa = mov;
						var existe = db.Inventario.FirstOrDefault(a => a.Id == sa.Id);
						if (existe != null)
						{
							sa.Id = existe.Id;
							db.Entry(existe).CurrentValues.SetValues(sa);
						}
						else
						{
							db.Inventario.Add(sa);
						}
						db.SaveChanges();
						int idSalida = sa.Id;
						sa = null;

						CrearListaDetalle(ref result, idSalida, lista, existe);
						CrearRespaldoMovimiento(ref result, idSalida);
						LimpiarMovimientos();
						ArchivarInventario(ref result, lista);

						result.success = 1;
					}
					else
					{
						result.success = 0;
						result.ErrorMensaje = "No se pudo guardar los datos porque no ingresaste ningún registro.";
						result.InnerException = "Por favor, intenta nuevamente.";
						result.InformacionAdicional = "ClsInventario.CrearInventario()";
						return;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsInventario.CrearInventario()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		private void CrearListaDetalle(ref OperacionResult result, int idMov, List<DetalleIngresoEgreso> lista, Inventario existe)
		{
			using (var db = new BDContext())
			{
				try
				{
					if (existe != null)
					{
						EliminarPendientes(existe.Id);
					}
					for (int i = 0; i < lista.Count(); i++)
					{
						var det = new DetalleInventario();
						det.StockActual = lista[i].Stock;
						det.Cantidad = lista[i].Cantidad;
						det.ProductoId = lista[i].IdEquipo;
						det.EstadoId = lista[i].Estado;
						det.InventarioId = idMov;

						db.DetalleInventario.Add(det);
						db.SaveChanges();
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsInventario.CrearListaDetalle()";
					return;
				}
			}
		}
		private void CrearRespaldoMovimiento(ref OperacionResult result, int idMov)
		{
			using (var db = new BDContext())
			{
				try
				{
					var lista = db.Movimiento.ToList();
					for (int i = 0; i < lista.Count(); i++)
					{
						var det = new MovimientoRespaldo();
						det.ProductoId = lista[i].ProductoId;
						det.EstadoProducto = lista[i].EstadoProducto;
						det.EstadoId = lista[i].EstadoId;
						det.FechaModificacion = lista[i].FechaModificacion;
						det.InventarioId = idMov;				
						det.Stock = lista[i].Stock;
						det.StockAnterior = lista[i].StockAnterior;
						
						db.MovimientoRespaldo.Add(det);
						db.SaveChanges();
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsInventario.CrearRespaldoMovimiento()";
					return;
				}
			}
		}

		public void ArchivarInventario(ref OperacionResult result, List<DetalleIngresoEgreso> detalle)
		{
			using (var db = new BDContext())
			{
				try
				{
					// Verificar producto
					for (int i = 0; i < detalle.Count(); i++)
					{
						var det = new Movimiento();
						det.ProductoId = detalle[i].IdEquipo;
						det.FechaModificacion = DateTime.Now;
						det.EstadoId = detalle[i].Estado;
						
						det.Stock = detalle[i].Cantidad;
						var existe = db.Movimiento.FirstOrDefault(a => a.ProductoId == det.ProductoId && a.EstadoId == det.EstadoId);
						if (existe != null)
						{
							existe.FechaModificacion = DateTime.Now;
							existe.StockAnterior = detalle[i].Stock;
							existe.Stock = det.Stock;
						}
						else
						{
							db.Movimiento.Add(det);
						}
						db.SaveChanges();
					}
					result.success = 1;

				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsSalida.ArchivarSalida()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		private void LimpiarMovimientos()
		{
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"UPDATE Movimiento  set Stock = 0";

						var filas = db.Execute(sql);
						db.Close();
						//return lista;
					}
				}
				catch (Exception e)
				{
					//return lista;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		private void EliminarPendientes(int idInventario)
		{
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"DELETE FROM DetalleInventario where InventarioId = {idInventario}";

						var filas = db.Execute(sql);
						db.Close();
						//return lista;
					}
				}
				catch (Exception e)
				{
					//return lista;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public static List<ListaInventario> GetListaInventario()
		{
			var lista = new List<ListaInventario>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select e.Codigo, e.CodigoBarras, e.StockMax, e.StockMin, e.Descripcion, 
									ee.Descripcion as Estado, m.EstadoId, m.Stock  from Producto e 
									left join Movimiento m on (m.ProductoId = e.Id)
									left join Estado ee on (ee.Id = m.EstadoId)";

						lista = db.Query<ListaInventario>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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

		public Inventario GuardarTemporal(Inventario inv)
		{
			var inventario = new Inventario();
			using (var db = new BDContext())
			{
				try
				{
					inventario = db.Inventario.Add(inv);
					db.SaveChanges();
				}
				catch (Exception e)
				{
					return inventario;
				}
			}
			return inventario;
		}

		public static void GuardarDetalleTemporal(Inventario iNVENTARIO, DetalleIngresoEgreso row)
		{
			using (var db = new BDContext())
			{
				try
				{
					var det = new DetalleInventario();
					det.Cantidad = row.Cantidad;
					det.ProductoId = row.IdEquipo;
					det.EstadoId = row.Estado;
					det.InventarioId = iNVENTARIO.Id;
				
					det.StockActual = row.Stock;

					var existe = db.DetalleInventario.FirstOrDefault(a => a.ProductoId == det.ProductoId && a.EstadoId == det.EstadoId && a.InventarioId == det.InventarioId);
					if (existe != null)
					{
						det.Id = existe.Id;
						db.Entry(existe).CurrentValues.SetValues(det);
					}else
					{
						db.DetalleInventario.Add(det);
					}
					db.SaveChanges();
				}
				catch (Exception e)
				{
					
				}
			}
		}

		public static int GetSecuencial()
		{
			using (var db = new BDContext())
			{
				try
				{
					var data = db.Inventario.FirstOrDefault();
					if (data != null)
					{
						return db.Inventario.Max(a => a.Codigo) + 1;
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

		public List<ListaSalidas> GetInventarios()
		{
			var lista = new List<ListaSalidas>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select i.Id, i.Codigo, i.Fecha, us.Cedula, CONCAT(us.Apellidos, ' ', us.Nombres) as Usuario, 
									es.Descripcion as Estado, i.EstadoId, i.Observacion as Comentario, c.Descripcion as Concepto,
									COUNT(di.Cantidad) as TotalItem from Inventario i 
									left join DetalleInventario di on (di.InventarioId = i.Id)
									inner join EstadoSalida es on (es.Id = i.EstadoId)
									inner join Usuarios us on (us.Id = i.UsuarioId)
									inner join Conceptos c on (c.Id = i.ConceptoId)
									group by i.Id, i.Codigo, i.Fecha,  es.Descripcion, us.Apellidos, us.Nombres, us.Cedula, us.Apellidos, us.Nombres, 
									i.EstadoId, i.Observacion, c.Descripcion";

						lista = db.Query<ListaSalidas>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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

		public Inventario GetInventario(int id)
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Inventario.FirstOrDefault(a => a.Id == id);
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public List<DetalleInventario> GetDetalleInventario(int idInventario)
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.DetalleInventario
						.Include(a => a.estado)
						.Include(a => a.producto)
						.Where(a => a.InventarioId == idInventario).ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
	}
}


public class ListaInventario
{
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