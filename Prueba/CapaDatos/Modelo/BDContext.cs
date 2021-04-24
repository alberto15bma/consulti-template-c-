using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	public partial class BDContext : DbContext
	{
		static BDContext()
		{
			Database.SetInitializer<BDContext>(null);
		}
		public BDContext()
			: base("BDConexion")
		{
			var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
		}

		public static BDContext Create()
		{
			return new BDContext();
		}
		public DbSet<TipoUsuario> TipoUsuario { get; set; }
		public DbSet<Perfil> Perfil { get; set; }
		public DbSet<Estado> Estado { get; set; }
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Menu> Menu { get; set; }
		public DbSet<MenuUsuario> MenuUsuario { get; set; }
		public DbSet<MenuPerfil> MenuPerfil { get; set; }
		public DbSet<Ubicacion> Ubicacion { get; set; }
		public DbSet<Producto> Producto { get; set; }
		public DbSet<EstadoMovimiento> EstadoMovimiento { get; set; }
		public DbSet<Compras> Compras { get; set; }
		public DbSet<DetalleCompra> DetalleCompra { get; set; }
		public DbSet<Movimiento> Movimiento { get; set; }
		public DbSet<Conceptos> Conceptos { get; set; }
		public DbSet<MovimientoIE> MovimientoIE { get; set; }
		public DbSet<DetalleMovimientoIE> DetalleMovimientoIE { get; set; }
		//public DbSet<Empresa> Empresa { get; set; }
		//public DbSet<Impresora> Impresora { get; set; }
		public DbSet<EstadoSalida> EstadoSalida { get; set; }
		public DbSet<Salida> Salida { get; set; }
		public DbSet<DetalleSalida> DetalleSalida { get; set; }
		public DbSet<Inventario> Inventario { get; set; }
		public DbSet<DetalleInventario> DetalleInventario { get; set; }
		public DbSet<MovimientoRespaldo> MovimientoRespaldo { get; set; }
	}
}

