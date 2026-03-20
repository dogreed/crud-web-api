using crud_web_api.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace crud_web_api.Services
{
	public class WorkService : Iwork
	{

		private readonly ApplicationDbContext _context;
		public WorkService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<T>> getTasks<T>() where T : class
		{
			var tasks = await _context.Tasks.ToListAsync();
			var response = tasks.Adapt<List<T>>();
			return response;
		}
	}
}
