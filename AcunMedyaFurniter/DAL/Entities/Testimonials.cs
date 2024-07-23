using System;
using System.ComponentModel.DataAnnotations;

namespace AcunMedyaFurniter.DAL.Entities
{
	public class Testimonials
	{
		[Key]
		public int TestimonialID { get; set; }
		public string ImageUrl { get; set; }
		public string NameSurname { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }
	}
}

