namespace CapaPresentacion.Vista.Inventario
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
			this.btnNuevoIngreso = new DevExpress.XtraBars.BarButtonItem();
			this.btnNuevoEgreso = new DevExpress.XtraBars.BarButtonItem();
			this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
			this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotalArchivadas = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotalAnuladas = new DevExpress.XtraBars.BarStaticItem();
			this.dtDesde = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.dtHasta = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.chkTodo = new DevExpress.XtraBars.BarCheckItem();
			this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.txtTotalPendiente = new DevExpress.XtraBars.BarStaticItem();
			this.cbTipo = new DevExpress.XtraBars.BarEditItem();
			this.cbTipo2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.btnContinuar = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.btnEncerarArticulos = new DevExpress.XtraBars.BarButtonItem();
			this.btnTomaFisicaInventario = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CodigoIE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Comentario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbTipo2)).BeginInit();
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
            this.btnNuevoIngreso,
            this.btnNuevoEgreso,
            this.btnCargar,
            this.btnExcel,
            this.barStaticItem1,
            this.txtTotalArchivadas,
            this.barStaticItem3,
            this.txtTotalAnuladas,
            this.dtDesde,
            this.dtHasta,
            this.chkTodo,
            this.barStaticItem2,
            this.txtTotalPendiente,
            this.cbTipo,
            this.btnContinuar,
            this.barSubItem1,
            this.btnEncerarArticulos,
            this.btnTomaFisicaInventario});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 23;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemComboBox1,
            this.cbTipo2});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
			this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(794, 58);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			// 
			// btnNuevoIngreso
			// 
			this.btnNuevoIngreso.Caption = "Ingreso";
			this.btnNuevoIngreso.Id = 2;
			this.btnNuevoIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoIngreso.ImageOptions.Image")));
			this.btnNuevoIngreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoIngreso.ImageOptions.LargeImage")));
			this.btnNuevoIngreso.Name = "btnNuevoIngreso";
			// 
			// btnNuevoEgreso
			// 
			this.btnNuevoEgreso.Caption = "Egreso";
			this.btnNuevoEgreso.Id = 3;
			this.btnNuevoEgreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEgreso.ImageOptions.Image")));
			this.btnNuevoEgreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoEgreso.ImageOptions.LargeImage")));
			this.btnNuevoEgreso.Name = "btnNuevoEgreso";
			// 
			// btnCargar
			// 
			this.btnCargar.Caption = "Cargar";
			this.btnCargar.Id = 4;
			this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
			// 
			// btnExcel
			// 
			this.btnExcel.Caption = "Excel";
			this.btnExcel.Id = 7;
			this.btnExcel.Name = "btnExcel";
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Caption = "Total archivadas:";
			this.barStaticItem1.Id = 8;
			this.barStaticItem1.Name = "barStaticItem1";
			// 
			// txtTotalArchivadas
			// 
			this.txtTotalArchivadas.Caption = "0";
			this.txtTotalArchivadas.Id = 9;
			this.txtTotalArchivadas.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotalArchivadas.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
			this.txtTotalArchivadas.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotalArchivadas.ItemAppearance.Normal.Options.UseForeColor = true;
			this.txtTotalArchivadas.Name = "txtTotalArchivadas";
			// 
			// barStaticItem3
			// 
			this.barStaticItem3.Caption = "Total anuladas:";
			this.barStaticItem3.Id = 10;
			this.barStaticItem3.Name = "barStaticItem3";
			// 
			// txtTotalAnuladas
			// 
			this.txtTotalAnuladas.Caption = "0";
			this.txtTotalAnuladas.Id = 11;
			this.txtTotalAnuladas.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotalAnuladas.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtTotalAnuladas.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotalAnuladas.ItemAppearance.Normal.Options.UseForeColor = true;
			this.txtTotalAnuladas.Name = "txtTotalAnuladas";
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
			// barStaticItem2
			// 
			this.barStaticItem2.Caption = "Total pendientes:";
			this.barStaticItem2.Id = 16;
			this.barStaticItem2.Name = "barStaticItem2";
			// 
			// txtTotalPendiente
			// 
			this.txtTotalPendiente.Caption = "0";
			this.txtTotalPendiente.Id = 17;
			this.txtTotalPendiente.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.txtTotalPendiente.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtTotalPendiente.ItemAppearance.Normal.Options.UseFont = true;
			this.txtTotalPendiente.ItemAppearance.Normal.Options.UseForeColor = true;
			this.txtTotalPendiente.Name = "txtTotalPendiente";
			// 
			// cbTipo
			// 
			this.cbTipo.Caption = "Tipo:";
			this.cbTipo.Edit = this.cbTipo2;
			this.cbTipo.EditWidth = 90;
			this.cbTipo.Enabled = false;
			this.cbTipo.Id = 18;
			this.cbTipo.Name = "cbTipo";
			// 
			// cbTipo2
			// 
			this.cbTipo2.AutoHeight = false;
			this.cbTipo2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbTipo2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")});
			this.cbTipo2.DisplayMember = "Descripcion";
			this.cbTipo2.DropDownRows = 4;
			this.cbTipo2.Name = "cbTipo2";
			this.cbTipo2.NullText = "";
			this.cbTipo2.ValueMember = "Id";
			// 
			// btnContinuar
			// 
			this.btnContinuar.Caption = "Continuar";
			this.btnContinuar.Id = 19;
			this.btnContinuar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.ImageOptions.Image")));
			this.btnContinuar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.ImageOptions.LargeImage")));
			this.btnContinuar.Name = "btnContinuar";
			this.btnContinuar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContinuar_ItemClick);
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "Nuevo";
			this.barSubItem1.Id = 20;
			this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
			this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEncerarArticulos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTomaFisicaInventario)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// btnEncerarArticulos
			// 
			this.btnEncerarArticulos.Caption = "Encerar artículos";
			this.btnEncerarArticulos.Enabled = false;
			this.btnEncerarArticulos.Id = 21;
			this.btnEncerarArticulos.Name = "btnEncerarArticulos";
			// 
			// btnTomaFisicaInventario
			// 
			this.btnTomaFisicaInventario.Caption = "Toma física de inventario";
			this.btnTomaFisicaInventario.Id = 22;
			this.btnTomaFisicaInventario.Name = "btnTomaFisicaInventario";
			this.btnTomaFisicaInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTomaFisicaInventario_ItemClick);
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
			this.ribbonPageGroup1.ItemLinks.Add(this.btnContinuar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
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
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalArchivadas);
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem3);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalAnuladas);
			this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem2);
			this.ribbonStatusBar1.ItemLinks.Add(this.txtTotalPendiente);
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
            this.Id,
            this.Comentario,
            this.TotalItem,
            this.Estado,
            this.Usuario});
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
			// Id
			// 
			this.Id.Caption = "Id";
			this.Id.FieldName = "Id";
			this.Id.Name = "Id";
			// 
			// Comentario
			// 
			this.Comentario.Caption = "Observacion";
			this.Comentario.FieldName = "Comentario";
			this.Comentario.MinWidth = 140;
			this.Comentario.Name = "Comentario";
			this.Comentario.Visible = true;
			this.Comentario.VisibleIndex = 4;
			this.Comentario.Width = 150;
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
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "Estado";
			this.Estado.MaxWidth = 90;
			this.Estado.MinWidth = 90;
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 3;
			this.Estado.Width = 90;
			// 
			// Usuario
			// 
			this.Usuario.Caption = "Usuario";
			this.Usuario.FieldName = "Usuario";
			this.Usuario.MaxWidth = 180;
			this.Usuario.MinWidth = 140;
			this.Usuario.Name = "Usuario";
			this.Usuario.Visible = true;
			this.Usuario.VisibleIndex = 2;
			this.Usuario.Width = 140;
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
			this.Text = "Lista de inventarios";
			this.Load += new System.EventHandler(this.FrmLista_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbTipo2)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem btnNuevoIngreso;
		private DevExpress.XtraBars.BarButtonItem btnNuevoEgreso;
		private DevExpress.XtraBars.BarButtonItem btnCargar;
		private DevExpress.XtraBars.BarButtonItem btnExcel;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn CodigoIE;
		private DevExpress.XtraGrid.Columns.GridColumn FechaFactura;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraGrid.Columns.GridColumn Comentario;
		private DevExpress.XtraGrid.Columns.GridColumn TotalItem;
		private DevExpress.XtraGrid.Columns.GridColumn Estado;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.BarStaticItem txtTotalArchivadas;
		private DevExpress.XtraBars.BarStaticItem barStaticItem3;
		private DevExpress.XtraBars.BarStaticItem txtTotalAnuladas;
		private DevExpress.XtraBars.BarEditItem dtDesde;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
		private DevExpress.XtraBars.BarEditItem dtHasta;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
		private DevExpress.XtraBars.BarCheckItem chkTodo;
		private DevExpress.XtraBars.BarStaticItem barStaticItem2;
		private DevExpress.XtraBars.BarStaticItem txtTotalPendiente;
		private DevExpress.XtraGrid.Columns.GridColumn Usuario;
		private DevExpress.XtraBars.BarEditItem cbTipo;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbTipo2;
		private DevExpress.XtraBars.BarButtonItem btnContinuar;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarButtonItem btnEncerarArticulos;
		private DevExpress.XtraBars.BarButtonItem btnTomaFisicaInventario;
	}
}