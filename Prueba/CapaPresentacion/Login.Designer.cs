namespace CapaPresentacion
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnCerrar = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.btnCerrar);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelControl1.Location = new System.Drawing.Point(3, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(203, 368);
			this.panelControl1.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Appearance.Image")));
			this.btnCerrar.Appearance.Options.UseImage = true;
			this.btnCerrar.Location = new System.Drawing.Point(177, 6);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(16, 16);
			this.btnCerrar.TabIndex = 2;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(9, 352);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(75, 13);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Prueba práctica";
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.btnEntrar);
			this.panelControl2.Controls.Add(this.txtPassword);
			this.panelControl2.Controls.Add(this.txtUsuario);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Location = new System.Drawing.Point(0, 59);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(200, 217);
			this.panelControl2.TabIndex = 0;
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(9, 141);
			this.btnEntrar.LookAndFeel.SkinName = "The Bezier";
			this.btnEntrar.LookAndFeel.UseDefaultLookAndFeel = false;
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(182, 28);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(9, 94);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.AutoHeight = false;
			this.txtPassword.Properties.NullText = "Contraseña";
			this.txtPassword.Properties.NullValuePrompt = "Contraseña";
			this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
			this.txtPassword.Properties.UseSystemPasswordChar = true;
			this.txtPassword.Size = new System.Drawing.Size(182, 28);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(9, 53);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Properties.AutoHeight = false;
			this.txtUsuario.Properties.NullText = "Usuario";
			this.txtUsuario.Properties.NullValuePrompt = "Usuario";
			this.txtUsuario.Properties.NullValuePromptShowForEmptyValue = true;
			this.txtUsuario.Size = new System.Drawing.Size(182, 28);
			this.txtUsuario.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelControl1.Location = new System.Drawing.Point(0, 0);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(200, 31);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Login";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 368);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtUsuario;
		private DevExpress.XtraEditors.SimpleButton btnEntrar;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl btnCerrar;
		internal DevExpress.XtraEditors.TextEdit txtPassword;
	}
}