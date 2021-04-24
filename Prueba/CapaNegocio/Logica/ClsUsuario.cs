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
	public class ClsUsuario : ClsRolPermiso
	{
		public List<ListaUsuarios> GetUsuarios()
		{
			var lista = new List<ListaUsuarios>();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = @"SELECT u.Id, Cedula, Usuario, (Apellidos+' '+Nombres) as Nombres, u.Celular, u.Email, u.Password, 
								u.PerfilId, u.TipoUsuarioId, u.Direccion, u.RazonSocial, p.Descripcion as Perfil, u.InicioSesion, u.Estado FROM Usuarios u
									INNER JOIN Perfil p on (p.Id = u.PerfilId)";

						lista = db.Query<ListaUsuarios>(sql, commandTimeout: 900000, commandType: CommandType.Text).ToList();
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

		public Usuarios GetUsuario(int Id)
		{
			var lista = new Usuarios();
			using (var db = new BDContext())
			{
				try
				{
					lista = db.Usuarios.FirstOrDefault(a => a.Id == Id);
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
		public void CrearUsuario(ref OperacionResult result, Usuarios usuario)
		{
			using (var db = new BDContext())
			{
				try
				{
					db.Usuarios.Add(usuario);
					db.SaveChanges();
					if (usuario.InicioSesion)
					{
						int IdPerfil = (int)usuario.PerfilId;
						var listaPerfil = GetPerfilUsuario(IdPerfil);
						for (int i = 0; i < listaPerfil.Count(); i++)
						{
							SetPermiso(ref result, usuario.Id, listaPerfil[i].MenuId, listaPerfil[i].Estado);
						}
					}
					result.success = 1;
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsUsuario.CrearUsuario()";
					return;
				}
			}
		}
		public void ModificarUsuario(ref OperacionResult result, Usuarios usuario)
		{
			using (var db = new BDContext())
			{
				try
				{
					var user = db.Usuarios.FirstOrDefault(a => a.Id == usuario.Id);
					if (user != null)
					{
						//user = usuario;
						//user.Id = nu;
						db.Entry(user).CurrentValues.SetValues(usuario);
						db.SaveChanges();
						if (usuario.InicioSesion)
						{
							int IdPerfil = (int)usuario.PerfilId;
							var listaPerfil = GetPerfilUsuario(IdPerfil);
							for (int i = 0; i < listaPerfil.Count(); i++)
							{
								SetPermiso(ref result, usuario.Id, listaPerfil[i].MenuId, listaPerfil[i].Estado);
							}
						}
						result.success = 1;
					}
					else
					{
						result.success = 0;
						result.ErrorMensaje = "El usuario no existe";
						result.InnerException = string.Empty;
						result.InformacionAdicional = "ClsUsuario.ModificarUsuario()";
						return;
					}
				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsUsuario.ModificarUsuario()";
					return;
				}
			}
		}
		public static List<Perfil> GetPerfilUsuario()
		{
			using (var db = new BDContext())
			{
				try
				{
					return db.Perfil.ToList();
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
					return db.Estado.ToList();
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
		public bool ValidarExistenciaUsuario(string cedula)
		{
			using (var db = new BDContext())
			{
				var empleado = db.Usuarios.FirstOrDefault(a => a.Cedula == cedula);
				if (empleado == null)
				{
					return false;
				}
				return true;
			}
		}

	}
}
public class ListaUsuarios
{
	public int Id { get; set; }
	public string Cedula { get; set; }
	public string Usuario { get; set; }
	public string Password { get; set; }
	public string Nombres { get; set; }
	//public byte[] Foto { get; set; }
	public int IdPerfil { get; set; }
	public int TipoUsuarioId { get; set; }
	public string Perfil { get; set; }
	public bool InicioSesion { get; set; }
	public bool Estado { get; set; }
	public string Celular { get; set; }
	public string Email { get; set; }
	public string RazonSocial { get; set; }
	public string Direccion { get; set; }
}