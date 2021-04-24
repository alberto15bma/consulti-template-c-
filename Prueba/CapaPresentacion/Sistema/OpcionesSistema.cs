using CapaPresentacion.Vista.Alertas;
using DevExpress.Export.Xl;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Sistema
{
	public static class OpcionesDeSistema
	{
		/// Encripta una cadena
		public static string Encriptar(this string cadena)
		{
			string result = string.Empty;
			byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadena);
			result = Convert.ToBase64String(encryted);
			return result;
		}

		/// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
		public static string DesEncriptar(this string cadena)
		{
			string result = string.Empty;
			byte[] decryted = Convert.FromBase64String(cadena);
			//result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
			result = System.Text.Encoding.Unicode.GetString(decryted);
			return result;
		}
		internal static void AgregarPaddingGrid(GridView grid)
		{
			grid.UserCellPadding = new Padding(7, 5, 7, 5);
		}

		internal static void Imprimir(GridControl grid)
		{
			if (!grid.IsPrintingAvailable)
			{
				MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
				return;
			}
			grid.Print();

		}
		internal static void ImprimirVistaPrevia(GridControl grid)
		{
			if (!grid.IsPrintingAvailable)
			{
				MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
				return;
			}
			grid.ShowRibbonPrintPreview();
		}
		public static byte[] GetImagenBase64(System.Drawing.Image imageIn)
		{
			MemoryStream ms = new MemoryStream();
			imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
			return ms.ToArray();
		}

		public static void IniciarAnimacion(string titulo, Form form)
		{
			try
			{
				//SplashScreenManager.ShowForm(typeof(SplashScreen1));
				SplashScreenManager.ShowForm(form, typeof(Cargando));
				SplashScreenManager.Default.SetWaitFormCaption(titulo);
				for (int i = 0; i < 20; i++)
				{
					System.Threading.Thread.Sleep(1);
				}
				//SplashScreenManager.CloseForm();
			}
			catch (Exception)
			{
			}

		}
		public static void FinalizarAnimacion()
		{
			try
			{
				//SplashScreenManager.ShowForm(this, typeof(Cargando));
				//SplashScreenManager.Default.SetWaitFormCaption("Analizando archivo y su contenido.");
				for (int i = 0; i < 20; i++)
				{
					System.Threading.Thread.Sleep(1);
				}
				SplashScreenManager.CloseForm();
			}
			catch (Exception)
			{
			}
		}

		public static bool ValidarCampos(LayoutControl Ctrl)
		{
			//if (Ctrl.HasChildren)
			//{
			int bandera = 0;
			foreach (Control ctrl in Ctrl.Controls)
			{
				if (ctrl is DevExpress.XtraEditors.TextEdit)
				{
					(ctrl as DevExpress.XtraEditors.TextEdit).ErrorText = "";
					(ctrl as DevExpress.XtraEditors.TextEdit).Refresh();
					var tag = ctrl.Tag;
					if (ctrl.Text == string.Empty && ctrl.Enabled == true && (ctrl.Tag == null || ctrl.Tag.ToString() == string.Empty))
					{
						(ctrl as DevExpress.XtraEditors.TextEdit).ErrorText = "Éste campo es obligatorio";
						bandera++;
						//(ctrl as DevExpress.XtraEditors.TextEdit).Focus();
					}
				}
			}
			if (bandera > 0)
			{
				return false;
			}
			return true;
		}

		public static void ExportarExcel(string tituloArchivo, GridControl grid, bool detalle = false)
		{
			FolderBrowserDialog fldDlg = new FolderBrowserDialog();
			fldDlg.Description = Mensajes.BUSCA_GUARDAR;

			try
			{
				if (fldDlg.ShowDialog() == DialogResult.OK)
				{
					var ruta = fldDlg.SelectedPath + "/" + tituloArchivo + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".xlsx";
					if (detalle)
						DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
					else
						DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

					grid.ExportToXlsx(ruta);
					var res = XtraMessageBox.Show("Se guardó el archivo correctamente.\n¿Deseas abrir el archivo?", Mensajes.Notificacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
						Process.Start(ruta);

					//log.BitacoraUsuario("EXPORTAR A EXCEL", "VISUALIZAR LOS DATOS EN UN ARCHIVO EXCEL", "PERSONAS ÁCTIVAS", "VISUALIZAR LOS DATOS EN UN ARCHIVO EXCEL");
				}
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(Mensajes.ERROR_ARCHIVO_EJECUCION, Mensajes.TituloError);
			}
		}
		public static void ExportarPDF(string tituloArchivo, GridControl grid)
		{
			FolderBrowserDialog fldDlg = new FolderBrowserDialog();
			fldDlg.Description = Mensajes.BUSCA_GUARDAR;
			try
			{
				if (fldDlg.ShowDialog() == DialogResult.OK)
				{
					var ruta = fldDlg.SelectedPath + "/" + tituloArchivo + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";
					grid.ExportToPdf(ruta);
					var res = XtraMessageBox.Show("Se guardó el archivo correctamente.\n¿Deseas abrir el archivo?", Mensajes.Notificacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
						Process.Start(ruta);
					//log.BitacoraUsuario("EXPORTAR A PDF", "VISUALIZAR LOS DATOS EN UN ARCHIVO PDF", "PERSONAS ÁCTIVAS", "VISUALIZAR LOS DATOS EN UN ARCHIVO PDF");
				}
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(Mensajes.ERROR_ARCHIVO_EJECUCION, Mensajes.TituloError);
			}
		}
		public static void CopiarGrilla(GridView view)
		{
			view.OptionsSelection.MultiSelect = true;
			view.SelectAll();
			view.CopyToClipboard();
			view.OptionsSelection.MultiSelect = false;
		}
		public static void ExportarCSV(string tituloArchivo, GridControl grid)
		{
			FolderBrowserDialog fldDlg = new FolderBrowserDialog();
			fldDlg.Description = Mensajes.BUSCA_GUARDAR;
			try
			{
				if (fldDlg.ShowDialog() == DialogResult.OK)
				{
					DevExpress.XtraPrinting.CsvExportOptionsEx opt = new DevExpress.XtraPrinting.CsvExportOptionsEx();
					opt.CustomizeCell += Options_CustomizeCell;
					//opt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

					//opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;
					//DevExpress.XtraPrinting.CsvExportOptions exportMode = new DevExpress.XtraPrinting.CsvExportOptions();
					//exportMode.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
					var ruta = fldDlg.SelectedPath + "/" + tituloArchivo + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".csv";
					grid.ExportToCsv(ruta, opt);
					var res = XtraMessageBox.Show("Se guardó el archivo correctamente.\n¿Deseas abrir el archivo?", Mensajes.Notificacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
						Process.Start(ruta);
					//log.BitacoraUsuario("EXPORTAR A PDF", "VISUALIZAR LOS DATOS EN UN ARCHIVO PDF", "PERSONAS ÁCTIVAS", "VISUALIZAR LOS DATOS EN UN ARCHIVO PDF");
				}
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(Mensajes.ERROR_ARCHIVO_EJECUCION, Mensajes.TituloError);
			}
		}

		public static void ExportarExcel2(string tituloArchivo, GridControl grid, bool detalle = false)
		{
			FolderBrowserDialog fldDlg = new FolderBrowserDialog();
			fldDlg.Description = Mensajes.BUSCA_GUARDAR;

			try
			{
				if (fldDlg.ShowDialog() == DialogResult.OK)
				{
					var ruta = fldDlg.SelectedPath + "/" + tituloArchivo + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".xlsx";
					if (detalle)
						DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
					else
						DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;
					DevExpress.XtraPrinting.XlsxExportOptionsEx opt = new DevExpress.XtraPrinting.XlsxExportOptionsEx();
					opt.CustomizeCell += Options_CustomizeCell;

					grid.ExportToXlsx(ruta, opt);
					var res = XtraMessageBox.Show("Se guardó el archivo correctamente.\n¿Deseas abrir el archivo?", Mensajes.Notificacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
						Process.Start(ruta);
				}
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(Mensajes.ERROR_ARCHIVO_EJECUCION, Mensajes.TituloError);
			}
		}

		private static void Options_CustomizeCell(DevExpress.Export.CustomizeCellEventArgs e)
		{
			if (e.ColumnFieldName == "Cedula" || e.ColumnFieldName == "Ocupacion")
			{
				e.Formatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment();
				e.Formatting.Alignment.HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Left;
				e.Formatting.NumberFormat = XlNumberFormat.Text;
				e.Formatting.FormatType = DevExpress.Utils.FormatType.Custom;
				e.Handled = true;
			}
		}

		public static string GetNombreMes(int mes)
		{
			// debugger;
			string[] meses = new string[] { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
			return meses[mes];
		}
	}
}
