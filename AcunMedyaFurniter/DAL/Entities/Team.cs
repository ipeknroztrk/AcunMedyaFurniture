using System;
namespace AcunMedyaFurniter.DAL.Entities
{
	public class Team
	{
		public int TeamId { get; set; }
		public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
	    public string ImageUrl { get; set; }

    }
}

