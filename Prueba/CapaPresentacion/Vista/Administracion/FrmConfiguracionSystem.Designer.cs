namespace CapaPresentacion.Vista.Administracion
{
	partial class FrmConfiguracionSystem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionSystem));
			this.AcGeneral = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.Eusuarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.Navegacion = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.Nusuarios = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.GridLista = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Usuario2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EstadoId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Perfil = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
			this.btnNuevoUsuario = new DevExpress.XtraEditors.SimpleButton();
			this.btnEditarUsuario = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.AcGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Navegacion)).BeginInit();
			this.Navegacion.SuspendLayout();
			this.Nusuarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
			this.layoutControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
			this.SuspendLayout();
			// 
			// AcGeneral
			// 
			this.AcGeneral.AllowItemSelection = true;
			this.AcGeneral.Appearance.AccordionControl.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.AcGeneral.Appearance.AccordionControl.Options.UseBorderColor = true;
			this.AcGeneral.Dock = System.Windows.Forms.DockStyle.Left;
			this.AcGeneral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
			this.AcGeneral.Location = new System.Drawing.Point(0, 0);
			this.AcGeneral.Name = "AcGeneral";
			this.AcGeneral.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
			this.AcGeneral.Size = new System.Drawing.Size(180, 562);
			this.AcGeneral.TabIndex = 1;
			this.AcGeneral.Text = "accordionControl1";
			this.AcGeneral.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.AcGeneral_ElementClick);
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Eusuarios});
			this.accordionControlElement1.Expanded = true;
			this.accordionControlElement1.HeaderIndent = 0;
			this.accordionControlElement1.HeaderVisible = false;
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Element1";
			// 
			// Eusuarios
			// 
			this.Eusuarios.Name = "Eusuarios";
			this.Eusuarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.Eusuarios.Text = "Usuarios";
			// 
			// Navegacion
			// 
			this.Navegacion.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
			this.Navegacion.Controls.Add(this.Nusuarios);
			this.Navegacion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Navegacion.Location = new System.Drawing.Point(180, 0);
			this.Navegacion.Name = "Navegacion";
			this.Navegacion.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Nusuarios});
			this.Navegacion.SelectedPage = this.Nusuarios;
			this.Navegacion.Size = new System.Drawing.Size(665, 562);
			this.Navegacion.TabIndex = 2;
			this.Navegacion.Text = "navigationFrame1";
			// 
			// Nusuarios
			// 
			this.Nusuarios.Controls.Add(this.GridLista);
			this.Nusuarios.Controls.Add(this.panelControl2);
			this.Nusuarios.Name = "Nusuarios";
			this.Nusuarios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.Nusuarios.Size = new System.Drawing.Size(665, 562);
			// 
			// GridLista
			// 
			this.GridLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridLista.Location = new System.Drawing.Point(10, 46);
			this.GridLista.MainView = this.gridView1;
			this.GridLista.Name = "GridLista";
			this.GridLista.Size = new System.Drawing.Size(645, 516);
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
            this.Usuario2,
            this.Nombres,
            this.Estado,
            this.Password,
            this.Id,
            this.EstadoId,
            this.Perfil});
			this.gridView1.GridControl = this.GridLista;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.RowHeight = 25;
			// 
			// Usuario2
			// 
			this.Usuario2.Caption = "Usuario";
			this.Usuario2.FieldName = "Usuario";
			this.Usuario2.MaxWidth = 100;
			this.Usuario2.MinWidth = 100;
			this.Usuario2.Name = "Usuario2";
			this.Usuario2.Visible = true;
			this.Usuario2.VisibleIndex = 0;
			this.Usuario2.Width = 100;
			// 
			// Nombres
			// 
			this.Nombres.Caption = "Nombres";
			this.Nombres.FieldName = "Nombres";
			this.Nombres.MinWidth = 130;
			this.Nombres.Name = "Nombres";
			this.Nombres.Visible = true;
			this.Nombres.VisibleIndex = 2;
			this.Nombres.Width = 305;
			// 
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "Estado";
			this.Estado.MaxWidth = 60;
			this.Estado.MinWidth = 60;
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 3;
			this.Estado.Width = 60;
			// 
			// Password
			// 
			this.Password.Caption = "Contraseña";
			this.Password.FieldName = "Password";
			this.Password.MaxWidth = 100;
			this.Password.MinWidth = 100;
			this.Password.Name = "Password";
			this.Password.Visible = true;
			this.Password.VisibleIndex = 1;
			this.Password.Width = 100;
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
			// Perfil
			// 
			this.Perfil.Caption = "Perfil";
			this.Perfil.FieldName = "Perfil";
			this.Perfil.MaxWidth = 100;
			this.Perfil.MinWidth = 100;
			this.Perfil.Name = "Perfil";
			this.Perfil.Visible = true;
			this.Perfil.VisibleIndex = 4;
			this.Perfil.Width = 100;
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.layoutControl6);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(10, 0);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(645, 46);
			this.panelControl2.TabIndex = 0;
			// 
			// layoutControl6
			// 
			this.layoutControl6.Controls.Add(this.btnNuevoUsuario);
			this.layoutControl6.Controls.Add(this.btnEditarUsuario);
			this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Left;
			this.layoutControl6.Location = new System.Drawing.Point(0, 0);
			this.layoutControl6.Name = "layoutControl6";
			this.layoutControl6.Root = this.layoutControlGroup12;
			this.layoutControl6.Size = new System.Drawing.Size(180, 46);
			this.layoutControl6.TabIndex = 0;
			this.layoutControl6.Text = "layoutControl6";
			// 
			// btnNuevoUsuario
			// 
			this.btnNuevoUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.ImageOptions.Image")));
			this.btnNuevoUsuario.Location = new System.Drawing.Point(2, 12);
			this.btnNuevoUsuario.Name = "btnNuevoUsuario";
			this.btnNuevoUsuario.Size = new System.Drawing.Size(80, 22);
			this.btnNuevoUsuario.StyleController = this.layoutControl6;
			this.btnNuevoUsuario.TabIndex = 4;
			this.btnNuevoUsuario.Text = "Nuevo";
			this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
			// 
			// btnEditarUsuario
			// 
			this.btnEditarUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.ImageOptions.Image")));
			this.btnEditarUsuario.Location = new System.Drawing.Point(86, 12);
			this.btnEditarUsuario.Name = "btnEditarUsuario";
			this.btnEditarUsuario.Size = new System.Drawing.Size(92, 22);
			this.btnEditarUsuario.StyleController = this.layoutControl6;
			this.btnEditarUsuario.TabIndex = 5;
			this.btnEditarUsuario.Text = "Editar";
			this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
			// 
			// layoutControlGroup12
			// 
			this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup12.GroupBordersVisible = false;
			this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem29,
            this.layoutControlItem30});
			this.layoutControlGroup12.Name = "layoutControlGroup12";
			this.layoutControlGroup12.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
			this.layoutControlGroup12.Size = new System.Drawing.Size(180, 46);
			this.layoutControlGroup12.TextVisible = false;
			// 
			// layoutControlItem29
			// 
			this.layoutControlItem29.Control = this.btnNuevoUsuario;
			this.layoutControlItem29.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Size = new System.Drawing.Size(84, 26);
			this.layoutControlItem29.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem29.TextVisible = false;
			// 
			// layoutControlItem30
			// 
			this.layoutControlItem30.Control = this.btnEditarUsuario;
			this.layoutControlItem30.Location = new System.Drawing.Point(84, 0);
			this.layoutControlItem30.Name = "layoutControlItem30";
			this.layoutControlItem30.Size = new System.Drawing.Size(96, 26);
			this.layoutControlItem30.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem30.TextVisible = false;
			// 
			// FrmConfiguracionSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 562);
			this.Controls.Add(this.Navegacion);
			this.Controls.Add(this.AcGeneral);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmConfiguracionSystem";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Opciones del sistema";
			this.Load += new System.EventHandler(this.FrmConfiguracionSystem_Load);
			((System.ComponentModel.ISupportInitialize)(this.AcGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Navegacion)).EndInit();
			this.Navegacion.ResumeLayout(false);
			this.Nusuarios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
			this.layoutControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.Navigation.AccordionControl AcGeneral;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.Navigation.NavigationFrame Navegacion;
		private DevExpress.XtraBars.Navigation.AccordionControlElement Eusuarios;
		private DevExpress.XtraBars.Navigation.NavigationPage Nusuarios;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraGrid.GridControl GridLista;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn Usuario2;
		private DevExpress.XtraGrid.Columns.GridColumn Nombres;
		private DevExpress.XtraGrid.Columns.GridColumn Estado;
		private DevExpress.XtraGrid.Columns.GridColumn Password;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraGrid.Columns.GridColumn EstadoId;
		private DevExpress.XtraLayout.LayoutControl layoutControl6;
		private DevExpress.XtraEditors.SimpleButton btnNuevoUsuario;
		private DevExpress.XtraEditors.SimpleButton btnEditarUsuario;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
		private DevExpress.XtraGrid.Columns.GridColumn Perfil;
	}
}