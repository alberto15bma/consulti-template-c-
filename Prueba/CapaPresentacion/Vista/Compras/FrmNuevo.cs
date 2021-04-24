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
using DevExpress.XtraGrid.Views.Grid;

namespace CapaPresentacion.Vista.Compras
{
	public partial class FrmNuevo : DevExpress.XtraEditors.XtraForm
	{
		public Registro registro;
		BindingList<ListaDetalleCompras> DETALLE = new BindingList<ListaDetalleCompras>();
		private CapaDatos.Modelo.Compras usua = null;
		public int USUARIO;
		public FrmNuevo(Registro registro)
		{
			InitializeComponent();
			this.registro = registro;
			USUARIO = (int)Properties.Settings.Default["Usuario"];
			CargarData();
			CargarGrilla();
			CargarSecuencial();
			cbProveedor.Focus();
		}

		private void CargarSecuencial()
		{
			int secuencial = ClsCompras.GetSecuencial();
			txtCodigo.EditValue = secuencial.ToString("000000");
		}
		private void CargarGrilla()
		{
			GridLista.DataSource = null;
			GridLista.DataSource = DETALLE;
		}

		private void CargarData()
		{	
			OpcionesCajasDeTexto.DisenoCombobox(cbProveedor, true);
			dtFecha.EditValue = DateTime.Now;
			CargarProductos();
			CargarProveedores();
		}

		private void CargarProveedores()
		{
			var user = new ClsUsuario();
			var lista = user.GetUsuarios().Where(a => a.TipoUsuarioId == 2).ToList();
			for (int i = 0; i < lista.Count(); i++)
			{
				lista[i].Nombres = lista[i].Nombres + $" ({lista[i].RazonSocial})";
			}
			cbProveedor.Properties.DataSource = lista;
		}


		private void CargarProductos()
		{
			var item = new ClsEquipo();
			var lista = item.GetProductos().Where(a=>a.Estado == true).ToList();
			cbProducto.DataSource = lista;
		}

		private void cbProveedor_EditValueChanged(object sender, EventArgs e)
		{
			txtNombreProveedor.EditValue = null;
			var prov = cbProveedor.GetColumnValue("Nombres");
			txtNombreProveedor.EditValue = prov;
		}

