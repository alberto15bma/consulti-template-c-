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

namespace CapaPresentacion.Vista.Inventario
{
	public partial class FrmInventario : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FrmInventario()
		{
			InitializeComponent();
			rFiltro.EditValue = 1;
			Consultar();
		}

		private void btnCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Consultar();
		}

		public void Consultar()
		{
			CargarGrillas();
			OpcionesDeSistema.IniciarAnimacion("Cargando información", this.ParentForm);

			var lista = ClsInventario.GetListaInventario();
			var filtro = (int)rFiltro.EditValue;
			switch (filtro)
			{
				case 1:
					lista = lista.ToList();
					break;
				case 2:
					lista = lista.Where(a=>a.Stock > 0).ToList();
					break;
				case 3:
					lista = lista.Where(a => a.Stock == 0).ToList();
					break;
			}
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

			gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
			
			DevExpress.XtraGrid.GridGroupSummaryItem item = new DevExpress.XtraGrid.GridGroupSummaryItem();
			item.FieldName = "Total";
			item.SummaryType = DevExpress.Data.SummaryItemType.Count;
			gridView1.GroupSummary.Add(item);

			DevExpress.XtraGrid.GridGroupSummaryItem item1 = new DevExpress.XtraGrid.GridGroupSummaryItem();
			item1.FieldName = "Stock";
			item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
			//item1.DisplayFormat = "Total {0:c2}";
			item1.ShowInGroupColumnFooter = gridView1.Columns["Stock"];
			gridView1.GroupSummary.Add(item1);
			cargarTotales(lista);
		}

		private void cargarTotales(List<ListaInventario> lista)
		{
			txtTotal.Caption = lista.Count().ToString();
			txtConStock.Caption = lista.Where(a => a.Stock > 0).Count().ToString();
			txtSinStock.Caption = lista.Where(a => a.Stock == 0).Count().ToString();

			txtTotal2.Caption = "Total "+lista.Count().ToString();
			txtConStock2.Caption = "Con stock "+lista.Where(a => a.Stock > 0).Count().ToString();
			txtSinStock2.Caption = "Sin stock "+lista.Where(a => a.Stock == 0).Count().ToString();
		}

		private void CargarGrillas()
		{
			gridView1.GroupSummary.Clear();
			GridLista.DataSource = null;
			GridLista.Refresh();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				var stockMax = (int)gridView1.GetRowCellValue(e.RowHandle, StockMax);
				var stockMin = (int)gridView1.GetRowCellValue(e.RowHandle, StockMin);
				var stock = (int)gridView1.GetRowCellValue(e.RowHandle, Stock);

				e.Appearance.ForeColor = Color.Black;
				if (stock > stockMax)
				{
					e.Appearance.BackColor = Color.FromArgb(128, 255, 128);
				}
				if (stock == 0)
				{
					e.Appearance.BackColor = Color.FromArgb(255, 128, 128);
				}
				if (stock >= stockMax && stock <= stockMax)
				{
					e.Appearance.BackColor = Color.FromArgb(255, 192, 128);
				}
			}
		}

		private void btnListaEquipos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var equipo = new Vista.Equipos.FrmLista();
			equipo.ShowDialog();
		}
	}
}