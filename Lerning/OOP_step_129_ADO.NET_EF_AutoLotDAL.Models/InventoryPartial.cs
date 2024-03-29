﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Models
{
	public partial class Inventory
	{
		public override string ToString()
		{
			// Since the PetName column could be empty, supply
			// the default name of **No Name**.
			return $"{this.PetName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.Id}.";
		}
		[NotMapped]
		public string MakeColor => $"{Make} + ({Color})";
	}
}
