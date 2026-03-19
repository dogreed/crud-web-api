using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace crud_web_api.Models
{
	public class Workdto
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
	}

	public class WorkCreateDto
	{
		[Required]
		[StringLength(50)]
		public string? Title { get; set; }
		[Required]
		[StringLength(100)]
		public string? Description { get; set; }
		[Required]
		[StringLength(50)]
		public string? Assigned_by { get; set; }
		[Required]
		[StringLength(50)]
		public string? Assigned_to { get; set; }

	
		public DateTime Due_date { get; set; } 
		public WorkCreateDto()
		{
			Due_date =   DateTime.Now ; 
		}

	}
}
