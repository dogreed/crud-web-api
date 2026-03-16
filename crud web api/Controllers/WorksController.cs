using crud_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace crud_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorksController : ControllerBase
	{

		private readonly Data.ApplicationDbContext _context;

		public WorksController(Data.ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult getWorks()
		{
			return Ok(_context.Works.ToList());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> getWorkinfo(int id)
		{
			var work = await _context.Works.FindAsync(id);
			if (work == null)
			{
				return NotFound();
			}
			return Ok(work);
		}

		[HttpPost()]
		public async Task<IActionResult> createWork(Work work)
		{
			_context.Works.AddAsync(work);
			await _context.SaveChangesAsync();
			return Ok(work);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> updateWork(int id, Work work)
		{
			var checkwork = await _context.Works.FindAsync(id);
			if (checkwork == null)
			{
				return NotFound();
			}

			checkwork.Title = work.Title;
			checkwork.Description = work.Description;
			checkwork.Assigned_by = work.Assigned_by;
			checkwork.Assigned_to = work.Assigned_to;
			checkwork.Due_date = work.Due_date;
			await _context.SaveChangesAsync();
			return Ok(checkwork);
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> deletework(int id, Work work)
		{
			var checkwork = await _context.Works.FindAsync(id);
			if (checkwork == null)
			{
				return NotFound();
			}
			_context.Works.Remove(checkwork);
			await _context.SaveChangesAsync();
			return Ok();

		}

	}
}
