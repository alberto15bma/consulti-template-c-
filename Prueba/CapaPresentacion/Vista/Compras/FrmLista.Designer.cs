namespace CapaPresentacion.Vista.Compras
{
	partial class FrmLista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
			this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
			this.btnAnular = new DevExpress.XtraBars.BarButtonItem();
			this.btnArchivar = new DevExpress.XtraBars.BarButtonItem();
			this.txtTotalProcesadas = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtTotalArchivadas = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtTotalAnuladas = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CodigoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Factura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNuevo,
            this.btnCargar,
            this.btnAnular,
            this.btnArchivar,
            this.txtTotalProcesadas,
            this.txtTotalArchivadas,
            this.txtTotalAnuladas});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 10;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowQatLocationSelector = false;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(762, 58);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Caption = "Nuevo";
			this.btnNuevo.Id = 1;
			this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
			this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
			// 
			// btnCargar
			// 
			this.btnCargar.Caption = "Cargar";
			this.btnCargar.Id = 2;
			this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
			this.btnCargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.LargeImage")));
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
			// 
			// btnAnular
			// 
			this.btnAnular.Caption = "Anular";
			this.btnAnular.Enabled = false;
			this.btnAnular.Id = 3;
			this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
			this.btnAnular.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.LargeImage")));
			this.btnAnular.Name = "btnAnular";
			// 
			// btnArchivar
			// 
			this.btnArchivar.Caption = "Archivar";
			this.btnArchivar.Enabled = false;
			this.btnArchivar.Id = 4;
			this.btnArchivar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivar.ImageOptions.Image")));
			this.btnArchivar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArchivar.ImageOptions.LargeImage")));
			this.btnArchivar.Name = "btnArchivar";
			this.btnArchivar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnArchivar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArchivar_ItemClick);
			// 
			// txtTotalProcesadas
			// 
			this.txtTotalProcesadas.Caption = "Total procesadas:";
			this.txtTotalProcesadas.Edit = this.repositoryItemTextEdit1;
			this.txtTotalProcesadas.EditValue = "0";
			this.txtTotalProcesadas.Enabled = false;
			this.txtTotalProcesadas.Id = 5;
			this.txtTotalProcesadas.Name = "txtTotalProcesadas";
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AllowFocused = false;
			this.repositoryItemTextEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.repositoryItemTextEdit1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.repositoryItemTextEdit1.Appearance.Options.UseBackColor = true;
			this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
			this.repositoryItemTextEdit1.Appearance.Options.UseForeColor = true;
			this.repositoryItemTextEdit1.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit1.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.repositoryItemTextEdit1.AppearanceDisabled.Options.UseBackColor = true;
			this.repositoryItemTextEdit1.AppearanceDisabled.Options.UseForeColor = true;
			this.repositoryItemTextEdit1.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit1.AppearanceFocused.Options.UseBackColor = true;
			this.repositoryItemTextEdit1.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit1.AppearanceReadOnly.Options.UseBackColor = true;
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			this.repositoryItemTextEdit1.ReadOnly = true;
			// 
			// txtTotalArchivadas
			// 
			this.txtTotalArchivadas.Caption = "Total archivadas:";
			this.txtTotalArchivadas.Edit = this.repositoryItemTextEdit2;
			this.txtTotalArchivadas.EditValue = "0";
			this.txtTotalArchivadas.Enabled = false;
			this.txtTotalArchivadas.Id = 7;
			this.txtTotalArchivadas.Name = "txtTotalArchivadas";
			// 
			// repositoryItemTextEdit2
			// 
			this.repositoryItemTextEdit2.AllowFocused = false;
			this.repositoryItemTextEdit2.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.repositoryItemTextEdit2.Appearance.ForeColor = System.Drawing.Color.Green;
			this.repositoryItemTextEdit2.Appearance.Options.UseBackColor = true;
			this.repositoryItemTextEdit2.Appearance.Options.UseFont = true;
			this.repositoryItemTextEdit2.Appearance.Options.UseForeColor = true;
			this.repositoryItemTextEdit2.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit2.AppearanceDisabled.Options.UseBackColor = true;
			this.repositoryItemTextEdit2.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit2.AppearanceFocused.Options.UseBackColor = true;
			this.repositoryItemTextEdit2.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit2.AppearanceReadOnly.Options.UseBackColor = true;
			this.repositoryItemTextEdit2.AutoHeight = false;
			this.repositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
			this.repositoryItemTextEdit2.ReadOnly = true;
			// 
			// txtTotalAnuladas
			// 
			this.txtTotalAnuladas.Caption = "Total anuladas:";
			this.txtTotalAnuladas.Edit = this.repositoryItemTextEdit3;
			this.txtTotalAnuladas.EditValue = "0";
			this.txtTotalAnuladas.Enabled = false;
			this.txtTotalAnuladas.Id = 8;
			this.txtTotalAnuladas.Name = "txtTotalAnuladas";
			// 
			// repositoryItemTextEdit3
			// 
			this.repositoryItemTextEdit3.AllowFocused = false;
			this.repositoryItemTextEdit3.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.repositoryItemTextEdit3.Appearance.ForeColor = System.Drawing.Color.Red;
			this.repositoryItemTextEdit3.Appearance.Options.UseBackColor = true;
			this.repositoryItemTextEdit3.Appearance.Options.UseFont = true;
			this.repositoryItemTextEdit3.Appearance.Options.UseForeColor = true;
			this.repositoryItemTextEdit3.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit3.AppearanceDisabled.Options.UseBackColor = true;
			this.repositoryItemTextEdit3.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit3.AppearanceFocused.Options.UseBackColor = true;
			this.repositoryItemTextEdit3.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemTextEdit3.AppearanceReadOnly.Options.UseBackColor = true;
			this.repositoryItemTextEdit3.AutoHeight = false;
			this.repositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
			this.repositoryItemTextEdit3.ReadOnly = true;
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "ribbonPage1";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNuevo);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCargar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAnular);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnArchivar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalProcesadas);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalArchivadas);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalAnuladas);
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 361);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(762, 31);
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "ribbonPage2";
			// 
			// GridLista
			// 
			this.GridLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridLista.Location = new System.Drawing.Point(0, 58);
			this.GridLista.MainView = this.gridView1;
			this.GridLista.MenuManager = this.ribbonControl1;
			this.GridLista.Name = "GridLista";
			this.GridLista.Size = new System.Drawing.Size(762, 303);
			this.GridLista.TabIndex = 4;
			this.GridLista.UseEmbeddedNavigator = true;
			this.GridLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.ColumnPanelRowHeight = 25;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoCompra,
            this.FechaFactura,
            this.Proveedor,
            this.Factura,
            this.Estado,
            this.Id,
            this.Observacion,
            this.TotalItem});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 25;
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// CodigoCompra
			// 
			this.CodigoCompra.Caption = "Código";
			this.CodigoCompra.FieldName = "CodigoCompra";
			this.CodigoCompra.MaxWidth = 70;
			this.CodigoCompra.MinWidth = 70;
			this.CodigoCompra.Name = "CodigoCompra";
			this.CodigoCompra.Visible = true;
			this.CodigoCompra.VisibleIndex = 0;
			this.CodigoCompra.Width = 70;
			// 
			// FechaFactura
			// 
			this.FechaFactura.Caption = "Fecha";
			this.FechaFactura.FieldName = "FechaFactura";
			this.FechaFactura.MaxWidth = 95;
			this.FechaFactura.MinWidth = 95;
			this.FechaFactura.Name = "FechaFactura";
			this.FechaFactura.Visible = true;
			this.FechaFactura.VisibleIndex = 1;
			this.FechaFactura.Width = 95;
			// 
			// Proveedor
			// 
			this.Proveedor.Caption = "Proveedor";
			this.Proveedor.FieldName = "Proveedor";
			this.Proveedor.MinWidth = 160;
			this.Proveedor.Name = "Proveedor";
			this.Proveedor.Visible = true;
			this.Proveedor.VisibleIndex = 2;
			this.Proveedor.Width = 307;
			// 
			// Factura
			// 
			this.Factura.Caption = "N° factura";
			this.Factura.FieldName = "Factura";
			this.Factura.MaxWidth = 80;
			this.Factura.MinWidth = 80;
			this.Factura.Name = "Factura";
			this.Factura.Visible = true;
			this.Factura.VisibleIndex = 3;
			this.Factura.Width = 80;
			// 
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "Estado";
			this.Estado.MaxWidth = 80;
			this.Estado.MinWidth = 80;
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 6;
			this.Estado.Width = 80;
			// 
			// Id
			// 
			this.Id.Caption = "Id";
			this.Id.FieldName = "Id";
			this.Id.Name = "Id";
			// 
			// Observacion
			// 
			this.Observacion.Caption = "Observación";
			this.Observacion.FieldName = "Observacion";
			this.Observacion.MaxWidth = 150;
			this.Observacion.MinWidth = 140;
			this.Observacion.Name = "Observacion";
			this.Observacion.Visible = true;
			this.Observacion.VisibleIndex = 4;
			this.Observacion.Width = 140;
			// 
			// TotalItem
			// 
			this.TotalItem.Caption = "T. Items";
			this.TotalItem.FieldName = "TotalItem";
			this.TotalItem.MaxWidth = 60;
			this.TotalItem.MinWidth = 60;
			this.TotalItem.Name = "TotalItem";
			this.TotalItem.Visible = true;
			this.TotalItem.VisibleIndex = 5;
			this.TotalItem.Width = 60;
			// 
			// FrmLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 392);
			this.Controls.Add(this.GridLista);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLista";
			this.Ribbon = this.ribbonControl1;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Compras";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.BarButtonItem btnNuevo;
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraBars.BarButtonItem btnAnular;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn FechaFactura;
		private DevExpress.XtraGrid.Columns.GridColumn Factura;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoCompra;
		private DevExpress.XtraGrid.Columns.GridColumn Proveedor;
		private DevExpress.XtraGrid.Columns.GridColumn Estado;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraBars.BarButtonItem btnArchivar;
		private DevExpress.XtraGrid.Columns.GridColumn Observacion;
		private DevExpress.XtraGrid.Columns.GridColumn TotalItem;
		private DevExpress.XtraBars.BarEditItem txtTotalProcesadas;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraBars.BarEditItem txtTotalArchivadas;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
		private DevExpress.XtraBars.BarEditItem txtTotalAnuladas;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
	}
}