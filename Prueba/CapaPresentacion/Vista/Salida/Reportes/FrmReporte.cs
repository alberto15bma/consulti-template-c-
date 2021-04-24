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
using CapaDatos.Modelo;

namespace CapaPresentacion.Vista.Salida.Reportes
{
	public partial class FrmReporte : DevExpress.XtraEditors.XtraForm
	{
		public int ID;
		ListaSalidas CABECERA = new ListaSalidas();
		List<DetalleSalida> DETALLE = new List<DetalleSalida>();
		public FrmReporte(int id)
		{
			InitializeComponent();
			ID = id;
			CargarData();
		}

		private void CargarData()
		{
			var mov = new ClsSalida();
			CABECERA = mov.GetSalidas().FirstOrDefault(a => a.Id == ID);
			DETALLE = mov.GetDetalleSalida(ID);
			
			CargarA4();

		}

		private void CargarA4()
		{
			VistaA4 xreporte = new VistaA4();

			split.Panel1.Controls.Clear();
			xreporte.GetReporte(CABECERA, DETALLE);
			xreporte.Width = split.Panel1.Width;
			xreporte.Height = split.Panel1.Height;
			xreporte.Dock = DockStyle.Fill;
			split.Panel1.Controls.Add(xreporte);

			split.Panel1.Tag = xreporte;
			xreporte.Show();

		}
		
	}
}