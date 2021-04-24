using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocio.Logica;
using CapaDatos.Modelo;

namespace CapaPresentacion.Vista.Salida.Reportes
{
	public partial class VistaA4 : DevExpress.XtraEditors.XtraUserControl
	{
		public VistaA4()
		{
			InitializeComponent();
		}
		internal void GetReporte(ListaSalidas CABECERA, List<DetalleSalida> DETALLE)
		{
			rA4 report = new rA4();
			foreach (var item in report.Parameters)
				item.Visible = false;

			report.InitDatos(CABECERA, DETALLE);
			documentViewer1.DocumentSource = report;
			
			report.CreateDocument();


		}
	}
}
