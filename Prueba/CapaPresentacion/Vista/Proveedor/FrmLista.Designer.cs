namespace CapaPresentacion.Vista.Proveedor
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
			this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Cedula = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Celular = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EstadoId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnEditar,
            this.btnExcel});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 6;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowCategoryInCaption = false;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(788, 58);
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
			// btnExcel
			// 
			this.btnExcel.Caption = "Excel";
			this.btnExcel.Id = 5;
			this.btnExcel.Name = "btnExcel";
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
			this.GridLista.Size = new System.Drawing.Size(788, 333);
			this.GridLista.TabIndex = 3;
			this.GridLista.UseEmbeddedNavigator = true;
			this.GridLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.ColumnPanelRowHeight = 25;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cedula,
            this.RazonSocial,
            this.Direccion,
            this.Celular,
            this.Nombres,
            this.Estado,
            this.Email,
            this.Id,
            this.EstadoId});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 25;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// Cedula
			// 
			this.Cedula.Caption = "Cédula/Rúc";
			this.Cedula.FieldName = "Cedula";
			this.Cedula.MaxWidth = 80;
			this.Cedula.MinWidth = 80;
			this.Cedula.Name = "Cedula";
			this.Cedula.Visible = true;
			this.Cedula.VisibleIndex = 0;
			this.Cedula.Width = 80;
			// 
			// RazonSocial
			// 
			this.RazonSocial.Caption = "Razón social";
			this.RazonSocial.FieldName = "RazonSocial";
			this.RazonSocial.MinWidth = 150;
			this.RazonSocial.Name = "RazonSocial";
			this.RazonSocial.Visible = true;
			this.RazonSocial.VisibleIndex = 1;
			this.RazonSocial.Width = 150;
			// 
			// Direccion
			// 
			this.Direccion.Caption = "Dirección";
			this.Direccion.FieldName = "Direccion";
			this.Direccion.MaxWidth = 80;
			this.Direccion.MinWidth = 130;
			this.Direccion.Name = "Direccion";
			this.Direccion.Visible = true;
			this.Direccion.VisibleIndex = 3;
			this.Direccion.Width = 130;
			// 
			// Celular
			// 
			this.Celular.Caption = "Celular";
			this.Celular.FieldName = "Celular";
			this.Celular.MaxWidth = 80;
			this.Celular.MinWidth = 80;
			this.Celular.Name = "Celular";
			this.Celular.Visible = true;
			this.Celular.VisibleIndex = 4;
			this.Celular.Width = 80;
			// 
			// Nombres
			// 
			this.Nombres.Caption = "Proveedor";
			this.Nombres.FieldName = "Nombres";
			this.Nombres.MinWidth = 130;
			this.Nombres.Name = "Nombres";
			this.Nombres.Visible = true;
			this.Nombres.VisibleIndex = 2;
			this.Nombres.Width = 130;
			// 
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "Estado";
			this.Estado.MaxWidth = 60;
			this.Estado.MinWidth = 60;
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 6;
			this.Estado.Width = 60;
			// 
			// Email
			// 
			this.Email.Caption = "Email";
			this.Email.FieldName = "Email";
			this.Email.MinWidth = 120;
			this.Email.Name = "Email";
			this.Email.Visible = true;
			this.Email.VisibleIndex = 5;
			this.Email.Width = 120;
			// 
			// Id
			// 
			this.Id.Caption = "Id";
			this.Id.FieldName = "Id";
			this.Id.Name = "Id";
			// 
			// EstadoId
			// 
			this.EstadoId.Caption = "EstadoId";
			this.EstadoId.FieldName = "EstadoId";
			this.EstadoId.Name = "EstadoId";
			// 
			// FrmLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 391);
			this.Controls.Add(this.GridLista);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLista";
			this.Ribbon = this.ribbonControl1;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Proveedores";
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
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn Cedula;
		private DevExpress.XtraGrid.Columns.GridColumn RazonSocial;
		private DevExpress.XtraGrid.Columns.GridColumn Direccion;
		private DevExpress.XtraGrid.Columns.GridColumn Celular;
		private DevExpress.XtraGrid.Columns.GridColumn Nombres;
		private DevExpress.XtraGrid.Columns.GridColumn Estado;
		private DevExpress.XtraBars.BarButtonItem btnNuevo;
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraGrid.Columns.GridColumn Email;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraBars.BarButtonItem btnEditar;
		private DevExpress.XtraBars.BarButtonItem btnExcel;
		private DevExpress.XtraGrid.Columns.GridColumn EstadoId;
	}
}