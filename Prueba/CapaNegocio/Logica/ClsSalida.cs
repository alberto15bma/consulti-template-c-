
using CapaDatos.Modelo;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	public class ClsSalida
	{
		public void CrearSalida(ref OperacionResult result, CapaDatos.Modelo.Salida mov, BindingList<DetalleIngresoEgreso> detalle, bool pendiente)
		{

			using (var db = new BDContext())
			{
				try
				{
					var lista = detalle.ToList();
					if (lista.Count() > 0)
					{
						var sa = new Salida();
						sa = mov;
						var existe = db.Salida.FirstOrDefault(a=>a.Id == sa.Id);
						if (existe != null)
						{
							sa.Id = existe.Id;
							db.Entry(existe).CurrentValues.SetValues(sa);
						}else
						{
							db.Salida.Add(sa);
						}
						db.SaveChanges();
						int idSalida = sa.Id;
						sa = null;

						CrearListaDetalle(ref result, idSalida, lista, existe);
						if (!pendiente)
							ArchivarSalida(ref result, lista);
				
						result.success = 1;
					}
					else
					{
						result.success = 0;
						result.ErrorMensaje = "No se pudo guardar los datos porque no ingresaste ningún registro.";
						result.InnerException = "Por favor, intenta nuevamente.";
						result.InformacionAdicional = "ClsSalida.CrearSalida()";
						return;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsSalida.CrearSalida()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		private void CrearListaDetalle(ref OperacionResult result, int idMov, List<DetalleIngresoEgreso> lista, Salida existe)
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
						var det = new DetalleSalida();
						det.StockActual = lista[i].Stock;
						det.Cantidad = lista[i].Cantidad;
						det.ProductoId = lista[i].IdEquipo;
						det.EstadoId = lista[i].Estado;			
						det.SalidaId = idMov;

						db.DetalleSalida.Add(det);
						db.SaveChanges();
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsSalida.CrearListaDetalle()";
					return;
				}
			}
		}
		private void EliminarPendientes(int idSalida)
		{
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"DELETE FROM DetalleSalida where SalidaId = {idSalida}";

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
		public void ArchivarSalida(ref OperacionResult result, List<DetalleIngresoEgreso> detalle)
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
							existe.StockAnterior = existe.Stock;
							existe.Stock = existe.Stock - det.Stock;
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

		public static int GetSecuencial()
		{
			using (var db = new BDContext())
			{
				try
				{
					var data = db.Salida.FirstOrDefault();
					if (data != null)
					{
						return db.Salida.Max(a => a.Codigo) + 1;
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

		public static List<EstadoSalida> GetEstados()
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.EstadoSalida.ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public Salida GetSalida(int id)
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Salida.FirstOrDefault(a=>a.Id == id);
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		public List<DetalleSalida> GetDetalleSalida(int idSalida)
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.DetalleSalida
						.Include(a=>a.producto)
						.Include(a=>a.estado)
						.Where(a=>a.SalidaId == idSalida).ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		public List<ListaSalidas> GetSalidas()
		{
			var lista = new List<ListaSalidas>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select s.Id, s.Codigo, s.Fecha, CONCAT(u.Apellidos, ' ', u.Nombres) as Cliente, u.Cedula, CONCAT(us.Apellidos, ' ', us.Nombres) as Usuario, 
									es.Descripcion as Estado, s.EstadoId, s.Comentario, s.ComentarioTicket, 
									COUNT(ds.Cantidad) as TotalItem from Salida s 
									inner join DetalleSalida ds on (ds.SalidaId = s.Id)
									inner join EstadoSalida es on (es.Id = s.EstadoId)
									inner join Usuarios u on (u.Id = s.ClienteId)
									inner join Usuarios us on (us.Id = s.UsuarioId)
									group by s.Id, s.Codigo, s.Fecha, u.Cedula, es.Descripcion, u.Apellidos, u.Nombres, us.Cedula, us.Apellidos, us.Nombres, s.EstadoId, s.Comentario, s.ComentarioTicket";

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
	}
}
public class ListaSalidas
{
	public int Id { get; set; }
	public int Codigo { get; set; }
	public string CodigoIE
	{
		get { return Codigo.ToString("000000"); }
	}
	public DateTime Fecha { get; set; }
	public string Comentario { get; set; }
	public string ComentarioTicket { get; set; }
	public string Cedula { get; set; }
	public string Cliente { get; set; }
	public int TotalItem { get; set; }
	public int EstadoId { get; set; }
	public string Estado { get; set; }
	public string Usuario { get; set; }
	public string Concepto { get; set; }
}

