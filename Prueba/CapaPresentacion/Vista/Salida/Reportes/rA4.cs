using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using CapaNegocio.Logica;
using CapaDatos.Modelo;
using System.Collections.Generic;

namespace CapaPresentacion.Vista.Salida.Reportes
{
	public partial class rA4 : DevExpress.XtraReports.UI.XtraReport
	{
		public rA4()
		{
			InitializeComponent();
		}

		internal void InitDatos(ListaSalidas CABECERA, List<DetalleSalida> DETALLE)
		{

			pCodigo.Value = CABECERA.CodigoIE;
			pFecha.Value = CABECERA.Fecha;
			pCedula.Value = CABECERA.Cedula;
			pCliente.Value = CABECERA.Cliente;
			pObservacion.Value = CABECERA.Comentario;
			pTotalItems.Value = DETALLE.Count;
			pUsuario.Value = CABECERA.Usuario;

			var det = new List<DetalleIE>();
			for (int i = 0; i < DETALLE.Count; i++)
			{
				var d = new DetalleIE();
				d.Cantidad = DETALLE[i].Cantidad;
				d.Codigo = DETALLE[i].producto.Codigo;
				d.CodigoEquipo = DETALLE[i].producto.Codigo.ToString("000000");
				d.Descripcion = DETALLE[i].producto.Descripcion;
				d.Estado = DETALLE[i].estado.Descripcion;
				det.Add(d);
			}

			objectDataSource1.DataSource = det;


			pNombreEmpresa.Value = "CONSUL.TI";
			pEslogan.Value = "Prueba práctica";
			pTelefonoRuc.Value = "RUC: 9999999999999 TELF: 0000000000";

			LblFirma.Visible = false;

			lblUsuario.Visible = false;
			lblUsuario2.Visible = false;
		}
	}
}
