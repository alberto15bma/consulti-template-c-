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

namespace CapaPresentacion.Vista.IngresoEgreso
{
	public partial class FrmNuevoIngreso : DevExpress.XtraEditors.XtraForm
	{
		List<CapaDatos.Modelo.Estado> ESTADOS = new List<CapaDatos.Modelo.Estado>();
		List<ListaIngresoEgreso> LISTA_PRODUCTOS = new List<ListaIngresoEgreso>();
		BindingList<DetalleIngresoEgreso> DETALLE = new BindingList<DetalleIngresoEgreso>();
		public string TIPO;
		public Registro registro;
		public int USUARIO;
		public FrmNuevoIngreso(string tipo, Registro registro)
		{
			InitializeComponent();
			TIPO = tipo;
			this.registro = registro;
			USUARIO = (int)Properties.Settings.Default["Usuario"];
			CargarData();
			CargarSecuencial();
			CargarGrilla();
		}
		private void CargarGrilla()
		{
			GridLista.DataSource = null;
			GridLista.DataSource = DETALLE;
		}
		private void CargarSecuencial()
		{
			int secuencial = ClsMovimientoIE.GetSecuencial();
			txtCodigo.EditValue = secuencial.ToString("000000");
		}
		private void CargarData()
		{
			OpcionesCajasDeTexto.DisenoCombobox(cbEstados, false);
			OpcionesCajasDeTexto.DisenoCombobox(cbConcepto, false);
			if (TIPO == "I")
			{
				this.Text = "Nuevo ingreso";
				
			}
			else
			{
				btnCrearEstado.Enabled = false;
				
				btnCrearProducto.Enabled = false;
				Estado.OptionsColumn.AllowEdit = false;
				Estado.OptionsColumn.AllowFocus = false;
				this.Text = "Nuevo egreso";
			}
			dtFecha.EditValue = DateTime.Now;
			CargarConceptos();
			CargarProductos();
			CargarEstados();
		}

		private void txtFactura_Properties_Leave(object sender, EventArgs e)
		{

		}
		private void FrmNuevo_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					if(TIPO == "I")
						CrearProducto();
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
	
		private void CargarProductos()
		{
			var item = new ClsIngresoEgreso();
			LISTA_PRODUCTOS = item.GetListaEquipos();
			if (TIPO == "I")
			{
				
			} else {
				LISTA_PRODUCTOS = LISTA_PRODUCTOS.Where(a => a.Stock > 0).ToList();
			}
			cbProducto.DataSource = LISTA_PRODUCTOS;
		}

		private void CargarEstados()
		{
			ESTADOS = ClsEquipo.GetEstados();
			cbEstados.DataSource = ESTADOS;
		}
		private void CargarConceptos()
		{
			var lista = ClsIngresoEgreso.GetConceptos().Where(a => a.Inventario == false).ToList(); 
			if (TIPO == "I")
			{
				lista = lista.Where(a => a.Tipo == "I").ToList();
				cbConcepto.EditValue = 1;
			}else
			{
				lista = lista.Where(a => a.Tipo == "E").ToList();
				cbConcepto.EditValue = 2;
			}
			cbConcepto.Properties.DataSource = lista;
		}

