using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsabellePalmdahl.Models.POCOs
{
	public class Client
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		public int Phone { get; set; } //change to string
		public string? Message { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime DateCreated { get; set; }
	}
}

