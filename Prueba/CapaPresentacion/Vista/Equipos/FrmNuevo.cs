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
	public partial class FrmNuevo : DevExpress.XtraEditors.XtraForm
	{
		public Registro registro;
		private CapaDatos.Modelo.Producto usua = null;
		public FrmNuevo(Registro registro)
		{
			InitializeComponent();
			this.registro = registro;
			LLenarCombobox();
			CargarSecuencial();
			AccionRegistro();
		}
		private void AccionRegistro()
		{
			if (registro.tipo.ToString() == "Editar" && registro.Id != 0)
				Editar(registro.Id);
		}
		private void Editar(int Id)
		{
			var item = new ClsEquipo();
			var lista = item.GetProducto(Convert.ToInt32(Id));
			usua = lista;
			Text = "Modificación de Equipo";
			btnGuardar.Text = "Modificar";
			if (lista != null)
			{
				txtCodigo.EditValue = lista.Codigo.ToString("000000");
				txtCodBarras.EditValue = lista.CodigoBarras;
				cbUbicacion.EditValue = lista.UbicacionId;
				cbEstado.EditValue = lista.Estado == true ? "ACTIVO" : "INACTIVO";
				Foto.EditValue = lista.Foto;
				txtDescripcion.EditValue = lista.Descripcion;
				txtStockMin.EditValue = lista.StockMin;
				txtStockMax.EditValue = lista.StockMax;
			}
		}
		private void CargarSecuencial()
		{
			int secuencial = ClsEquipo.GetSecuencial();
			txtCodigo.EditValue = secuencial.ToString("000000");
		}

		private void LLenarCombobox()
		{
			var eq = new ClsEquipo();
			var lista = eq.GetProductos();

			cbUbicacion.Properties.DataSource = ClsEquipo.GetUbicacion();
			OpcionesCajasDeTexto.DisenoCombobox(cbUbicacion, false);
			cbEstado.EditValue = "ACTIVO";
		}


		
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			Guardar();
		}
		private void Guardar()
		{
			if (Sistema.OpcionesDeSistema.ValidarCampos(layoutControl1))
				EnviarFormulario();
			else
				XtraMessageBox.Show(Mensajes.VALIDAR_CAMPOS, Mensajes.Advertencia);
		}
		private void EnviarFormulario()
		{
			var eq = new CapaDatos.Modelo.Producto();

			
			eq.CodigoBarras = txtCodBarras.EditValue != null ? txtCodBarras.EditValue.ToString() : null;
		
			eq.UbicacionId = Convert.ToInt32(cbUbicacion.EditValue);
			eq.Estado = cbEstado.EditValue.ToString() == "ACTIVO" ? true : false;
			if (Foto.Image != null)
			{
				byte[] foto = OpcionesDeSistema.GetImagenBase64(Foto.Image);
				eq.Foto = foto;
			}	
			eq.StockMin = Convert.ToInt32(txtStockMin.EditValue);
			eq.StockMax = Convert.ToInt32(txtStockMax.EditValue);
			eq.FechaModificacion = DateTime.Now;
			eq.Descripcion = Convert.ToString(txtDescripcion.EditValue);
			var guardar = new ClsEquipo();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				eq.Id = usua.Id;
				eq.FechaCreacion = usua.FechaCreacion;
				eq.Codigo = usua.Codigo;
				guardar.ModificarProducto(ref result, eq);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				eq.Codigo = ClsEquipo.GetSecuencial();
				eq.FechaCreacion = DateTime.Now;
				guardar.CrearProducto(ref result, eq);
			}
			if (result.success == 1)
			{
				if (registro.tipo == "Editar" && registro.Id != 0)
				{
					XtraMessageBox.Show(Mensajes.MODIFICACION_SUCCESS, Mensajes.TituloSuccess);
				}
				else
				{
					XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess);
				}
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				XtraMessageBox.Show("Ocurrió un error al guardar los datos.\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}