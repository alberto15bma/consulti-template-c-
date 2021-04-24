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
	public class ClsLogin
	{
		public Usuarios GetLogin(string usuario, string password)
		{
			var lista = new Usuarios();
			using (var db = new SqlConnection(new ClsConexionBD().Conexion()))
			{
				try
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						var sql = $"SELECT * FROM UsuarioS Where Usuario = '{usuario}' AND Password = '{password}' AND Estado = 1 AND InicioSesion = 1";
						lista = db.Query<Usuarios>(sql, commandType: CommandType.Text).FirstOrDefault();
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

		public void CambiarContrasenia(ref OperacionResult result, Usuarios login, string passNueva)
		{
			using (var db = new BDContext())
			{
				try
				{
					var existe = db.Usuarios.FirstOrDefault(a => a.Id == login.Id);
					if (existe != null)
					{
						existe.Password = passNueva;
						existe.FechaModificacion = DateTime.Now;
						db.SaveChanges();
						result.success = 1;
					}

				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsLogin.CambiarContrasenia()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
	}
}
