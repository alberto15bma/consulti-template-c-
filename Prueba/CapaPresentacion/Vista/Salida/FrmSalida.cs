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
using DevExpress.XtraGrid.Views.Grid;
using CapaDatos.Modelo;

namespace CapaPresentacion.Vista.Salida
{
	public partial class FrmSalida : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<CapaDatos.Modelo.Estado> ESTADOS = new List<CapaDatos.Modelo.Estado>();
		List<ListaIngresoEgreso> LISTA_PRODUCTOS = new List<ListaIngresoEgreso>();
		List<ListaUsuarios> LISTA_USUARIOS = new List<ListaUsuarios>();
		BindingList<DetalleIngresoEgreso> DETALLE = new BindingList<DetalleIngresoEgreso>();
		public Registro registro;
		public int USUARIO;
		public FrmSalida(Registro registro)
		{
			InitializeComponent();
			this.registro = registro;
			USUARIO = (int)Properties.Settings.Default["Usuario"];
			CargarData();
			CargarGrilla();
			CargarSecuencial();
			AccionRegistro();
		}

		private void AccionRegistro()
		{
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				var sal = new ClsSalida();
				var cabecera = sal.GetSalida(registro.Id);
				var detalle = sal.GetDetalleSalida(registro.Id);
				txtCodigo.EditValue = cabecera.Codigo.ToString("000000");
				cbClientes.EditValue = cabecera.ClienteId;
				txtObservacion.EditValue = cabecera.Comentario;
				txtComentario2.EditValue = cabecera.ComentarioTicket;
				dtFecha.EditValue = cabecera.Fecha;
				txtNombre.EditValue = LISTA_USUARIOS.FirstOrDefault(a=>a.Id == cabecera.ClienteId).Nombres;

				DETALLE.Clear();
				for (int i = 0; i < detalle.Count(); i++)
				{
					var ne = new DetalleIngresoEgreso();
					ne.CodigoEquipo = $"{detalle[i].ProductoId}, {detalle[i].producto.Codigo}, {detalle[i].EstadoId}"; 
					ne.Cantidad = detalle[i].Cantidad;
					ne.Codigo = detalle[i].producto.Codigo;
					ne.NombreEstado = detalle[i].estado.Descripcion;
					ne.Estado = detalle[i].EstadoId;
					ne.Stock = detalle[i].StockActual;
					ne.IdEquipo = detalle[i].ProductoId;
					DETALLE.Add(ne);
				}
				gridView1.Focus();
				gridView1.FocusedColumn = Codigo;
				gridView1.FocusedRowHandle = DETALLE.Count();
				btnLista.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
				btnGuardarPendiente.Enabled = false;
			}
		}

		private void CargarGrilla()
		{
			GridLista.DataSource = null;
			GridLista.DataSource = DETALLE;
		}
		private void CargarSecuencial()
		{
			int secuencial = ClsSalida.GetSecuencial();
			txtCodigo.EditValue = secuencial.ToString("000000");
		}
		private void CargarData()
		{
			OpcionesCajasDeTexto.DisenoCombobox(cbClientes, true);		
			var user = Properties.Settings.Default["Nombres"].ToString();
			txtUsuario.Caption = user;
			dtFecha.EditValue = DateTime.Now;
			timer1.Start();
			CargarClientes();
			CargarProductos();
			CargarEstados();
			
		}

		private void CargarProductos()
		{
			var item = new ClsIngresoEgreso();
			LISTA_PRODUCTOS = item.GetListaEquipos();
			
			LISTA_PRODUCTOS = LISTA_PRODUCTOS.Where(a => a.Stock > 0).ToList();
			cbProducto.DataSource = LISTA_PRODUCTOS;
		}
		private void CargarEstados()
		{
			ESTADOS = ClsEquipo.GetEstados();
			cbEstados.DataSource = ESTADOS;
		}
		private void CargarClientes()
		{
			var user = new ClsUsuario();
			LISTA_USUARIOS = user.GetUsuarios().Where(a => a.TipoUsuarioId == 3).ToList();
			for (int i = 0; i < LISTA_USUARIOS.Count(); i++)
			{
				LISTA_USUARIOS[i].Nombres = LISTA_USUARIOS[i].Nombres + $" ({LISTA_USUARIOS[i].RazonSocial})";
			}
			cbClientes.Properties.DataSource = LISTA_USUARIOS;
		}
		private void chkTicket_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var chk = chkTicket.Checked;
			if (chk)
			{
				split.PanelVisibility = SplitPanelVisibility.Both;
			}else
			{
				split.PanelVisibility = SplitPanelVisibility.Panel1;
			}
		}

		private void dropDownButton1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Reloj();
		}

		private void Reloj()
		{
			string segundos = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second : DateTime.Now.Second.ToString();
			txtHora.Caption = DateTime.Now.ToShortTimeString() + ":" + segundos;
		}
		private void cbClientes_EditValueChanged(object sender, EventArgs e)
		{
			txtNombre.EditValue = null;
			var prov = cbClientes.GetColumnValue("Nombres");
			txtNombre.EditValue = prov;
			
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
				if (valor > stock)
				{
					gridView1.SetColumnError(Cantidad, "La cantidad que ingresaste no puede ser mayor al stock");
					gridView1.SetColumnError(null, "Cantidad inválida");
					gridView1.FocusedColumn = e.Column;
					gridView1.ShowEditor();
					gridView1.ActiveEditor.Show();
					gridView1.SetRowCellValue(e.RowHandle, Cantidad, 0);
				}
				else
				{
					gridView1.ClearColumnErrors();
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
			var producto = LISTA_PRODUCTOS.FirstOrDefault(a => a.Id == id && a.Codigo == codigo && a.EstadoId == estado);
			if (producto != null)
			{
				var existe = DETALLE.Where(a => a.IdEquipo == producto.Id && a.Estado == producto.EstadoId).ToList();
				if (existe.Count() <= 0)
				{
					gridView1.SetRowCellValue(rowHandle, Descripcion, producto.Descripcion);
					gridView1.SetRowCellValue(rowHandle, IdEquipo, producto.Id);		
					gridView1.SetRowCellValue(rowHandle, Estado, producto.EstadoId);
					gridView1.SetRowCellValue(rowHandle, Stock, producto.Stock);
					gridView1.SetRowCellValue(rowHandle, NombreEstado, producto.Estado);
					gridView1.SetRowCellValue(rowHandle, Codigo, producto.Codigo);
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
						if (cantidad > stock)
						{
							gridView1.FocusedColumn = Cantidad;
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

		private void btnEliminarFila_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			EliminarFila();
		}
		private void EliminarFila()
		{
			var rowHandle = gridView1.FocusedRowHandle;
			gridView1.DeleteRow(rowHandle);
		
		}

		private void FrmSalida_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
						CrearCliente();
					break;
				//case Keys.F3:
				//	CrearProveedor();
				//	break;
				case Keys.Delete:
					EliminarFila();
					break;
			}
		}

		private void CrearCliente()
		{
			var reg = new CapaNegocio.Logica.Registro();
			reg.tipo = "Nuevo";
			var nuevo = new Vista.Clientes.FrmNuevo(reg);
			var res = nuevo.ShowDialog();
			if (res == DialogResult.OK)
			{
				CargarClientes();
			}
		}

		private void btnCrearCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			CrearCliente();
		}

		private void txtObservacion_EditValueChanged(object sender, EventArgs e)
		{

		}
		private void Guardar(bool pendiente = false, bool imprimir = false)
		{
			if (Sistema.OpcionesDeSistema.ValidarCampos(layoutControl1))
			{
				if (DETALLE.Count() > 0)
				{
					var accion = XtraMessageBox.Show(Mensajes.PREGUNTAR_GUARDAR, Mensajes.Advertencia, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (accion == DialogResult.Yes)
					{
						GuardarSalida(pendiente, imprimir);
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

		private void GuardarSalida(bool pendiente, bool imprimir)
		{
			gridView1.CloseEditor();
			gridView1.RefreshData();
			GridLista.RefreshDataSource();
			var sa = new CapaDatos.Modelo.Salida();

			sa.Codigo = Convert.ToInt32(txtCodigo.EditValue);
			sa.Fecha = Convert.ToDateTime(dtFecha.EditValue);
			sa.FechaModificacion = DateTime.Now;
			sa.Comentario = txtObservacion.EditValue == null ? "" : txtObservacion.EditValue.ToString();
			sa.ComentarioTicket = txtComentario2.EditValue == null ? "" : txtComentario2.EditValue.ToString();
			
			sa.EstadoId = pendiente == true ? 3 : 1;
			
			sa.ClienteId = Convert.ToInt32(cbClientes.EditValue);
				
			sa.UsuarioId = USUARIO;
			var guardar = new ClsSalida();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				sa.Id = registro.Id;
				guardar.CrearSalida(ref result, sa, DETALLE, pendiente);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				sa.Codigo = ClsSalida.GetSecuencial();
				guardar.CrearSalida(ref result, sa, DETALLE, pendiente);
			}
			if (result.success == 1)
			{	
				XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess, MessageBoxButtons.OK, MessageBoxIcon.Question);
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				XtraMessageBox.Show("Ocurrió un error al guardar los datos.\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
			}
		}

		private void btnLista_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var lista = new FrmLista();
			lista.ShowDialog();
		}

		private void btnSoloGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Guardar();
		}

		private void btnGuardarImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Guardar(false, true);
		}

		private void btnGuardarPendiente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Guardar(true, true);
		}
	}
}