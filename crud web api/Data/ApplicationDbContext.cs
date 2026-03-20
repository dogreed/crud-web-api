using crud_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_web_api.Data
{
	public class ApplicationDbContext : DbContext 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		 public DbSet<Models.Product> Products { get; set; }
		public DbSet<Work> Works { get; set; }
		public DbSet<Taskcs> Tasks { get; set; }
	}
}
