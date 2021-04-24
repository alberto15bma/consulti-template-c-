namespace CapaPresentacion
{
	partial class Principal
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
			DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.cbUsuario = new DevExpress.XtraEditors.DropDownButton();
			this.menuUsuario = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.tileControl1 = new DevExpress.XtraEditors.TileControl();
			this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
			this.tEquipos = new DevExpress.XtraEditors.TileItem();
			this.tCompras = new DevExpress.XtraEditors.TileItem();
			this.tInventario = new DevExpress.XtraEditors.TileItem();
			this.tClientes = new DevExpress.XtraEditors.TileItem();
			this.tProveedores = new DevExpress.XtraEditors.TileItem();
			this.tIngresoEgreso = new DevExpress.XtraEditors.TileItem();
			this.tAdministracion = new DevExpress.XtraEditors.TileItem();
			this.tSalida = new DevExpress.XtraEditors.TileItem();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.menuUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.cbUsuario);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
			this.panelControl1.Size = new System.Drawing.Size(774, 41);
			this.panelControl1.TabIndex = 0;
			// 
			// cbUsuario
			// 
			this.cbUsuario.AllowFocus = false;
			this.cbUsuario.Appearance.Options.UseTextOptions = true;
			this.cbUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.cbUsuario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.cbUsuario.Dock = System.Windows.Forms.DockStyle.Right;
			this.cbUsuario.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
			this.cbUsuario.DropDownControl = this.menuUsuario;
			this.cbUsuario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
			this.cbUsuario.Location = new System.Drawing.Point(602, 10);
			this.cbUsuario.Name = "cbUsuario";
			this.cbUsuario.Size = new System.Drawing.Size(162, 21);
			this.cbUsuario.TabIndex = 0;
			this.cbUsuario.Text = "Usuario";
			// 
			// menuUsuario
			// 
			this.menuUsuario.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
			this.menuUsuario.Manager = this.barManager1;
			this.menuUsuario.Name = "menuUsuario";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Mi perfil";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barManager1
			// 
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
			this.barManager1.MaxItemId = 1;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(774, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(774, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(774, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 41);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.tileControl1);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
			this.splitContainerControl1.Size = new System.Drawing.Size(774, 448);
			this.splitContainerControl1.SplitterPosition = 489;
			this.splitContainerControl1.TabIndex = 1;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// tileControl1
			// 
			this.tileControl1.AllowDrag = false;
			this.tileControl1.AllowDragTilesBetweenGroups = false;
			this.tileControl1.AllowItemHover = true;
			this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tileControl1.Groups.Add(this.tileGroup1);
			this.tileControl1.Location = new System.Drawing.Point(0, 0);
			this.tileControl1.MaxId = 10;
			this.tileControl1.Name = "tileControl1";
			this.tileControl1.RowCount = 1;
			this.tileControl1.Size = new System.Drawing.Size(774, 448);
			this.tileControl1.TabIndex = 0;
			this.tileControl1.Text = "tileControl1";
			this.tileControl1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl1_ItemClick);
			// 
			// tileGroup1
			// 
			this.tileGroup1.Items.Add(this.tEquipos);
			this.tileGroup1.Items.Add(this.tCompras);
			this.tileGroup1.Items.Add(this.tInventario);
			this.tileGroup1.Items.Add(this.tClientes);
			this.tileGroup1.Items.Add(this.tProveedores);
			this.tileGroup1.Items.Add(this.tIngresoEgreso);
			this.tileGroup1.Items.Add(this.tAdministracion);
			this.tileGroup1.Items.Add(this.tSalida);
			this.tileGroup1.Name = "tileGroup1";
			this.tileGroup1.Text = "tileGroup1";
			// 
			// tEquipos
			// 
			this.tEquipos.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tEquipos.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tEquipos.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tEquipos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tEquipos.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tEquipos.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement1.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Workstation_85px;
			tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement1.Text = "Artículos";
			tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tEquipos.Elements.Add(tileItemElement1);
			this.tEquipos.Id = 0;
			this.tEquipos.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tEquipos.Name = "tEquipos";
			// 
			// tCompras
			// 
			this.tCompras.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tCompras.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tCompras.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tCompras.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tCompras.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tCompras.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement2.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Cash_in_Hand_85px;
			tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement2.Text = "Compras";
			tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tCompras.Elements.Add(tileItemElement2);
			this.tCompras.Id = 8;
			this.tCompras.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tCompras.Name = "tCompras";
			// 
			// tInventario
			// 
			this.tInventario.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tInventario.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tInventario.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tInventario.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tInventario.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tInventario.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement3.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Computer_Support_85px;
			tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement3.Text = "Inventario";
			tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tInventario.Elements.Add(tileItemElement3);
			this.tInventario.Id = 1;
			this.tInventario.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tInventario.Name = "tInventario";
			// 
			// tClientes
			// 
			this.tClientes.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tClientes.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tClientes.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tClientes.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tClientes.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tClientes.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement4.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Staff_85px;
			tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement4.Text = "Clientes";
			tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tClientes.Elements.Add(tileItemElement4);
			this.tClientes.Id = 3;
			this.tClientes.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tClientes.Name = "tClientes";
			// 
			// tProveedores
			// 
			this.tProveedores.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tProveedores.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tProveedores.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tProveedores.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tProveedores.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tProveedores.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement5.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Exchange_85px;
			tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement5.Text = "Proveedores";
			tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tProveedores.Elements.Add(tileItemElement5);
			this.tProveedores.Id = 5;
			this.tProveedores.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tProveedores.Name = "tProveedores";
			// 
			// tIngresoEgreso
			// 
			this.tIngresoEgreso.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tIngresoEgreso.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tIngresoEgreso.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tIngresoEgreso.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tIngresoEgreso.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tIngresoEgreso.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement6.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Up_Down_Arrow__85px;
			tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement6.Text = "Ingresos y Egresos";
			tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tIngresoEgreso.Elements.Add(tileItemElement6);
			this.tIngresoEgreso.Id = 6;
			this.tIngresoEgreso.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tIngresoEgreso.Name = "tIngresoEgreso";
			// 
			// tAdministracion
			// 
			this.tAdministracion.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tAdministracion.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tAdministracion.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tAdministracion.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tAdministracion.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tAdministracion.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement7.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Wrench_85px;
			tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement7.Text = "Administración";
			tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tAdministracion.Elements.Add(tileItemElement7);
			this.tAdministracion.Id = 7;
			this.tAdministracion.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tAdministracion.Name = "tAdministracion";
			// 
			// tSalida
			// 
			this.tSalida.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.tSalida.AppearanceItem.Hovered.Options.UseBorderColor = true;
			this.tSalida.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tSalida.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
			this.tSalida.AppearanceItem.Normal.Options.UseBackColor = true;
			this.tSalida.AppearanceItem.Normal.Options.UseBorderColor = true;
			tileItemElement8.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.Shopping_Cart_85px;
			tileItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
			tileItemElement8.Text = "Salida";
			tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
			this.tSalida.Elements.Add(tileItemElement8);
			this.tSalida.Id = 9;
			this.tSalida.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
			this.tSalida.Name = "tSalida";
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 489);
			this.Controls.Add(this.splitContainerControl1);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Principal";
			this.ShowIcon = false;
			this.Text = "Sistema Prueba práctica";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.menuUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraEditors.TileControl tileControl1;
		private DevExpress.XtraEditors.TileGroup tileGroup1;
		private DevExpress.XtraEditors.TileItem tEquipos;
		private DevExpress.XtraEditors.TileItem tInventario;
		private DevExpress.XtraEditors.TileItem tClientes;
		private DevExpress.XtraEditors.TileItem tProveedores;
		private DevExpress.XtraEditors.TileItem tIngresoEgreso;
		private DevExpress.XtraEditors.TileItem tAdministracion;
		private DevExpress.XtraEditors.DropDownButton cbUsuario;
		private DevExpress.XtraBars.PopupMenu menuUsuario;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraEditors.TileItem tCompras;
		private DevExpress.XtraEditors.TileItem tSalida;
	}
}