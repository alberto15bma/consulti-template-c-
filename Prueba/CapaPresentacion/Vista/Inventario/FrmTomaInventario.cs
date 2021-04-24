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

namespace CapaPresentacion.Vista.Inventario
{
	public partial class FrmTomaInventario : DevExpress.XtraEditors.XtraForm
	{
		
		List<CapaDatos.Modelo.Estado> ESTADOS = new List<CapaDatos.Modelo.Estado>();
		List<ListaIngresoEgreso> LISTA_PRODUCTOS = new List<ListaIngresoEgreso>();
		BindingList<DetalleIngresoEgreso> DETALLE = new BindingList<DetalleIngresoEgreso>();
		public string TIPO;
		public Registro registro;
		public CapaDatos.Modelo.Inventario INVENTARIO;
		public int USUARIO;
		public FrmTomaInventario(Registro registro)
		{
			InitializeComponent();
			this.registro = registro;
			USUARIO = (int)Properties.Settings.Default["Usuario"];
			CargarData();
			CargarSecuencial();
			//CargarGrilla();
			AccionRegistro();
		}



		private void AccionRegistro()
		{
			if (registro.Id != 0 && registro.tipo == "Editar")
			{
				var sal = new ClsInventario();
				INVENTARIO = sal.GetInventario(registro.Id);
				CargarDetalleGuardado();

				txtCodigo.EditValue = INVENTARIO.Codigo.ToString("000000");
				cbConcepto.EditValue = INVENTARIO.ConceptoId;
				txtObservacion.EditValue = INVENTARIO.Observacion;
				dtFecha.EditValue = INVENTARIO.Fecha;
				
			}
			else
			{
				GuardarTemporal();
			}
		}

		private void CargarDetalleGuardado()
		{
			var sal = new ClsInventario();
			var detalle = sal.GetDetalleInventario(INVENTARIO.Id);

			//DETALLE.Clear();
			for (int i = 0; i < detalle.Count(); i++)
			{
				var ne = new DetalleIngresoEgreso();
				//ne.CodigoEquipo = $"{detalle[i].EquipoId}, {detalle[i].producto.Codigo}, {detalle[i].MarcaId}, {detalle[i].EstadoId}";
				ne.Cantidad = detalle[i].Cantidad;
				ne.Codigo = detalle[i].producto.Codigo;
				ne.CodigoEquipo = detalle[i].producto.Codigo.ToString("000000");
				
				ne.NombreEstado = detalle[i].estado.Descripcion;
				ne.Estado = detalle[i].EstadoId;
				ne.Stock = detalle[i].StockActual;
				ne.IdEquipo = detalle[i].ProductoId;

				var existe = DETALLE.FirstOrDefault(a => a.IdEquipo == ne.IdEquipo && a.Estado == ne.Estado);
				if (existe != null)
				{
					DETALLE.FirstOrDefault(a => a.IdEquipo == ne.IdEquipo && a.Estado == ne.Estado).Cantidad = ne.Cantidad;
				}
				else
				{
					DETALLE.Add(ne);
				}
			}
			gridView1.Focus();
			gridView1.FocusedColumn = Cantidad;
			gridView1.FocusedRowHandle = DETALLE.Count();
		}

		private void GuardarTemporal()
		{
			var inv = new CapaDatos.Modelo.Inventario();
			inv.Codigo = ClsInventario.GetSecuencial();
			inv.ConceptoId = Convert.ToInt32(cbConcepto.EditValue);
			inv.EstadoId = 3;
			inv.Fecha = Convert.ToDateTime(dtFecha.EditValue);
			inv.FechaModificacion = DateTime.Now;
			inv.Observacion = txtObservacion.EditValue == null ? "" : txtObservacion.EditValue.ToString();
			inv.UsuarioId = USUARIO;

			var inven = new ClsInventario();
			INVENTARIO = inven.GuardarTemporal(inv);
		}

		private void CargarGrilla()
		{
			DETALLE.Clear();
			GridLista.DataSource = null;
			GridLista.DataSource = DETALLE;
		}
		private void CargarSecuencial()
		{
			int secuencial = ClsInventario.GetSecuencial();
			txtCodigo.EditValue = secuencial.ToString("000000");
		}
		private void CargarData()
		{
			OpcionesCajasDeTexto.DisenoCombobox(cbEstados, false);
			OpcionesCajasDeTexto.DisenoCombobox(cbConcepto, false);
			
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
				CargarDetalleGuardado();
			}
		}

