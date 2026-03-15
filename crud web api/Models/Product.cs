namespace crud_web_api.Models
{
	public class Product
	{
		public int Id { get; set; }	
		public string? productName { get; set; }
		
		public string? productDescription { get; set; }

		public decimal price { get; set; }
	}
}
