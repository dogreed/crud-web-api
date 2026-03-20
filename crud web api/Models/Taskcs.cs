using System.ComponentModel.DataAnnotations;

namespace crud_web_api.Models
{
	public class Taskcs
	{
		[Required]
		public string Id { get; set; }
		[Required]
		[StringLength(20)]
		public string Title { get; set; }
		[Required]
		[StringLength(20)]
		public string Description { get; set; }
		[Required]

		public DateTime DueDate { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;		
	}
}