		private void btnCrearProducto_Click(object sender, EventArgs e)
		{
			CrearProducto();
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
					var accion = XtraMessageBox.Show(Mensajes.PREGUNTAR_GUARDAR, Mensajes.Advertencia, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (accion == DialogResult.Yes)
					{
						EnviarFormulario();
					}		
				}
				else
				{
					XtraMessageBox.Show(Mensajes.SIN_FILAS_GRID, Mensajes.Advertencia);
					gridView1.Focus();
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
			var com = new CapaDatos.Modelo.MovimientoIE();

			com.Codigo = Convert.ToInt32(txtCodigo.EditValue);
			com.Fecha = Convert.ToDateTime(dtFecha.EditValue);
			com.Tipo = TIPO;
			com.ConceptoId = Convert.ToInt32(cbConcepto.EditValue);
			com.FechaModificacion = DateTime.Now;
			com.Observacion = txtObservacion.EditValue == null ? null : txtObservacion.EditValue.ToString();
			com.UsuarioId = USUARIO;
			var guardar = new ClsMovimientoIE();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				//com.Id = usua.Id;
				//com.FechaRegistro = usua.FechaRegistro;
				//com.EstadoId = usua.EstadoId;
				//	guardar.ModificarCompra(ref result, com, DETALLE);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				com.Codigo = ClsMovimientoIE.GetSecuencial();
				guardar.CrearMovimiento(ref result, com, DETALLE);
			}
			if (result.success == 1)
			{		
				XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				XtraMessageBox.Show("Ocurrió un error al guardar los datos.\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
			}
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
				int stock = (int)gridView1.GetRowCellValue(e.RowHandle, Stock);
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
				if (TIPO == "E")
				{
					if (valor > stock)
					{
						gridView1.SetColumnError(Cantidad, "La cantidad que ingresaste no puede ser mayor al stock");
						gridView1.SetColumnError(null, "Cantidad inválida");
						gridView1.FocusedColumn = e.Column;
						gridView1.ShowEditor();
						gridView1.ActiveEditor.Show();
						gridView1.SetRowCellValue(e.RowHandle, Cantidad,0);
					}
					else
					{
						gridView1.ClearColumnErrors();
					}
				}
			}
		}
		private void BuscarProducto(int rowHandle, string row)
		{
			var eq = row.Split(',');
			int id = Convert.ToInt32(eq[0]);
			int codigo = Convert.ToInt32(eq[1]);
			int estado = Convert.ToInt32(eq[2]);
			//var producto = cbProducto.GetRowByKeyValue(codigo) as ListaIngresoEgreso;
			var producto = LISTA_PRODUCTOS.FirstOrDefault(a=>a.Id == id && a.Codigo == codigo && a.EstadoId == estado);
			if (producto != null)
			{
				var existe = DETALLE.Where(a => a.IdEquipo == producto.Id && a.Estado == producto.EstadoId).ToList();
				
					if (existe.Count() <= 0)
					{
						gridView1.SetRowCellValue(rowHandle, Descripcion, producto.Descripcion);
						gridView1.SetRowCellValue(rowHandle, IdEquipo, producto.Id);
						gridView1.SetRowCellValue(rowHandle, Estado, producto.EstadoId);
						gridView1.SetRowCellValue(rowHandle, Stock, producto.Stock);
				}
					else
					{
						XtraMessageBox.Show(Mensajes.ERROR_EXISTE_PRODUCTO, Mensajes.TituloError, MessageBoxButtons.OK, MessageBoxIcon.Information);
						SendKeys.SendWait("{ESC}");
						SendKeys.SendWait("{ESC}");
						gridView1.AddNewRow();
					}
			}
			else
			{
				gridView1.SetRowCellValue(rowHandle, Descripcion, null);
				gridView1.SetRowCellValue(rowHandle, IdEquipo, 0);
				gridView1.SetRowCellValue(rowHandle, Stock, null);
				gridView1.SetRowCellValue(rowHandle, CodigoEquipo, null);
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
				var estado = (int)gridView1.GetRowCellValue(rowHandle, Estado);
				if (estado <= 0)
				{
					gridView1.FocusedColumn = Estado;
				}
				else
				{
					var cantidad = (int)gridView1.GetRowCellValue(rowHandle, Cantidad);
					var stock = (int)gridView1.GetRowCellValue(rowHandle, Stock);
					if (cantidad <= 0)
					{
						gridView1.FocusedColumn = Cantidad;
					}
					else
					{
						if (TIPO == "E")
						{
							if (cantidad > stock)
							{
								gridView1.FocusedColumn = Cantidad;
							}
						}
					}
				}
			}
		}
		private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			var row = e.Row as DetalleIngresoEgreso;
			if (row.CodigoEquipo == null || row.Descripcion == null || row.Estado == 0 || row.Cantidad <= 0)
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
			if (View.FocusedColumn == Estado)
			{
				LookUpEdit editor = View.ActiveEditor as LookUpEdit;
				editor.ShowPopup();
			}
		}

		private void btnEliminarFila_Click(object sender, EventArgs e)
		{
			EliminarFila();
		}

		private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
		{
			if (gridView1.IsRowSelected(gridView1.FocusedRowHandle))
			{
				//var existe = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Stock");
				//if (existe)
				//	e.Cancel = true;
				//else
				//	e.Cancel = false;
			}
		}

		private void btnCrearEstado_Click(object sender, EventArgs e)
		{

		}
	}
}