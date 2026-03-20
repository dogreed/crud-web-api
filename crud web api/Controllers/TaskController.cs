using crud_web_api.Data;
using crud_web_api.Models;
using crud_web_api.Services;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace crud_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TaskController : ControllerBase
	{
		private readonly Iwork _work;
		public TaskController(Iwork work)
		{
			_work = work;
		}

		[HttpGet]
		public IActionResult getTasks()
		{
			var response = _work.getTasks<TaskDto>().Result;
			return Ok(response); 
		}
		


	}
}
