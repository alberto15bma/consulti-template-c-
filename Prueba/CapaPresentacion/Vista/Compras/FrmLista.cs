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

namespace CapaPresentacion.Vista.Compras
{
	public partial class FrmLista : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<ListaCompras> LISTA_COMPRAS = new List<ListaCompras>();
		public FrmLista()
		{
			InitializeComponent();
			Consultar();
		}

		private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var reg = new CapaNegocio.Logica.Registro();
			reg.tipo = "Nuevo";
			var nuevo = new Vista.Compras.FrmNuevo(reg);
			var res = nuevo.ShowDialog();
			if (res == DialogResult.OK)
			{
				Consultar();
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
		internal async void Consultar()
		{
			CargarGrillas();
			OpcionesDeSistema.IniciarAnimacion("Cargando información", this.ParentForm);

			var user = new ClsCompras();
			LISTA_COMPRAS = user.GetCompras();
			if (LISTA_COMPRAS.Count() > 0)
			{
				OpcionesDeSistema.FinalizarAnimacion();
			}
			else
			{
				OpcionesDeSistema.FinalizarAnimacion();
				XtraMessageBox.Show(Mensajes.SIN_DATOS, Mensajes.Notificacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			GridLista.DataSource = LISTA_COMPRAS;
			CargarInfo();
		}

		private void CargarInfo()
		{
			var total_procesada = LISTA_COMPRAS.Where(a => a.EstadoId == 1).Count();
			var total_anulada = LISTA_COMPRAS.Where(a => a.EstadoId == 2).Count();
			var total_archivada = LISTA_COMPRAS.Where(a => a.EstadoId == 3).Count();
			txtTotalProcesadas.EditValue = total_procesada;
			txtTotalAnuladas.EditValue = total_anulada;
			txtTotalArchivadas.EditValue = total_archivada;
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle > -1)
			{
				HabilitarArchivar(e.FocusedRowHandle);
			}
		}	

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				HabilitarArchivar(e.RowHandle);
			}
		}
		private void HabilitarArchivar(int rowHandle)
		{
			var estado = gridView1.GetRowCellValue(rowHandle, "EstadoId");
			if (estado != null)
			{
				switch ((int)estado)
				{
					case 1:
						btnArchivar.Enabled = true;
						break;
					default:
						btnArchivar.Enabled = false;
						break;
				}
			}
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				var estado = gridView1.GetRowCellValue(e.RowHandle, "EstadoId");
				if (estado != null)
				{
					e.Appearance.ForeColor = Color.Black;
					switch ((int)estado)
					{
						case 1: // procesado
							e.Appearance.BackColor = Color.FromArgb(255, 224, 192);
							break;
						case 2: // anulado
							e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
							break;
						case 3: // archivado
							e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
							break;
					}
				}
			}
		}

		private void btnArchivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Archivar();
		}
		internal void Archivar()
		{
			var Id = gridView1.GetFocusedRowCellValue("Id");
			if (Id != null)
			{
				var result = new OperacionResult();
				var mov = new ClsMovimiento();
				var comp = new ClsCompras();
				int ID_COMPRA = Convert.ToInt32(Id);
				var detalle = comp.GetDetalleCompra(ID_COMPRA);
				mov.ArchivarCompra(ref result, detalle);
				if (result.success == 1)
				{
					XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess);
					Consultar();
				}
				else
				{
					XtraMessageBox.Show(Mensajes.ERROR_ARCHIVAR + "\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
				}
			}
		}

		private void btnVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}
	}
}