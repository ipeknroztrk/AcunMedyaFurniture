using System;
namespace AcunMedyaFurniter.DAL.Entities
{
	public class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public string ProductImage { get; set; }
		public string Description { get; set; }
	}
}

