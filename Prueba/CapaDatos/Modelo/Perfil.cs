﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
	[Table("Perfil")]
	public class Perfil
	{
		[Key]
		public int Id { get; set; }
		[StringLength(60)]
		public string Descripcion { get; set; }
	}
}