		private void CargarProductos()
		{
			CargarGrilla();
			var item = new ClsIngresoEgreso();
			LISTA_PRODUCTOS = item.GetListaEquipos();

			for (int i = 0; i < LISTA_PRODUCTOS.Count(); i++)
			{
				var ne = new DetalleIngresoEgreso();
				ne.Codigo = LISTA_PRODUCTOS[i].Codigo;
				ne.CodigoEquipo = LISTA_PRODUCTOS[i].Codigo.ToString("000000");
				ne.NombreEstado = LISTA_PRODUCTOS[i].Estado;
				ne.Estado = LISTA_PRODUCTOS[i].EstadoId;
				ne.Stock = LISTA_PRODUCTOS[i].Stock;
				ne.Descripcion = LISTA_PRODUCTOS[i].Descripcion;
				ne.IdEquipo = LISTA_PRODUCTOS[i].Id;
				DETALLE.Add(ne);
			}
			GridLista.DataSource = DETALLE;
		}
	
		private void CargarEstados()
		{
			ESTADOS = ClsEquipo.GetEstados();
			cbEstados.DataSource = ESTADOS;
		}
		private void CargarConceptos()
		{
			var lista = ClsIngresoEgreso.GetConceptos().Where(a=>a.Inventario == true).ToList();			
			cbConcepto.Properties.DataSource = lista;
			cbConcepto.EditValue = lista.FirstOrDefault().Id;
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
				if (DETALLE.Where(a=>a.Estado != 0).Count() > 0)
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
			var com = new CapaDatos.Modelo.Inventario();

			com.Codigo = Convert.ToInt32(txtCodigo.EditValue);
			com.Fecha = Convert.ToDateTime(dtFecha.EditValue);
			com.EstadoId = 1;
			com.ConceptoId = Convert.ToInt32(cbConcepto.EditValue);
			com.FechaModificacion = DateTime.Now;
			com.Observacion = txtObservacion.EditValue == null ? null : txtObservacion.EditValue.ToString();
			com.UsuarioId = USUARIO;
			com.Id = INVENTARIO.Id;
			var guardar = new ClsInventario();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				com.Id = registro.Id;
				guardar.CrearInventario(ref result, com, DETALLE);
				//com.FechaRegistro = usua.FechaRegistro;
				//com.EstadoId = usua.EstadoId;
				//	guardar.ModificarCompra(ref result, com, DETALLE);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				com.Codigo = ClsInventario.GetSecuencial();
				
				guardar.CrearInventario(ref result, com, DETALLE);
			}
			if (result.success == 1)
			{		
				var res = XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess, MessageBoxButtons.OK, MessageBoxIcon.Question);
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
			if (e.RowHandle > -1)
			{
				var row = gridView1.GetRow(e.RowHandle) as DetalleIngresoEgreso;
				GuardarDetalleTemporal(row);
			}
		}

		private void GuardarDetalleTemporal(DetalleIngresoEgreso row)
		{
			if (row.Estado != 0)
			{
				ClsInventario.GuardarDetalleTemporal(INVENTARIO, row);
			}		
		}

		private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
		{
			if (e.Value.ToString() == "")
			{
				e.Valid = false;
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

		private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			if (e.RowHandle > -1)
			{
				if (e.Column.Name == "Cantidad")
				{
					var cantidad = (int)gridView1.GetRowCellValue(e.RowHandle, Cantidad);
					var stock = (int)gridView1.GetRowCellValue(e.RowHandle, Stock);
					
					if (cantidad >= stock && cantidad > 0)
					{
						e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
						e.Appearance.ForeColor = Color.Green;
					}else
					{
						e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
						e.Appearance.ForeColor = Color.Red;
					}
				}
			}
		}

		private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			var row = gridView1.GetFocusedRow();
			int rowHandle = gridView1.FocusedRowHandle;
			var nueva = row as DetalleIngresoEgreso;
			gridView1.InitNewRow += (sen, a) => gridView1_InitNewRow(sen, a, nueva);
			gridView1.AddNewRow();
			//gridView1.RefreshData();
			//GridLista.RefreshDataSource();
			gridView1.FocusedRowHandle = rowHandle - 2;
			gridView1.FocusedRowHandle = rowHandle + 1;
		}
		private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e, DetalleIngresoEgreso row)
		{
			GridView view = sender as GridView;
			view.SetRowCellValue(e.RowHandle, "Codigo", row.Codigo);
			view.SetRowCellValue(e.RowHandle, "CodigoEquipo", row.CodigoEquipo);
			view.SetRowCellValue(e.RowHandle, "IdEquipo", row.IdEquipo);
			view.SetRowCellValue(e.RowHandle, "Descripcion", row.Descripcion);
		}
	}
}