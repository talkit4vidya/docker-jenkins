using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DockerProj_1.Model
{
	[Table("sales")]
	public class Sales
	{
		
		public int id { get; set; }
		public string name { get; set; }
		public decimal quantity { get; set; }
		public float price { get; set; }

	}
}

