namespace CapaPresentacion.Vista.Equipos
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
			this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CodigoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.StockMin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EstadoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.StockMax = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
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
            this.btnEditar});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 4;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(744, 58);
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
			// btnEditar
			// 
			this.btnEditar.Caption = "Editar";
			this.btnEditar.Id = 3;
			this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
			this.btnEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.LargeImage")));
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
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
			this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
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
			this.GridLista.Size = new System.Drawing.Size(744, 427);
			this.GridLista.TabIndex = 2;
			this.GridLista.UseEmbeddedNavigator = true;
			this.GridLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.ColumnPanelRowHeight = 25;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoEquipo,
            this.Descripcion,
            this.StockMin,
            this.EstadoEquipo,
            this.StockMax,
            this.CodigoBarras});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 25;
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
			this.CodigoEquipo.Width = 70;
			// 
			// Descripcion
			// 
			this.Descripcion.Caption = "Descripción";
			this.Descripcion.FieldName = "Descripcion";
			this.Descripcion.MinWidth = 120;
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Visible = true;
			this.Descripcion.VisibleIndex = 1;
			this.Descripcion.Width = 140;
			// 
			// StockMin
			// 
			this.StockMin.Caption = "Stock Mín";
			this.StockMin.FieldName = "StockMin";
			this.StockMin.MaxWidth = 70;
			this.StockMin.MinWidth = 70;
			this.StockMin.Name = "StockMin";
			this.StockMin.Visible = true;
			this.StockMin.VisibleIndex = 3;
			this.StockMin.Width = 70;
			// 
			// EstadoEquipo
			// 
			this.EstadoEquipo.Caption = "Estado";
			this.EstadoEquipo.FieldName = "EstadoEquipo";
			this.EstadoEquipo.MaxWidth = 60;
			this.EstadoEquipo.MinWidth = 60;
			this.EstadoEquipo.Name = "EstadoEquipo";
			this.EstadoEquipo.Visible = true;
			this.EstadoEquipo.VisibleIndex = 5;
			this.EstadoEquipo.Width = 60;
			// 
			// StockMax
			// 
			this.StockMax.Caption = "Stock Max";
			this.StockMax.FieldName = "StockMax";
			this.StockMax.MaxWidth = 70;
			this.StockMax.MinWidth = 70;
			this.StockMax.Name = "StockMax";
			this.StockMax.Visible = true;
			this.StockMax.VisibleIndex = 4;
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
			// FrmLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 485);
			this.Controls.Add(this.GridLista);
			this.Controls.Add(this.ribbonControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLista";
			this.Ribbon = this.ribbonControl1;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Productos";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.BarButtonItem btnNuevo;
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
		private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
		private DevExpress.XtraGrid.Columns.GridColumn StockMin;
		private DevExpress.XtraGrid.Columns.GridColumn EstadoEquipo;
		private DevExpress.XtraBars.BarButtonItem btnEditar;
		private DevExpress.XtraGrid.Columns.GridColumn StockMax;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoBarras;
	}
}