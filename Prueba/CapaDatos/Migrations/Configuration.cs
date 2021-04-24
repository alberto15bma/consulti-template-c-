namespace CapaDatos.Migrations
{
	using Modelo;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<CapaDatos.Modelo.BDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CapaDatos.Modelo.BDContext context)
        {
			// AGREGAR ROLES
			context.TipoUsuario.AddOrUpdate(x => x.Descripcion,
				new TipoUsuario { Descripcion = "USUARIO" },
				new TipoUsuario { Descripcion = "PROVEEDOR" },
				new TipoUsuario { Descripcion = "CLIENTE" }
				);
			// AGREGAR PERFILES
			context.Perfil.AddOrUpdate(x => x.Descripcion,
				new Perfil { Descripcion = "SISTEMAS" },
				new Perfil { Descripcion = "ADMINISTRADOR" },
				new Perfil { Descripcion = "PROVEEDOR" },
				new Perfil { Descripcion = "CLIENTE" }
				);
			// AGREGAR ADMINISTRADOR
			context.Usuarios.AddOrUpdate(x => x.Usuario,
				new Usuarios
				{
					Apellidos = "ADMIN",
					Nombres = "ADMIN",
					Cedula = "123456789",
					Celular = "9999999999",
					Email = "admin@admin.com",
					Estado = true,
					FechaIngreso = DateTime.Now,
					FechaModificacion = DateTime.Now,
					InicioSesion = true,
					Notificacion = true,
					PerfilId = 2,
					TipoUsuarioId = 2,
					Usuario = "admin",
					Password = "UABAAHMAcwB3ADAAcgBkAA=="
				});
			// AGREGAR CONCEPTOS
			context.Conceptos.AddOrUpdate(x => x.Descripcion,
				new Conceptos { Descripcion = "INGRESO", Tipo = "I" },
				new Conceptos { Descripcion = "EGRESO", Tipo = "E" },
				new Conceptos { Descripcion = "INVENTARIO", Inventario = true }
				);
			// AGREGAR ESTADO
			context.Estado.AddOrUpdate(x => x.Descripcion,
				new Estado { Descripcion = "NUEVO" }
				);

			// AGREGAR ESTADO MOVIMIENTO
			context.EstadoMovimiento.AddOrUpdate(x => x.Descripcion,
				new EstadoMovimiento { Descripcion = "PROCESADO" },
				new EstadoMovimiento { Descripcion = "ANULADO" },
				new EstadoMovimiento { Descripcion = "ARCHIVADO" }
				);
			// AGREGAR ESTADO SALIDA
			context.EstadoSalida.AddOrUpdate(x => x.Descripcion,
				new EstadoSalida { Descripcion = "ARCHIVADO" },
				new EstadoSalida { Descripcion = "ANULADO" },
				new EstadoSalida { Descripcion = "PENDIENTE" }
				);
			// AGREGAR Ubicacion
			context.Ubicacion.AddOrUpdate(x => x.Descripcion,
				new Ubicacion { Descripcion = "BODEGA" },
				new Ubicacion { Descripcion = "OFICINA" }
				);
		}
	}
}
