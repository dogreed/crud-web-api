using crud_web_api.Data;
using crud_web_api.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
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

		public async Task<List<T>> createTask<T>(Taskcs task) where T : class
		{
			await _context.Tasks.AddAsync(task);
			await _context.SaveChangesAsync();
			var response = task.Adapt<List<T>>();
			return response;

		}
	}
}
