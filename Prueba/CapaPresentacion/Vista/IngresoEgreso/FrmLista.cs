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

namespace CapaPresentacion.Vista.IngresoEgreso
{
	public partial class FrmLista : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<ListaMovimientoIE> LISTA_MOVIMIENTO = new List<ListaMovimientoIE>();
		public FrmLista()
		{
			InitializeComponent();
			Consultar();
		}

		private void FrmLista_Load(object sender, EventArgs e)
		{

		}

		private void btnNuevoIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Registro re = new Registro();
			re.tipo = "Nuevo";
			var ni = new FrmNuevoIngreso("I", re);
			var res = ni.ShowDialog();
			if (res == DialogResult.OK)
			{
				Consultar();
			}
		}

		private void btnNuevoEgreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Registro re = new Registro();
			re.tipo = "Nuevo";
			var ni = new FrmNuevoIngreso("E", re);
			var res = ni.ShowDialog();
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

			var user = new ClsMovimientoIE();
			LISTA_MOVIMIENTO = user.GetMovimientos();
			if (LISTA_MOVIMIENTO.Count() > 0)
			{
				OpcionesDeSistema.FinalizarAnimacion();
			}
			else
			{
				OpcionesDeSistema.FinalizarAnimacion();
				XtraMessageBox.Show(Mensajes.SIN_DATOS, Mensajes.Notificacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			var chk = chkTodo.Checked;
			if (!chk)
			{
				var desde = Convert.ToDateTime(dtDesde.EditValue);
				var hasta = Convert.ToDateTime(Convert.ToDateTime(dtHasta.EditValue).ToShortDateString()+" 23:59:59");
				var tipo = cbTipo.EditValue.ToString();
				LISTA_MOVIMIENTO = LISTA_MOVIMIENTO.Where(a => a.Fecha >= desde && a.Fecha <= hasta).ToList();
				if (tipo != "TODO")
				{
					LISTA_MOVIMIENTO = LISTA_MOVIMIENTO.Where(a => a.Tipo == tipo).ToList();
				}
			}
			GridLista.DataSource = LISTA_MOVIMIENTO;
			CargarInfo();
		}
		private void CargarInfo()
		{
			var total_ingreso = LISTA_MOVIMIENTO.Where(a => a.Tipo == "I").Count();
			var total_egreso = LISTA_MOVIMIENTO.Where(a => a.Tipo == "E").Count();
			txtTotalIngresos.Caption = total_ingreso.ToString() ;
			txtTotalEgresos.Caption = total_egreso.ToString();
		}
		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				var tipo = gridView1.GetRowCellValue(e.RowHandle, "Tipo");
				if (tipo != null)
				{
					e.Appearance.ForeColor = Color.Black;
					switch (tipo.ToString())
					{
						case "E": // egresos
							e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
							break;
						case "I": // ingresos
							e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
							break;
					}
				}
			}
		}

		private void btnVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
		}

		

		private void chkTodo_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bool chk = chkTodo.Checked;
			if (chk)
			{
				dtDesde.Enabled = false;
				dtHasta.Enabled = false;
				cbTipo.Enabled = false;
			}else
			{
				dtDesde.Enabled = true;
				dtHasta.Enabled = true;
				cbTipo.Enabled = true;
			}
		}
	}
}