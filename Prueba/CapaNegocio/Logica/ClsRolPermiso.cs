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
	public class ClsRolPermiso
	{
		public List<cMenu> ObtenerPermisos()
		{
			var lista = new List<cMenu>();
			try
			{
				using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"SELECT Id AS IdMenu, * FROM Menu";
						lista = db.Query<cMenu>(sql, commandType: CommandType.Text).ToList();
						db.Close();
						return lista;
					}
				}
			}
			catch (Exception e)
			{
				return lista;
			}
			return lista;
		}
		public void CrearMenu(ref OperacionResult result, Menu menu)
		{
			using (var db = new BDContext())
			{
				try
				{
					var nivel = db.Menu.Where(a => a.ParentId == menu.ParentId).ToList();
					var men = new Menu();
					men = menu;
					if (nivel.Count() > 0)
					{
						men.Nivel = nivel.Max(a => a.Nivel) + 1;
					}
					else
					{
						men.Nivel = 1;
					}

					db.Menu.Add(men);
					db.SaveChanges();
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsRolPermiso.CrearMenu()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public void ModificarMenu(ref OperacionResult result, Menu menu)
		{
			using (var db = new BDContext())
			{
				try
				{
					var me = db.Menu.FirstOrDefault(a => a.Id == menu.Id);
					if (me != null)
					{
						db.Entry(me).CurrentValues.SetValues(menu);
						db.SaveChanges();
						result.success = 1;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsRolPermiso.ModificarMenu()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public static void SetPermiso(ref OperacionResult result, int IdUsusario, int idMenu, bool check)
		{
			using (var db = new BDContext())
			{
				try
				{
					var permiso = db.MenuUsuario.FirstOrDefault(a => a.MenuId == idMenu && a.UsuarioId == IdUsusario);
					if (permiso != null)
					{
						if (check)
						{
							permiso.Estado = check;
							db.SaveChanges();
						}
						else
						{
							db.MenuUsuario.Remove(permiso);
							db.SaveChanges();
						}
					}
					else
					{
						if (check)
						{
							var Nuevopermiso = new MenuUsuario();
							Nuevopermiso.Estado = check;
							Nuevopermiso.MenuId = idMenu;
							Nuevopermiso.UsuarioId = IdUsusario;
							db.MenuUsuario.Add(Nuevopermiso);
							db.SaveChanges();
						}
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsRolPermiso.SetPermiso()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public void SetPerfilPermiso(ref OperacionResult result, int IdPerfil, int idMenu, bool check)
		{
			using (var db = new BDContext())
			{
				try
				{
					var permiso = db.MenuPerfil.FirstOrDefault(a => a.MenuId == idMenu && a.PerfilId == IdPerfil);
					if (permiso != null)
					{
						if (check)
						{
							permiso.Estado = check;
							db.SaveChanges();
						}
						else
						{
							db.MenuPerfil.Remove(permiso);
							db.SaveChanges();
						}
					}
					else
					{
						if (check)
						{
							var perfil = new MenuPerfil();
							perfil.Estado = check;
							perfil.MenuId = idMenu;
							perfil.PerfilId = IdPerfil;
							db.MenuPerfil.Add(perfil);
							db.SaveChanges();
						}
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsRolPermiso.SetPerfilPermiso()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public List<cMenuUsuario> GetPermisos(int idUser)
		{
			var lista = new List<cMenuUsuario>();
			try
			{
				using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"SELECT * FROM MenuUsuario mu INNER JOIN Menu m on (m.Id = mu.MenuId) WHERE UsuarioId = {idUser}  AND Estado = 1";
						lista = db.Query<cMenuUsuario>(sql, commandType: CommandType.Text).ToList();
						db.Close();
						return lista;
					}
				}
			}
			catch (Exception e)
			{
				return lista;
			}
			return lista;
		}

		public static Menu GetMenu(int IdMenu)
		{
			var menu = new Menu();
			using (var db = new BDContext())
			{
				try
				{
					menu = db.Menu.FirstOrDefault(a => a.Id == IdMenu);
				}

				catch (Exception e)
				{
					((IDisposable)db).Dispose();
					return menu;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
			return menu;
		}

		public static List<cMenuUsuario> GetPerfilUsuario(int idPerfil)
		{
			var lista = new List<cMenuUsuario>();
			try
			{
				using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"SELECT * FROM MenuPerfil mu INNER JOIN Menu m on (m.Id = mu.MenuId) WHERE PerfilId = {idPerfil} AND Estado = 1";
						lista = db.Query<cMenuUsuario>(sql, commandType: CommandType.Text).ToList();
						db.Close();
						return lista;
					}
				}
			}
			catch (Exception e)
			{
				return lista;
			}
			return lista;
		}
	}
	public class cMenu
	{
		public int Id { get; set; }
		public int ParentId { get; set; }
		public int Nivel { get; set; }
		public string Descripcion { get; set; }
		public string Nombre { get; set; }
		public int IdMenu { get; set; }
		public string Accion { get; set; }
	}
	public class cMenuUsuario
	{
		public int Id { get; set; }
		public int UsuarioId { get; set; }
		public virtual Usuarios usuario { get; set; }
		public int MenuId { get; set; }
		public virtual Menu menu { get; set; }
		public bool Estado { get; set; }
		public string Descripcion { get; set; }
		public string Nombre { get; set; }
	}
}
