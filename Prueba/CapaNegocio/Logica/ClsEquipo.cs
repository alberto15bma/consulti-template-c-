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
	public class ClsEquipo
	{
		public List<ListaProducto> GetProductos()
		{
			var lista = new List<ListaProducto>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"select e.Id, e.Codigo, e.CodigoBarras, e.Estado, e.StockMax, e.StockMin, Descripcion from Producto e";

						lista = db.Query<ListaProducto>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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



		public void CrearProducto(ref OperacionResult result, Producto producto)
		{

			using (var db = new BDContext())
			{
				try
				{
					db.Producto.Add(producto);
					db.SaveChanges();
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsEquipo.CrearProducto()";
					return;
				}
			}
		}
		public void ModificarProducto(ref OperacionResult result, Producto producto)
		{
			using (var db = new BDContext())
			{
				try
				{
					var eq = db.Producto.FirstOrDefault(a => a.Id == producto.Id);
					if (eq != null)
					{
						db.Entry(eq).CurrentValues.SetValues(producto);
						db.SaveChanges();
				
						result.success = 1;
					}
					else
					{
						result.success = 0;
						result.ErrorMensaje = "El producto no existe";
						result.InnerException = string.Empty;
						result.InformacionAdicional = "ClsEquipo.ModificarEquipo()";
						return;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsEquipo.ModificarEquipo()";
					return;
				}
			}
		}


		public static List<Ubicacion> GetUbicacion()
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Ubicacion.OrderBy(a => a.Descripcion).ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}

		public static List<Estado> GetEstados()
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Estado.OrderBy(a => a.Descripcion).ToList();
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
					var data = db.Producto.FirstOrDefault();
					if (data != null)
					{
						return db.Producto.Max(a => a.Codigo)+1;
					}else
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

	
		public Producto GetProducto(int Id)
		{
			var lista = new Producto();
			using (var db = new BDContext())
			{
				try
				{
					lista = db.Producto.FirstOrDefault(a => a.Id == Id);
				}

				catch (Exception e)
				{
					((IDisposable)db).Dispose();
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

public class ListaProducto
{
	public int Id { get; set; }
	public int Codigo { get; set; }
	public string CodigoEquipo
	{
		get { return Codigo.ToString("000000"); }
	}
	public string CodigoBarras { get; set; }
	public string Descripcion { get; set; }
	public int StockMin { get; set; }
	public int StockMax { get; set; }
	public bool Estado { get; set; }
	public string EstadoEquipo {
		get { return Estado == true ? "ACTIVO" : "INACTIVO"; }
	}
}