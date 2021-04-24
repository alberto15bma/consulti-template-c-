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

namespace CapaPresentacion.Vista.Salida
{
	public partial class FrmLista : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<ListaSalidas> LISTA_MOVIMIENTO = new List<ListaSalidas>();
		public FrmLista()
		{
			InitializeComponent();
			CargarData();
			Consultar();
			//CargarSalidas();
		}

		private void CargarSalidas()
		{
			var sal = new ClsSalida();
			LISTA_MOVIMIENTO = sal.GetSalidas();
			GridLista.DataSource = LISTA_MOVIMIENTO;
		}

		private void CargarData()
		{
			OpcionesCajasDeTexto.DisenoCombobox(cbTipo2, false);
			var ne = new CapaDatos.Modelo.EstadoSalida();
			ne.Descripcion = "TODO";
			ne.Id = 0;
			var lista = ClsSalida.GetEstados();
			lista.Add(ne);
			cbTipo2.DataSource = lista.OrderBy(a=>a.Id);
			cbTipo.EditValue = 0;
		}

		private void FrmLista_Load(object sender, EventArgs e)
		{

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

			var user = new ClsSalida();
			LISTA_MOVIMIENTO = user.GetSalidas();
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
				var tipo = Convert.ToInt32(cbTipo.EditValue);
				LISTA_MOVIMIENTO = LISTA_MOVIMIENTO.Where(a => a.Fecha >= desde && a.Fecha <= hasta).ToList();
				if (tipo != 0)
				{
					LISTA_MOVIMIENTO = LISTA_MOVIMIENTO.Where(a => a.EstadoId == tipo).ToList();
				}
			}
			GridLista.DataSource = LISTA_MOVIMIENTO;
			CargarInfo();
		}
		private void CargarInfo()
		{
			var total_archivada = LISTA_MOVIMIENTO.Where(a => a.EstadoId == 1).Count();
			var total_anuladas = LISTA_MOVIMIENTO.Where(a => a.EstadoId == 2).Count();
			var total_pendiente = LISTA_MOVIMIENTO.Where(a => a.EstadoId == 3).Count();
			txtTotalArchivadas.Caption = total_archivada.ToString() ;
			txtTotalAnuladas.Caption = total_anuladas.ToString();
			txtTotalPendiente.Caption = total_pendiente.ToString();
		}
		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				var estado = gridView1.GetRowCellValue(e.RowHandle, "EstadoId");
				if (estado != null)
				{
					
					switch ((int)estado)
					{
						case 1: // archivadas
							e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
							e.Appearance.ForeColor = Color.Black;
							break;
						case 2: // anuladas			
							e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
							e.Appearance.ForeColor = Color.Black;
							break;
					}
				}
			}
		}

		private void btnVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			VerMovimiento();
		}

		private void VerMovimiento()
		{
			var Id = gridView1.GetFocusedRowCellValue("Id");
			if (Id != null)
			{
				var report = new Reportes.FrmReporte((int)Id);
				report.ShowDialog();
			}
		}

		private void chkTodo_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bool chk = chkTodo.Checked;
			if (chk)
			{
				dtDesde.Enabled = false;
				dtHasta.Enabled = false;
				cbTipo2.Enabled = false;
				cbTipo.Enabled = false;
			}
			else
			{
				dtDesde.Enabled = true;
				dtHasta.Enabled = true;
				cbTipo2.Enabled = true;
				cbTipo.Enabled = true;
			}
		}

		private void btnContinuar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var Id = gridView1.GetFocusedRowCellValue("Id");
			if (Id != null)
			{
				var reg = new Registro();
				reg.tipo = "Editar";
				reg.Id = Convert.ToInt32(Id);
		
				var salida = new FrmSalida(reg);
				var res = salida.ShowDialog();
				if (res == DialogResult.OK)
				{
					CargarData();
				}
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle > -1)
			{
				HabilitarContinuar(e.FocusedRowHandle);
			}
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				HabilitarContinuar(e.RowHandle);
			}
		}
		private void HabilitarContinuar(int rowHandle)
		{
			var estado = gridView1.GetRowCellValue(rowHandle, "EstadoId");
			if (estado != null)
			{
				switch ((int)estado)
				{
					case 3:
						btnContinuar.Enabled = true;
						btnVer.Enabled = false;
						break;
					default:
						btnContinuar.Enabled = false;
						btnVer.Enabled = true;
						break;
				}
			}
		}
	}
}