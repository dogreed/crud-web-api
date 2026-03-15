using Microsoft.EntityFrameworkCore;

namespace crud_web_api.Data
{
	public class ApplicationDbContext : DbContext 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		 public DbSet<Models.Product> Products { get; set; }
	}
}
