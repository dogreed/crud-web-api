using System.ComponentModel.DataAnnotations;

namespace crud_web_api.Models
{
	public class TaskDto
	{

		public string Id { get; set; }

		[Required]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }

		public DateTime DueDate { get; set; }

	}
}
