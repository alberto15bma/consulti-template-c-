using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.IO;
using CapaPresentacion.Sistema;

namespace CapaPresentacion
{
	public partial class Principal : DevExpress.XtraEditors.XtraForm
	{
		private CapaDatos.Modelo.Usuarios usuario;
		public Principal(CapaDatos.Modelo.Usuarios user)
		{
			InitializeComponent();
			usuario = user;
			CargarData();
			//SplashScreenManager.CloseForm();
		}

		private void CargarData()
		{
			var apellido = usuario.Apellidos.Split(' ');
			var nombre = usuario.Nombres.Split(' ');
			cbUsuario.Text = apellido[0] + " " + nombre[0];
		}
		private void Principal_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Principal_FormClosing(object sender, FormClosingEventArgs e)
		{
			var alerta = XtraMessageBox.Show(Mensajes.CERRAR_FORM, Mensajes.Notificacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alerta == DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void tileControl1_ItemClick(object sender, TileItemEventArgs e)
		{
			switch (e.Item.Name)
			{
				case "tEquipos":
					//var equipo = new Vista.Equipos.FrmLista();
					//equipo.ShowDialog();
					//break;
					var inv = new Vista.Inventario.FrmInventario();
					inv.ShowDialog();
					break;
				case "tProveedores":
					var pro = new Vista.Proveedor.FrmLista();
					pro.ShowDialog();
					break;
				case "tClientes":
					var cli = new Vista.Clientes.FrmLista();
					cli.ShowDialog();
					break;
				case "tCompras":
					var com = new Vista.Compras.FrmLista();
					com.ShowDialog();
					break;
				case "tInventario":
					var lis_inv = new Vista.Inventario.FrmLista();
					lis_inv.ShowDialog();
					break;
				case "tIngresoEgreso":
					var ie = new Vista.IngresoEgreso.FrmLista();
					ie.ShowDialog();
					break;
				case "tSalida":
					var reg = new CapaNegocio.Logica.Registro();
					reg.Id = 0;
					reg.tipo = "Nuevo";
					var sa = new Vista.Salida.FrmSalida(reg);
					sa.ShowDialog();
					break;
				case "tAdministracion":
					var ad = new Vista.Administracion.FrmConfiguracionSystem();
					ad.ShowDialog();
					break;
			}
		}
	}
}