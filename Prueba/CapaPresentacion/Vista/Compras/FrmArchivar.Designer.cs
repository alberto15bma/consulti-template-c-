namespace CapaPresentacion.Vista.Compras
{
	partial class FrmArchivar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivar));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.btnImprimirArchivar = new DevExpress.XtraEditors.DropDownButton();
			this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
			this.btnArchivar = new DevExpress.XtraBars.BarButtonItem();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.mDetalle = new DevExpress.XtraEditors.MemoEdit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mDetalle.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(5, 386);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(249, 36);
			this.panelControl1.TabIndex = 2;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnImprimirArchivar);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(249, 36);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// btnImprimirArchivar
			// 
			this.btnImprimirArchivar.DropDownControl = this.popupMenu1;
			this.btnImprimirArchivar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirArchivar.ImageOptions.Image")));
			this.btnImprimirArchivar.Location = new System.Drawing.Point(7, 7);
			this.btnImprimirArchivar.Name = "btnImprimirArchivar";
			this.btnImprimirArchivar.Size = new System.Drawing.Size(235, 22);
			this.btnImprimirArchivar.StyleController = this.layoutControl1;
			this.btnImprimirArchivar.TabIndex = 4;
			this.btnImprimirArchivar.Text = "Archivar e imprimir";
			this.btnImprimirArchivar.Click += new System.EventHandler(this.btnImprimirArchivar_Click);
			// 
			// popupMenu1
			// 
			this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnArchivar)});
			this.popupMenu1.Manager = this.barManager1;
			this.popupMenu1.Name = "popupMenu1";
			// 
			// btnArchivar
			// 
			this.btnArchivar.Caption = "Solo archivar";
			this.btnArchivar.Id = 0;
			this.btnArchivar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivar.ImageOptions.Image")));
			this.btnArchivar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArchivar.ImageOptions.LargeImage")));
			this.btnArchivar.Name = "btnArchivar";
			this.btnArchivar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArchivar_ItemClick);
			// 
			// barManager1
			// 
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnArchivar});
			this.barManager1.MaxItemId = 1;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(5, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(249, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(5, 422);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(249, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(5, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(254, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlGroup1.Size = new System.Drawing.Size(249, 36);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.btnImprimirArchivar;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.MinSize = new System.Drawing.Size(116, 26);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(239, 26);
			this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// mDetalle
			// 
			this.mDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mDetalle.Location = new System.Drawing.Point(5, 0);
			this.mDetalle.Name = "mDetalle";
			this.mDetalle.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mDetalle.Properties.Appearance.Options.UseFont = true;
			this.mDetalle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.mDetalle.Properties.ReadOnly = true;
			this.mDetalle.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mDetalle.Size = new System.Drawing.Size(249, 386);
			this.mDetalle.TabIndex = 3;
			// 
			// FrmArchivar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 422);
			this.Controls.Add(this.mDetalle);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmArchivar";
			this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Archivar compra";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mDetalle.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.MemoEdit mDetalle;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.DropDownButton btnImprimirArchivar;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.PopupMenu popupMenu1;
		private DevExpress.XtraBars.BarButtonItem btnArchivar;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}