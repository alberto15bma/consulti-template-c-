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
using DevExpress.Skins;
using CapaNegocio.Logica;
using CapaDatos.Modelo;
using CapaPresentacion.Sistema;
using DevExpress.LookAndFeel;
using System.Drawing.Printing;

namespace CapaPresentacion.Vista.Administracion
{
	public partial class FrmConfiguracionSystem : DevExpress.XtraEditors.XtraForm
	{
		private int usuario = (int)Properties.Settings.Default["Usuario"];

		public FrmConfiguracionSystem()
		{
			InitializeComponent();
			AcGeneral.SelectedElement = Eusuarios;
			CargarUsuarios();
		}

		private void CargarUsuarios()
		{
			var user = new ClsUsuario();
			var lista = user.GetUsuarios().Where(a => a.TipoUsuarioId == 1);
			GridLista.DataSource = lista;
		}

		private void CargarValores()
		{
			foreach (SkinContainer item in SkinManager.Default.Skins)
			{
				//cbTema.Properties.Items.Add(item.SkinName);
			}
		}


		private void FrmConfiguracionSystem_Load(object sender, EventArgs e)
		{
			
		}

		private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			GuardarTema();
			
		}

		private void GuardarTema()
		{
			
		}

		private void AcGeneral_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
		{
			switch (e.Element.Name)
			{
				
				case "Eusuarios":
					Navegacion.SelectedPage = Nusuarios;
					break;

			}
		}

		private void btnReparar_Click(object sender, EventArgs e)
		{
			
		}


		private void btnNuevoUsuario_Click(object sender, EventArgs e)
		{
			var reg = new Registro();
			reg.tipo = "Nuevo";
			var user = new Vista.Usuario.FrmNuevo(reg);
			var accion = user.ShowDialog();
			if (accion == DialogResult.OK)
			{
				CargarUsuarios();
			}
		}

		private void btnEditarUsuario_Click(object sender, EventArgs e)
		{
			var Id = gridView1.GetFocusedRowCellValue("Id");
			if (Id != null)
			{
				var reg = new Registro();
				reg.tipo = "Editar";
				reg.Id = Convert.ToInt32(Id);
				var user = new Vista.Usuario.FrmNuevo(reg);
				var accion = user.ShowDialog();
				if (accion == DialogResult.OK)
				{
					CargarUsuarios();
				}
			}
		}
	}
}