using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace coreDepartmantProject.Models
{
	public class Admin
	{
		[Key]
		public int AdminId { get; set; }

	
		public string Kullanici { get; set; }


		public string Sifre { get; set; }
	}
}