		private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			if (e.Column.Name == "CodigoEquipo")
			{
				var codigo = e.Value.ToString();
				BuscarProducto(e.RowHandle, codigo);
			}
			if (e.Column.Name == "Cantidad")
			{
				var valor = (int)e.Value;
				if (valor < 0)
					gridView1.SetRowCellValue(e.RowHandle, Cantidad, Math.Abs(valor));
	
				if (valor == 0)
				{
					gridView1.SetColumnError(Cantidad, "La cantidad que ingresaste no puede ser 0");
					gridView1.SetColumnError(null, "Cantidad inválida");
					gridView1.FocusedColumn = e.Column;
					gridView1.ShowEditor();
					gridView1.ActiveEditor.Show();
				}
				else
				{
					gridView1.ClearColumnErrors();
				}
			}
		}
		private void BuscarProducto(int rowHandle, string codigo)
		{
			var producto = cbProducto.GetRowByKeyValue(codigo) as ListaProducto;
			if (producto != null)
			{
				var existe = DETALLE.Where(a => a.IdEquipo == producto.Id).ToList();
				//if (existe.Count() <= 1)
				//{
					gridView1.SetRowCellValue(rowHandle, Descripcion, producto.Descripcion);
					gridView1.SetRowCellValue(rowHandle, IdEquipo, producto.Id);
				//}
				//else
				//{
					//XtraMessageBox.Show(Mensajes.ERROR_EXISTE_PRODUCTO, Mensajes.NOTIFICACION, MessageBoxButtons.OK, MessageBoxIcon.Information);
				//}
				
			}
			else
			{			
				gridView1.SetRowCellValue(rowHandle, Descripcion, null);
				gridView1.SetRowCellValue(rowHandle, IdEquipo, 0);
				gridView1.ShowEditor();
				
			}
		}
		private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
		{
			if (e.Value.ToString() == "")
			{
				e.Valid = false;
			}
		}
		private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
		{
			int rowHandle = gridView1.FocusedRowHandle;
			var codigo = gridView1.GetRowCellValue(rowHandle, CodigoEquipo);
			var descripcion = gridView1.GetRowCellValue(rowHandle, Descripcion);
			if (codigo == null || descripcion == null)
			{
				gridView1.FocusedColumn = CodigoEquipo;
				gridView1.ShowEditor();
			}
			else
			{

				var cantidad = (int)gridView1.GetRowCellValue(rowHandle, Cantidad);
				if (cantidad <= 0)
				{
					gridView1.FocusedColumn = Cantidad;
				}
			}
		}
		private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			var row = e.Row as ListaDetalleCompras;
			if (row.CodigoEquipo == null || row.Descripcion == null || row.Cantidad <= 0)
			{
				e.Valid = false;
				e.ErrorText = "No se encontró el artículo.\n";
			}
		}
		private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
		{
			e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
		}

		private void gridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
		{
			e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
		}
		private void gridView1_ShownEditor(object sender, EventArgs e)
		{
			GridView View = sender as GridView;
		}


		private void FrmNuevo_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					CrearProducto();
					break;
				case Keys.F3:
					CrearProveedor();
					break;
				case Keys.Delete:
					EliminarFila();
					break;
			}		
		}

		private void EliminarFila()
		{
			var rowHandle = gridView1.FocusedRowHandle;
			gridView1.DeleteRow(rowHandle);
		}

		private void btnEliminarFila_Click(object sender, EventArgs e)
		{
			EliminarFila();
		}

		private void btnCrearProducto_Click(object sender, EventArgs e)
		{
			CrearProducto();
		}

		private void CrearProducto()
		{

			var reg = new CapaNegocio.Logica.Registro();
			reg.tipo = "Nuevo";
			var nuevo = new Vista.Equipos.FrmNuevo(reg);
			var accion = nuevo.ShowDialog();
			if (accion == DialogResult.OK)
			{
				CargarProductos();
			}
		}


		private void btnCrearProveedor_Click(object sender, EventArgs e)
		{
			CrearProveedor();
		}

		private void CrearProveedor()
		{
			var reg = new CapaNegocio.Logica.Registro();
			reg.tipo = "Nuevo";
			var nuevo = new Vista.Proveedor.FrmNuevo(reg);
			var accion = nuevo.ShowDialog();
			if (accion == DialogResult.OK)
			{
				CargarProveedores();
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			Guardar();
		}
		private void Guardar()
		{
			if (Sistema.OpcionesDeSistema.ValidarCampos(layoutControl1))
			{
				if (DETALLE.Count() > 0)
				{
					EnviarFormulario();
				}else
				{
					XtraMessageBox.Show(Mensajes.SIN_FILAS_GRID, Mensajes.Advertencia);
				}			
			}			
			else
				XtraMessageBox.Show(Mensajes.VALIDAR_CAMPOS, Mensajes.Advertencia);
		}
		private void EnviarFormulario()
		{
			gridView1.CloseEditor();
			gridView1.RefreshData();
			GridLista.RefreshDataSource();
			var com = new CapaDatos.Modelo.Compras();

			com.Codigo = Convert.ToInt32(txtCodigo.EditValue);
			com.ProveedorId = Convert.ToInt32(cbProveedor.EditValue);
			com.Factura = txtFactura.EditValue.ToString();
			com.FechaFactura = dtFecha.DateTime;
			com.Observacion = txtObservacion.EditValue == null ? null : txtObservacion.EditValue.ToString();
			com.FechaModificacion = DateTime.Now;
			com.UsuarioId = USUARIO;
			var guardar = new ClsCompras();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				com.Id = usua.Id;
				com.FechaRegistro = usua.FechaRegistro;
				com.EstadoId = usua.EstadoId;
			//	guardar.ModificarCompra(ref result, com, DETALLE);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				com.Codigo = ClsCompras.GetSecuencial();
				com.FechaRegistro = DateTime.Now;
				com.EstadoId = 1;
				guardar.CrearCompra(ref result, com, DETALLE);
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

		private void txtFactura_Properties_Validating(object sender, CancelEventArgs e)
		{
			if (txtFactura.EditValue != null)
				ValidarExistenciaFactura();
		}

		private bool ValidarExistenciaFactura()
		{
			if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				ClsCompras item = new ClsCompras();
				var factura = txtFactura.EditValue.ToString();
				bool existe = item.ValidarExistenciaFactura(factura);
				if (existe)
				{
					XtraMessageBox.Show(Mensajes.EXISTENCIA_CEDULA, Mensajes.TituloError, MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtFactura.Focus();
					txtFactura.EditValue = null;
					return false;
				}
			}
			return true;
		}

		private void txtFactura_Properties_Leave(object sender, EventArgs e)
		{
			if (txtFactura.EditValue != null)
				ValidarExistenciaFactura();
		}
	}
}