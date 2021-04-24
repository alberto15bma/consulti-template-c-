namespace CapaPresentacion.Vista.Salida.Reportes
{
	partial class FrmReporte
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
			this.split = new DevExpress.XtraEditors.SplitContainerControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
			this.split.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			this.SuspendLayout();
			// 
			// split
			// 
			this.split.Dock = System.Windows.Forms.DockStyle.Fill;
			this.split.Location = new System.Drawing.Point(0, 0);
			this.split.Name = "split";
			this.split.Panel1.Text = "Panel1";
			this.split.Panel2.Controls.Add(this.panelControl2);
			this.split.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.split.Panel2.Text = "Panel2";
			this.split.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
			this.split.Size = new System.Drawing.Size(639, 506);
			this.split.SplitterPosition = 360;
			this.split.TabIndex = 1;
			this.split.Text = "splitContainerControl1";
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.layoutControl1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(10, 0);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(0, 36);
			this.panelControl2.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(0, 36);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1, 19);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// FrmReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 506);
			this.Controls.Add(this.split);
			this.Name = "FrmReporte";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reporte";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
			this.split.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.SplitContainerControl split;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
	}
}