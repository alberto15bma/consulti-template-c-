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
using CapaNegocio.Logica;
using CapaPresentacion.Sistema;

namespace CapaPresentacion.Vista.Usuario
{
	public partial class FrmNuevo : DevExpress.XtraEditors.XtraForm
	{
		public Registro registro;
		private CapaDatos.Modelo.Usuarios usua = null;
		public FrmNuevo(Registro registro)
		{
			InitializeComponent();
			this.registro = registro;
			LLenarCombobox();
			AccionRegistro();
		}

		private void AccionRegistro()
		{
			if (registro.tipo.ToString() == "Editar" && registro.Id != 0)
			{
				var us = new ClsUsuario();
				var user = us.GetUsuario(registro.Id);
				if (user != null)
				{
					usua = user;
					txtCedula.EditValue = usua.Cedula;
					txtApellidos.EditValue = usua.Apellidos;
					txtNombres.EditValue = usua.Nombres;
					txtEmail.EditValue = usua.Email;
					cbPerfil.EditValue = usua.PerfilId;
					txtUsuario.EditValue = usua.Usuario;
					txtPassword.EditValue = OpcionesDeSistema.DesEncriptar(usua.Password);
				}
			}
		}

		private void LLenarCombobox()
		{
			cbPerfil.Properties.DataSource = ClsUsuario.GetPerfilUsuario();
			OpcionesCajasDeTexto.DisenoCombobox(cbPerfil, false);

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			Guardar();
		}
		private void Guardar()
		{
			if (Sistema.OpcionesDeSistema.ValidarCampos(layoutControl1))
				EnviarFormulario();
			else
				XtraMessageBox.Show(Mensajes.VALIDAR_CAMPOS, Mensajes.Advertencia);
		}
		private void EnviarFormulario()
		{
			var usuario = new CapaDatos.Modelo.Usuarios();

			usuario.Cedula = txtCedula.EditValue.ToString();
			usuario.Apellidos = txtApellidos.EditValue.ToString();
			usuario.Nombres = txtNombres.EditValue.ToString();

			usuario.FechaModificacion = DateTime.Now;
			usuario.Email = txtEmail.EditValue.ToString();
			usuario.TipoUsuarioId = 1;
			usuario.PerfilId = (int)cbPerfil.EditValue;
			usuario.Usuario = txtUsuario.EditValue.ToString();
			usuario.Password = OpcionesDeSistema.Encriptar(txtPassword.EditValue.ToString());

			var guardar = new ClsUsuario();
			var result = new OperacionResult();
			if (registro.tipo == "Editar" && registro.Id != 0)
			{
				usuario.Id = usua.Id;
				usuario.FechaIngreso = usua.FechaIngreso;
				usuario.Estado = usua.Estado;
				usuario.InicioSesion = usua.InicioSesion;
				guardar.ModificarUsuario(ref result, usuario);
			}
			else if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				usuario.Estado = true;
				usuario.FechaIngreso = DateTime.Now;
				usuario.InicioSesion = true;
				guardar.CrearUsuario(ref result, usuario);
			}
			if (result.success == 1)
			{
				if (registro.tipo == "Editar" && registro.Id != 0)
				{
					XtraMessageBox.Show(Mensajes.MODIFICACION_SUCCESS, Mensajes.TituloSuccess);
				}
				else
				{
					XtraMessageBox.Show(Mensajes.GUARDAR_SUCCESS, Mensajes.TituloSuccess);
				}
				this.Close();
				DialogResult = DialogResult.OK;
			}
			else
			{
				XtraMessageBox.Show("Ocurrió un error al guardar los datos.\n" + result.ErrorMensaje + "\n" + result.InnerException + "\n" + result.InformacionAdicional, "Error");
			}
			//(gridInformacionFamiliar.DataSource as BindingList<cInformacionFamiliar>).AddNew();
		}
		private void txtCedula_Properties_Validating(object sender, CancelEventArgs e)
		{
			if (txtCedula.EditValue != null)
				ValidarExistenciaUsuario();
		}
		private bool ValidarExistenciaUsuario()
		{
			if (registro.tipo == "Nuevo" && registro.Id == 0)
			{
				ClsUsuario item = new ClsUsuario();
				var cedula = txtCedula.EditValue.ToString();
				bool existe = item.ValidarExistenciaUsuario(cedula);
				if (existe)
				{
					XtraMessageBox.Show(Mensajes.EXISTENCIA_CEDULA, Mensajes.TituloError, MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCedula.Focus();
					txtCedula.EditValue = string.Empty;
					return false;
				}
			}
			return true;
		}

		private void txtCedula_Properties_Leave(object sender, EventArgs e)
		{
			if (txtCedula.EditValue != null)
				ValidarExistenciaUsuario();
		}

		private void txtCedula_Properties_KeyUp(object sender, KeyEventArgs e)
		{
			txtUsuario.EditValue = txtCedula.EditValue;
			txtPassword.EditValue = txtCedula.EditValue;
		}
	}
}