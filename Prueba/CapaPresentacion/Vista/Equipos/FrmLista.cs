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
using CapaNegocio.Logica;
using CapaPresentacion.Sistema;

namespace CapaPresentacion.Vista.Equipos
{
	public partial class FrmLista : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FrmLista()
		{
			InitializeComponent();
			Consultar();
		}

		private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var reg = new CapaNegocio.Logica.Registro();
			reg.tipo = "Nuevo";
			var nuevo = new Vista.Equipos.FrmNuevo(reg);
			nuevo.ShowDialog();
		}

		private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Editar();
		}
		internal void Editar()
		{
			var Id = gridView1.GetFocusedRowCellValue("Id");
			if (Id != null)
			{
				var registro = new Registro();
				registro.Id = Convert.ToInt32(Id);
				registro.tipo = "Editar";
				var nuevo = new Vista.Equipos.FrmNuevo(registro);
				nuevo.ShowDialog();
			}
		}
		private void CargarGrillas()
		{
			GridLista.DataSource = null;
			GridLista.Refresh();
		}

		private void btnCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Consultar();
		}
		internal void Consultar()
		{
			CargarGrillas();
			OpcionesDeSistema.IniciarAnimacion("Cargando información", this.ParentForm);

			var eq = new ClsEquipo();
			var lista = eq.GetProductos();
			if (lista.Count() > 0)
			{
				OpcionesDeSistema.FinalizarAnimacion();
			}
			else
			{
				OpcionesDeSistema.FinalizarAnimacion();
				XtraMessageBox.Show(Mensajes.SIN_DATOS, Mensajes.Notificacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			GridLista.DataSource = lista;
		}
	}
}