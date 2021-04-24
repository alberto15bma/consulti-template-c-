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
using CapaPresentacion.Sistema;
using CapaNegocio.Logica;

namespace CapaPresentacion.Vista.Proveedor
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
			var nuevo = new Vista.Proveedor.FrmNuevo(reg);
			var res = nuevo.ShowDialog();
			if (res == DialogResult.OK)
			{
				Consultar();
			}
		}

		private void btnCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Consultar();
		}

		internal void Consultar()
		{
			CargarGrillas();
			OpcionesDeSistema.IniciarAnimacion("Cargando información", this.ParentForm);

			var user = new ClsUsuario();
			var lista = user.GetUsuarios().Where(a=>a.TipoUsuarioId == 2);
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
		private void CargarGrillas()
		{
			GridLista.DataSource = null;
			GridLista.Refresh();
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
				var nuevo = new Vista.Proveedor.FrmNuevo(registro);
				var res = nuevo.ShowDialog();
				if (res == DialogResult.OK)
				{
					Consultar();
				}
				//var item = new ClsEmpleado();
				//var lista = item.GetEmpleado(Convert.ToInt32(Id));

			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			
		}

		
	}
}