namespace crud_web_api.Models
{
	public class Work
	{
		public int Id { get; set; }
		public  string? Title { get; set; }
		public string ? Description { get; set; }
		public string ? Assigned_by { get; set; }

		public string ? Assigned_to { get; set; }
		public DateTime Due_date { get; set; }
	}
}
