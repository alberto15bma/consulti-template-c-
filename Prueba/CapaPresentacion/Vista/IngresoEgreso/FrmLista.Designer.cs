namespace CapaPresentacion.Vista.IngresoEgreso
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
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.btnNuevoIngreso = new DevExpress.XtraBars.BarButtonItem();
			this.btnNuevoEgreso = new DevExpress.XtraBars.BarButtonItem();
			this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotalIngresos = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotalEgresos = new DevExpress.XtraBars.BarStaticItem();
			this.dtDesde = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.dtHasta = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.cbTipo = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.chkTodo = new DevExpress.XtraBars.BarCheckItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CodigoIE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barSubItem1,
            this.btnNuevoIngreso,
            this.btnNuevoEgreso,
            this.btnCargar,
            this.barSubItem2,
            this.btnExcel,
            this.barStaticItem1,
            this.txtTotalIngresos,
            this.barStaticItem3,
            this.txtTotalEgresos,
            this.dtDesde,
            this.dtHasta,
            this.cbTipo,
            this.chkTodo});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 16;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemComboBox1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(794, 58);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "Nuevo";
			this.barSubItem1.Id = 1;
			this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
			this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoIngreso),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoEgreso)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// btnNuevoIngreso
			// 
			this.btnNuevoIngreso.Caption = "Ingreso";
			this.btnNuevoIngreso.Id = 2;
			this.btnNuevoIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoIngreso.ImageOptions.Image")));
			this.btnNuevoIngreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoIngreso.ImageOptions.LargeImage")));
			this.btnNuevoIngreso.Name = "btnNuevoIngreso";
			this.btnNuevoIngreso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoIngreso_ItemClick);
			// 
			// btnNuevoEgreso
			// 
			this.btnNuevoEgreso.Caption = "Egreso";
			this.btnNuevoEgreso.Id = 3;
			this.btnNuevoEgreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEgreso.ImageOptions.Image")));
			this.btnNuevoEgreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoEgreso.ImageOptions.LargeImage")));
			this.btnNuevoEgreso.Name = "btnNuevoEgreso";
			this.btnNuevoEgreso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoEgreso_ItemClick);
			// 
			// btnCargar
			// 
			this.btnCargar.Caption = "Cargar";
			this.btnCargar.Id = 4;
			this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
			// 
			// barSubItem2
			// 
			this.barSubItem2.Caption = "Exportar";
			this.barSubItem2.Id = 5;
			this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
			this.barSubItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.LargeImage")));
			this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel)});
			this.barSubItem2.Name = "barSubItem2";
			// 
			// btnExcel
			// 
			this.btnExcel.Caption = "Excel";
			this.btnExcel.Id = 7;
			this.btnExcel.Name = "btnExcel";
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Caption = "Total ingresos:";
			this.barStaticItem1.Id = 8;
			this.barStaticItem1.Name = "barStaticItem1";
			// 
			// txtTotalIngresos
			// 
			this.txtTotalIngresos.Caption = "0";
			this.txtTotalIngresos.Id = 9;
			this.txtTotalIngresos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotalIngresos.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
			this.txtTotalIngresos.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotalIngresos.ItemAppearance.Normal.Options.UseForeColor = true;
			this.txtTotalIngresos.Name = "txtTotalIngresos";
			// 
			// barStaticItem3
			// 
			this.barStaticItem3.Caption = "Total egresos";
			this.barStaticItem3.Id = 10;
			this.barStaticItem3.Name = "barStaticItem3";
			// 
			// txtTotalEgresos
			// 
			this.txtTotalEgresos.Caption = "0";
			this.txtTotalEgresos.Id = 11;
			this.txtTotalEgresos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotalEgresos.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtTotalEgresos.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotalEgresos.ItemAppearance.Normal.Options.UseForeColor = true;
			this.txtTotalEgresos.Name = "txtTotalEgresos";
			// 
			// dtDesde
			// 
			this.dtDesde.Caption = "Desde:";
			this.dtDesde.Edit = this.repositoryItemDateEdit1;
			this.dtDesde.EditWidth = 100;
			this.dtDesde.Enabled = false;
			this.dtDesde.Id = 12;
			this.dtDesde.Name = "dtDesde";
			// 
			// repositoryItemDateEdit1
			// 
			this.repositoryItemDateEdit1.AutoHeight = false;
			this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
			// 
			// dtHasta
			// 
			this.dtHasta.Caption = "Hasta:";
			this.dtHasta.Edit = this.repositoryItemDateEdit2;
			this.dtHasta.EditWidth = 100;
			this.dtHasta.Enabled = false;
			this.dtHasta.Id = 13;
			this.dtHasta.Name = "dtHasta";
			// 
			// repositoryItemDateEdit2
			// 
			this.repositoryItemDateEdit2.AutoHeight = false;
			this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
			// 
			// cbTipo
			// 
			this.cbTipo.Caption = "Tipo:";
			this.cbTipo.Edit = this.repositoryItemComboBox1;
			this.cbTipo.EditValue = "TODO";
			this.cbTipo.EditWidth = 55;
			this.cbTipo.Enabled = false;
			this.cbTipo.Id = 14;
			this.cbTipo.Name = "cbTipo";
			// 
			// repositoryItemComboBox1
			// 
			this.repositoryItemComboBox1.AutoHeight = false;
			this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemComboBox1.DropDownItemHeight = 25;
			this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "TODO",
            "I",
            "E"});
			this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
			this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// chkTodo
			// 
			this.chkTodo.BindableChecked = true;
			this.chkTodo.Caption = "Todo:";
			this.chkTodo.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
			this.chkTodo.Checked = true;
			this.chkTodo.Id = 15;
			this.chkTodo.Name = "chkTodo";
			this.chkTodo.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkTodo_CheckedChanged);
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
			this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
			this.ribbonPageGroup1.ItemLinks.Add(this.chkTodo);
			this.ribbonPageGroup1.ItemLinks.Add(this.dtDesde);
			this.ribbonPageGroup1.ItemLinks.Add(this.dtHasta);
			this.ribbonPageGroup1.ItemLinks.Add(this.cbTipo);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCargar);
			this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem2);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalIngresos);
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem3);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalEgresos);
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 422);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(794, 31);
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
			this.GridLista.Size = new System.Drawing.Size(794, 364);
			this.GridLista.TabIndex = 5;
			this.GridLista.UseEmbeddedNavigator = true;
			this.GridLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.ColumnPanelRowHeight = 25;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoIE,
            this.FechaFactura,
            this.Concepto,
            this.Id,
            this.Observacion,
            this.TotalItem,
            this.Tipo});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowDetailButtons = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 25;
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			// 
			// CodigoIE
			// 
			this.CodigoIE.Caption = "Código";
			this.CodigoIE.FieldName = "CodigoIE";
			this.CodigoIE.MaxWidth = 70;
			this.CodigoIE.MinWidth = 70;
			this.CodigoIE.Name = "CodigoIE";
			this.CodigoIE.Visible = true;
			this.CodigoIE.VisibleIndex = 0;
			this.CodigoIE.Width = 70;
			// 
			// FechaFactura
			// 
			this.FechaFactura.Caption = "Fecha";
			this.FechaFactura.DisplayFormat.FormatString = "g";
			this.FechaFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.FechaFactura.FieldName = "Fecha";
			this.FechaFactura.MaxWidth = 120;
			this.FechaFactura.MinWidth = 120;
			this.FechaFactura.Name = "FechaFactura";
			this.FechaFactura.Visible = true;
			this.FechaFactura.VisibleIndex = 1;
			this.FechaFactura.Width = 120;
			// 
			// Concepto
			// 
			this.Concepto.Caption = "Concepto";
			this.Concepto.FieldName = "Concepto";
			this.Concepto.MinWidth = 160;
			this.Concepto.Name = "Concepto";
			this.Concepto.Visible = true;
			this.Concepto.VisibleIndex = 3;
			this.Concepto.Width = 307;
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
			// Tipo
			// 
			this.Tipo.Caption = "Tipo";
			this.Tipo.FieldName = "Tipo";
			this.Tipo.MaxWidth = 50;
			this.Tipo.MinWidth = 50;
			this.Tipo.Name = "Tipo";
			this.Tipo.Visible = true;
			this.Tipo.VisibleIndex = 2;
			this.Tipo.Width = 50;
			// 
			// FrmLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 453);
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
			this.Text = "Lista de movimientos";
			this.Load += new System.EventHandler(this.FrmLista_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
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
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarButtonItem btnNuevoIngreso;
		private DevExpress.XtraBars.BarButtonItem btnNuevoEgreso;
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraBars.BarSubItem barSubItem2;
		private DevExpress.XtraBars.BarButtonItem btnExcel;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoIE;
		private DevExpress.XtraGrid.Columns.GridColumn FechaFactura;
		private DevExpress.XtraGrid.Columns.GridColumn Concepto;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraGrid.Columns.GridColumn Observacion;
		private DevExpress.XtraGrid.Columns.GridColumn TotalItem;
		private DevExpress.XtraGrid.Columns.GridColumn Tipo;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.BarStaticItem txtTotalIngresos;
		private DevExpress.XtraBars.BarStaticItem barStaticItem3;
		private DevExpress.XtraBars.BarStaticItem txtTotalEgresos;
		private DevExpress.XtraBars.BarEditItem dtDesde;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
		private DevExpress.XtraBars.BarEditItem dtHasta;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
		private DevExpress.XtraBars.BarEditItem cbTipo;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
		private DevExpress.XtraBars.BarCheckItem chkTodo;
	}
}