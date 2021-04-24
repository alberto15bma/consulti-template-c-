using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaPresentacion.Sistema;
using DevExpress.XtraSplashScreen;
using CapaNegocio.Logica;

namespace CapaPresentacion
{
	public partial class Login : DevExpress.XtraEditors.XtraForm
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			MLogin();
		}
		private void MLogin()
		{
			if (ValidarFormulario())
			{
				var usuario = txtUsuario.EditValue.ToString();
				var password = OpcionesDeSistema.Encriptar(txtPassword.EditValue.ToString());
				ClsLogin log = new ClsLogin();
				var login = log.GetLogin(usuario, password);
				if (login != null)
				{
					Properties.Settings.Default["Usuario"] = login.Id;
					Properties.Settings.Default["Nombres"] = login.Apellidos + " " + login.Nombres ;
					this.Hide();
					///SplashScreenManager.ShowForm(typeof(Vista.Splash));

					var passwordDes = txtPassword.EditValue.ToString();
					//if (login.Usuario == passwordDes)
					//{
					//	var cambioPas = new Vista.Usuario.FrmCambiarPassword(login, this);
					//	cambioPas.ShowDialog();
					//}
					//else
					//{
						var main = new Principal(login);
						main.Show();
					//}
				}
				else
				{
					XtraMessageBox.Show(Mensajes.ERROR_SESION, Mensajes.TITULO_ERROR_SESION);
				}
			}
		}
		private bool ValidarFormulario()
		{
			var usuario = txtUsuario.EditValue;
			var password = txtPassword.EditValue;
			if (usuario == null)
			{
				txtUsuario.ErrorText = Mensajes.CAMPO_OBLIGATORIO;
				txtUsuario.Focus();
				return false;
			}
			if (password == null)
			{
				txtPassword.ErrorText = Mensajes.CAMPO_OBLIGATORIO;
				txtPassword.Focus();
				return false;
			}
			return true;
		}
		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				MLogin();
			}
		}
	}
}
