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
	public partial class FrmArchivar : DevExpress.XtraEditors.XtraForm
	{
		public int ID_COMPRA;
		List<ListaDetalleCompras> detalle = new List<ListaDetalleCompras>();
		public FrmArchivar(int id_compra)
		{
			InitializeComponent();
			ID_COMPRA = id_compra;
			CargarData(false);
		}

		private void CargarData(bool imprimir)
		{
			var comp = new ClsCompras();
			var cab = comp.GetCompras().FirstOrDefault(a => a.Id == ID_COMPRA);
			detalle = comp.GetDetalleCompra(ID_COMPRA);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnImprimirArchivar_Click(object sender, EventArgs e)
		{
			Archivar(true);		
		}

		private void Archivar(bool imprimir)
		{
			var result = new OperacionResult();
			var mov = new ClsMovimiento();
			mov.ArchivarCompra(ref result, detalle);
			if (result.success == 1)
			{
				// Actualizar estado compra
				ClsCompras.ArchivarCompra(ID_COMPRA);
				if (imprimir)
					CargarData(true);

				XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess);
				this.Close();
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				XtraMessageBox.Show(Mensajes.ERROR_ARCHIVAR + "\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
			}
		}

		private void btnArchivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Archivar(false);
		}
	}
}