namespace CapaPresentacion.Vista.Usuario
{
	partial class FrmNuevo
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.cbPerfil = new DevExpress.XtraEditors.LookUpEdit();
			this.txtCedula = new DevExpress.XtraEditors.TextEdit();
			this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
			this.txtNombres = new DevExpress.XtraEditors.TextEdit();
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbPerfil.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.btnGuardar);
			this.panelControl1.Controls.Add(this.btnCancelar);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 317);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(308, 42);
			this.panelControl1.TabIndex = 0;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(142, 10);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 0;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(223, 10);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 0;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(288, 225);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.cbPerfil);
			this.layoutControl1.Controls.Add(this.txtCedula);
			this.layoutControl1.Controls.Add(this.txtApellidos);
			this.layoutControl1.Controls.Add(this.txtNombres);
			this.layoutControl1.Controls.Add(this.txtEmail);
			this.layoutControl1.Controls.Add(this.txtUsuario);
			this.layoutControl1.Controls.Add(this.txtPassword);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(308, 317);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// cbPerfil
			// 
			this.cbPerfil.Location = new System.Drawing.Point(75, 108);
			this.cbPerfil.Name = "cbPerfil";
			this.cbPerfil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbPerfil.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")});
			this.cbPerfil.Properties.DisplayMember = "Descripcion";
			this.cbPerfil.Properties.DropDownRows = 3;
			this.cbPerfil.Properties.NullText = "";
			this.cbPerfil.Properties.ValueMember = "Id";
			this.cbPerfil.Size = new System.Drawing.Size(221, 20);
			this.cbPerfil.StyleController = this.layoutControl1;
			this.cbPerfil.TabIndex = 9;
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(75, 12);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Properties.Mask.EditMask = "\\d{0,10}";
			this.txtCedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.txtCedula.Properties.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCedula_Properties_KeyUp);
			this.txtCedula.Properties.Leave += new System.EventHandler(this.txtCedula_Properties_Leave);
			this.txtCedula.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.txtCedula_Properties_Validating);
			this.txtCedula.Size = new System.Drawing.Size(221, 20);
			this.txtCedula.StyleController = this.layoutControl1;
			this.txtCedula.TabIndex = 4;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(75, 36);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidos.Size = new System.Drawing.Size(221, 20);
			this.txtApellidos.StyleController = this.layoutControl1;
			this.txtApellidos.TabIndex = 5;
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(75, 60);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombres.Size = new System.Drawing.Size(221, 20);
			this.txtNombres.StyleController = this.layoutControl1;
			this.txtNombres.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(75, 84);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Properties.Mask.EditMask = "(\\w|[\\.\\-])+@(\\w|[\\-]+\\.)*(\\w|[\\-]){2,63}\\.[a-zA-Z]{2,4}";
			this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.txtEmail.Size = new System.Drawing.Size(221, 20);
			this.txtEmail.StyleController = this.layoutControl1;
			this.txtEmail.TabIndex = 7;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(75, 134);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Properties.ReadOnly = true;
			this.txtUsuario.Size = new System.Drawing.Size(221, 20);
			this.txtUsuario.StyleController = this.layoutControl1;
			this.txtUsuario.TabIndex = 10;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(75, 158);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(221, 20);
			this.txtPassword.StyleController = this.layoutControl1;
			this.txtPassword.TabIndex = 11;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.simpleSeparator1,
            this.layoutControlItem8});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(308, 317);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtCedula;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem1.Text = "Cédula:";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtApellidos;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem2.Text = "Apellidos:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtNombres;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem3.Text = "Nombres:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtEmail;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem4.Text = "Email";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.cbPerfil;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem6.Text = "Perfil:";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.txtUsuario;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 122);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(288, 24);
			this.layoutControlItem7.Text = "Usuario:";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 13);
			// 
			// simpleSeparator1
			// 
			this.simpleSeparator1.AllowHotTrack = false;
			this.simpleSeparator1.Location = new System.Drawing.Point(0, 120);
			this.simpleSeparator1.Name = "simpleSeparator1";
			this.simpleSeparator1.Size = new System.Drawing.Size(288, 2);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.txtPassword;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 146);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(288, 151);
			this.layoutControlItem8.Text = "Contraseña:";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 13);
			// 
			// FrmNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 359);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmNuevo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo usuario";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbPerfil.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
		private DevExpress.XtraEditors.SimpleButton btnGuardar;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.TextEdit txtCedula;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.TextEdit txtApellidos;
		private DevExpress.XtraEditors.TextEdit txtNombres;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.TextEdit txtEmail;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraEditors.LookUpEdit cbPerfil;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
		private DevExpress.XtraEditors.TextEdit txtUsuario;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
	}
}