﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("EstadoMovimiento")]
	public class EstadoMovimiento
	{
		[Key]
		public int Id { get; set; }
		[StringLength(15)]
		public string Descripcion { get; set; }
	}
}
