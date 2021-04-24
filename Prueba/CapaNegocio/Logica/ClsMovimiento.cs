using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Logica
{
	public class ClsMovimiento
	{
		public void ArchivarCompra(ref OperacionResult result, List<ListaDetalleCompras> detalle)
		{
			using (var db = new BDContext())
			{
				try
				{
					// Verificar producto
					for (int i = 0; i < detalle.Count(); i++)
					{
						var det = new Movimiento();
						det.ProductoId = detalle[i].IdEquipo;
						det.FechaModificacion = DateTime.Now;
						det.EstadoId = 1;
						
						det.Stock = detalle[i].Cantidad;
						var existe = db.Movimiento.FirstOrDefault(a => a.ProductoId == det.ProductoId && a.EstadoId == det.EstadoId);
						if (existe != null)
						{
							existe.FechaModificacion = DateTime.Now;
							existe.StockAnterior = existe.Stock;
							existe.Stock = existe.Stock + det.Stock;
						}
						else
						{
							db.Movimiento.Add(det);
						}
						db.SaveChanges();
					}
					result.success = 1;

				}
				catch (Exception e)
				{
					result.success = 0;
					result.ErrorMensaje = e.Message;
					result.InnerException = e.InnerException != null ? e.InnerException.Message : string.Empty;
					result.InformacionAdicional = "ClsMovimiento.ArchivarCompra()";
					return;
				}
				finally
				{
					((IDisposable)db).Dispose();
				}
			}
		}
	}
}
