namespace CapaPresentacion.Vista.Inventario
{
	partial class FrmInventario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
			this.rFiltro = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotal = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.txtConStock = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
			this.txtSinStock = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotal2 = new DevExpress.XtraBars.BarStaticItem();
			this.txtConStock2 = new DevExpress.XtraBars.BarStaticItem();
			this.txtSinStock2 = new DevExpress.XtraBars.BarStaticItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnListaEquipos = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CodigoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.StockMin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.StockMax = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Stock = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnCargar,
            this.barButtonGroup1,
            this.rFiltro,
            this.barStaticItem1,
            this.txtTotal,
            this.barStaticItem2,
            this.txtConStock,
            this.barStaticItem3,
            this.txtSinStock,
            this.txtTotal2,
            this.txtConStock2,
            this.txtSinStock2,
            this.barSubItem1,
            this.barButtonItem1,
            this.btnListaEquipos});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 17;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.PageHeaderItemLinks.Add(this.txtTotal2);
			this.ribbonControl1.PageHeaderItemLinks.Add(this.txtConStock2);
			this.ribbonControl1.PageHeaderItemLinks.Add(this.txtSinStock2);
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(893, 58);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			// 
			// btnCargar
			// 
			this.btnCargar.Caption = "Cargar";
			this.btnCargar.Id = 1;
			this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
			// 
			// barButtonGroup1
			// 
			this.barButtonGroup1.Caption = "barButtonGroup1";
			this.barButtonGroup1.Id = 2;
			this.barButtonGroup1.Name = "barButtonGroup1";
			// 
			// rFiltro
			// 
			this.rFiltro.Edit = this.repositoryItemRadioGroup1;
			this.rFiltro.EditValue = "1";
			this.rFiltro.EditWidth = 203;
			this.rFiltro.Id = 3;
			this.rFiltro.Name = "rFiltro";
			// 
			// repositoryItemRadioGroup1
			// 
			this.repositoryItemRadioGroup1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemRadioGroup1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Todo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Con stock"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Sin stock")});
			this.repositoryItemRadioGroup1.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
			this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Caption = "Total:";
			this.barStaticItem1.Id = 4;
			this.barStaticItem1.Name = "barStaticItem1";
			// 
			// txtTotal
			// 
			this.txtTotal.Caption = "0";
			this.txtTotal.Id = 5;
			this.txtTotal.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotal.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotal.Name = "txtTotal";
			// 
			// barStaticItem2
			// 
			this.barStaticItem2.Caption = "Con stock:";
			this.barStaticItem2.Id = 7;
			this.barStaticItem2.Name = "barStaticItem2";
			// 
			// txtConStock
			// 
			this.txtConStock.Caption = "0";
			this.txtConStock.Id = 8;
			this.txtConStock.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtConStock.ItemAppearance.Normal.Options.UseFont = true;
			this.txtConStock.Name = "txtConStock";
			// 
			// barStaticItem3
			// 
			this.barStaticItem3.Caption = "Sin stock:";
			this.barStaticItem3.Id = 9;
			this.barStaticItem3.Name = "barStaticItem3";
			// 
			// txtSinStock
			// 
			this.txtSinStock.Caption = "0";
			this.txtSinStock.Id = 10;
			this.txtSinStock.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtSinStock.ItemAppearance.Normal.Options.UseFont = true;
			this.txtSinStock.Name = "txtSinStock";
			// 
			// txtTotal2
			// 
			this.txtTotal2.Caption = "0";
			this.txtTotal2.Id = 11;
			this.txtTotal2.Name = "txtTotal2";
			// 
			// txtConStock2
			// 
			this.txtConStock2.Caption = "0";
			this.txtConStock2.Id = 12;
			this.txtConStock2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("txtConStock2.ImageOptions.LargeImage")));
			this.txtConStock2.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.Red;
			this.txtConStock2.ItemInMenuAppearance.Normal.Options.UseBackColor = true;
			this.txtConStock2.Name = "txtConStock2";
			// 
			// txtSinStock2
			// 
			this.txtSinStock2.Caption = "0";
			this.txtSinStock2.Id = 13;
			this.txtSinStock2.Name = "txtSinStock2";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "Exportar";
			this.barSubItem1.Id = 14;
			this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
			this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Excel";
			this.barButtonItem1.Id = 15;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// btnListaEquipos
			// 
			this.btnListaEquipos.Caption = "Lista de productos";
			this.btnListaEquipos.Id = 16;
			this.btnListaEquipos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListaEquipos.ImageOptions.Image")));
			this.btnListaEquipos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnListaEquipos.ImageOptions.LargeImage")));
			this.btnListaEquipos.Name = "btnListaEquipos";
			this.btnListaEquipos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListaEquipos_ItemClick);
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
			this.ribbonPageGroup1.ItemLinks.Add(this.rFiltro);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCargar);
			this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnListaEquipos);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotal);
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem2);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtConStock);
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem3);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtSinStock);
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 510);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(893, 31);
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
			this.GridLista.Name = "GridLista";
			this.GridLista.Size = new System.Drawing.Size(893, 452);
			this.GridLista.TabIndex = 9;
			this.GridLista.UseEmbeddedNavigator = true;
			this.GridLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.ColumnPanelRowHeight = 22;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoEquipo,
            this.Descripcion,
            this.StockMin,
            this.Estado,
            this.StockMax,
            this.CodigoBarras,
            this.Stock});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.GroupCount = 1;
			this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "fdfdfd", this.Stock, "")});
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsFind.AlwaysVisible = true;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.OptionsView.ShowGroupedColumns = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 22;
			this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Descripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			// 
			// CodigoEquipo
			// 
			this.CodigoEquipo.Caption = "Código";
			this.CodigoEquipo.FieldName = "CodigoEquipo";
			this.CodigoEquipo.MaxWidth = 70;
			this.CodigoEquipo.MinWidth = 70;
			this.CodigoEquipo.Name = "CodigoEquipo";
			this.CodigoEquipo.Visible = true;
			this.CodigoEquipo.VisibleIndex = 0;
			this.CodigoEquipo.Width = 91;
			// 
			// Descripcion
			// 
			this.Descripcion.Caption = "Producto";
			this.Descripcion.FieldName = "Descripcion";
			this.Descripcion.MinWidth = 120;
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
			this.Descripcion.Visible = true;
			this.Descripcion.VisibleIndex = 1;
			this.Descripcion.Width = 141;
			// 
			// StockMin
			// 
			this.StockMin.AppearanceHeader.Options.UseTextOptions = true;
			this.StockMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.StockMin.Caption = "Stock Mín";
			this.StockMin.FieldName = "StockMin";
			this.StockMin.MaxWidth = 70;
			this.StockMin.MinWidth = 70;
			this.StockMin.Name = "StockMin";
			this.StockMin.Visible = true;
			this.StockMin.VisibleIndex = 4;
			this.StockMin.Width = 70;
			// 
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "Estado";
			this.Estado.MaxWidth = 110;
			this.Estado.MinWidth = 110;
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 3;
			this.Estado.Width = 110;
			// 
			// StockMax
			// 
			this.StockMax.AppearanceHeader.Options.UseTextOptions = true;
			this.StockMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.StockMax.Caption = "Stock Max";
			this.StockMax.FieldName = "StockMax";
			this.StockMax.MaxWidth = 70;
			this.StockMax.MinWidth = 70;
			this.StockMax.Name = "StockMax";
			this.StockMax.Visible = true;
			this.StockMax.VisibleIndex = 5;
			this.StockMax.Width = 70;
			// 
			// CodigoBarras
			// 
			this.CodigoBarras.Caption = "Codigo Barras";
			this.CodigoBarras.FieldName = "CodigoBarras";
			this.CodigoBarras.MaxWidth = 100;
			this.CodigoBarras.MinWidth = 100;
			this.CodigoBarras.Name = "CodigoBarras";
			this.CodigoBarras.Visible = true;
			this.CodigoBarras.VisibleIndex = 2;
			this.CodigoBarras.Width = 100;
			// 
			// Stock
			// 
			this.Stock.AppearanceHeader.Options.UseTextOptions = true;
			this.Stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.Stock.Caption = "Stock";
			this.Stock.FieldName = "Stock";
			this.Stock.MaxWidth = 70;
			this.Stock.MinWidth = 70;
			this.Stock.Name = "Stock";
			this.Stock.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Stock", "{0:#.##}")});
			this.Stock.Visible = true;
			this.Stock.VisibleIndex = 6;
			this.Stock.Width = 70;
			// 
			// FrmInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 541);
			this.Controls.Add(this.GridLista);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmInventario";
			this.Ribbon = this.ribbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Inventario";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
		private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
		private DevExpress.XtraGrid.Columns.GridColumn StockMin;
		private DevExpress.XtraGrid.Columns.GridColumn Estado;
		private DevExpress.XtraGrid.Columns.GridColumn StockMax;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoBarras;
		private DevExpress.XtraGrid.Columns.GridColumn Stock;
		private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
		private DevExpress.XtraBars.BarEditItem rFiltro;
		private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.BarStaticItem txtTotal;
		private DevExpress.XtraBars.BarStaticItem barStaticItem2;
		private DevExpress.XtraBars.BarStaticItem txtConStock;
		private DevExpress.XtraBars.BarStaticItem barStaticItem3;
		private DevExpress.XtraBars.BarStaticItem txtSinStock;
		private DevExpress.XtraBars.BarStaticItem txtTotal2;
		private DevExpress.XtraBars.BarStaticItem txtConStock2;
		private DevExpress.XtraBars.BarStaticItem txtSinStock2;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnListaEquipos;
	}
}