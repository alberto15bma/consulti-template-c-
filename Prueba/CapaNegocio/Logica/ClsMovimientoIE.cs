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
	public class ClsMovimientoIE
	{
		public void CrearMovimiento(ref OperacionResult result, CapaDatos.Modelo.MovimientoIE mov, BindingList<DetalleIngresoEgreso> detalle)
		{

			using (var db = new BDContext())
			{
				try
				{
					var lista = detalle.ToList();
					if (lista.Count() > 0)
					{
						var com = new MovimientoIE();
						com = mov;
						db.MovimientoIE.Add(com);
						db.SaveChanges();
						int idCompra = com.Id;
						com = null;

						CrearListaDetalle(ref result, idCompra, lista);
						ArchivarIngresoEgreso(ref result, lista, mov.Tipo);
						result.success = 1;
					}
					else
					{
						result.success = 0;
						result.ErrorMensaje = "No se pudo guardar los datos porque no ingresaste ningún registro.";
						result.InnerException = "Por favor, intenta nuevamente.";
						result.InformacionAdicional = "ClsMovimientoIE.CrearMovimiento()";
						return;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsMovimientoIE.CrearMovimiento()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}	
		}

		private void CrearListaDetalle(ref OperacionResult result, int idMov, List<DetalleIngresoEgreso> lista)
		{
			using (var db = new BDContext())
			{
				try
				{
					for (int i = 0; i < lista.Count(); i++)
					{
						var det = new DetalleMovimientoIE();
						det.Cantidad = lista[i].Cantidad;
						det.ProductoId = lista[i].IdEquipo;
						det.EstadoId = lista[i].Estado;				
						det.MovimientoIEid = idMov;

						db.DetalleMovimientoIE.Add(det);
						db.SaveChanges();
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsMovimientoIE.CrearListaDetalle()";
					return;
				}
			}
		}
		public void ArchivarIngresoEgreso(ref OperacionResult result, List<DetalleIngresoEgreso> detalle, string tipo)
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
						var existe = db.Movimiento.FirstOrDefault(a => a.ProductoId == det.ProductoId  && a.EstadoId == det.EstadoId);
						if (existe != null)
						{
							existe.FechaModificacion = DateTime.Now;

							if (tipo == "I")
							{
								existe.StockAnterior = existe.Stock;
								existe.Stock = existe.Stock + det.Stock;
							}else
							{
								existe.StockAnterior = existe.Stock;
								existe.Stock = existe.Stock - det.Stock;
							}
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
					result.InformacionAdicional = "ClsMovimientoIE.ArchivarIngresoEgreso()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		public List<ListaMovimientoIE> GetMovimientos()
		{
			var lista = new List<ListaMovimientoIE>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select m.Id, m.Codigo, m.Fecha, m.Tipo, c.Descripcion as Concepto, m.Observacion, COUNT(dt.Cantidad) as TotalItem from MovimientoIE m 
									inner join DetalleMovimientoIE dt on (dt.MovimientoIEid = m.Id)
									inner join Conceptos c on (c.Id = m.ConceptoId)
									group by m.Id, m.Codigo, m.Fecha, m.Tipo, c.Descripcion, m.Observacion";

						lista = db.Query<ListaMovimientoIE>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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
		public List<DetalleIE> GetDetalleMovimiento(int id)
		{
			var lista = new List<DetalleIE>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select m.Id as MovimientoId, dt.Id, e.Codigo, e.Descripcion, 
									es.Descripcion as Estado, dt.Cantidad
									from MovimientoIE m 
									inner join DetalleMovimientoIE dt on (dt.MovimientoIEid = m.Id)
									inner join Producto e on (e.Id = dt.ProductoId)						
									inner join Estado es on (es.Id = dt.EstadoId)
									inner join Conceptos c on (c.Id = m.ConceptoId)"+
									$" where m.Id = {id}";

						lista = db.Query<DetalleIE>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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

		public static int GetSecuencial()
		{
			using (var db = new BDContext())
			{
				try
				{
					var data = db.MovimientoIE.FirstOrDefault();
					if (data != null)
					{
						return db.MovimientoIE.Max(a => a.Codigo) + 1;
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
}

public class ListaMovimientoIE
{
	public int Id { get; set; }
	public int Codigo { get; set; }
	public string CodigoIE
	{
		get { return Codigo.ToString("000000"); }
	}
	public DateTime Fecha { get; set; }
	public string Observacion { get; set; }
	public string Tipo { get; set; }
	public string Concepto { get; set; }
	public int TotalItem { get; set; }
	public List<DetalleIE> Detalle {  get; set; } 
}

public class DetalleIE
{
	public int Codigo { get; set; }
	public string CodigoEquipo
	{
		get { return Codigo.ToString("000000"); }
		set { }
	}
	public string CodigoBarras { get; set; }
	public string Descripcion { get; set; }
	public string Estado { get; set; }
	public int Cantidad { get; set; }
	public int Stock { get; set; }
}