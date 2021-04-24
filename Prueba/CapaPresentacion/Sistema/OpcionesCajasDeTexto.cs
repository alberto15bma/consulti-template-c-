using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Sistema
{
	public class OpcionesCajasDeTexto
	{
		internal static void ConvertirEnMayuscula(TextEdit txt)
		{
			txt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		}
		internal static void DisenoCombobox(LookUpEdit cb, bool header)
		{
			cb.Properties.ShowFooter = false;
			cb.Properties.ShowLines = false;
			cb.Properties.DropDownItemHeight = 25;
			cb.Properties.ShowHeader = header;
		}

		internal static void DisenoCombobox(RepositoryItemLookUpEdit cb, bool header)
		{
			cb.ShowFooter = false;
			cb.ShowLines = false;
			cb.DropDownItemHeight = 25;
			cb.ShowHeader = header;
		}
		internal static void TipoMoneda(TextEdit txt)
		{

			AlinearTipo(txt);
			txt.Properties.Mask.EditMask = "c";
		}

		private static void AlinearTipo(TextEdit txt)
		{
			txt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			txt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			txt.EditValue = 0;

		}

		internal static void TipoPorcentaje(TextEdit txt)
		{
			AlinearTipo(txt);
			txt.Properties.Mask.EditMask = "P";
		}
		internal static void TipoNumerico(TextEdit txt)
		{
			AlinearTipo(txt);
			txt.Properties.Mask.EditMask = "n";
			txt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			txt.Properties.DisplayFormat.FormatString = "n";
		}
	}
}
