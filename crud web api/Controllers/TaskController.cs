using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace crud_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TaskController : ControllerBase
	{

		 List<int> numbers = new List<int>
		{
			1,2,3,4,5,6,7,8,9,10
		};

		[HttpGet]
		public  ActionResult<List<int>> GetAllTasks()
		{
			 return Ok(numbers);
		}

		[HttpPost]
		public ActionResult<List<int>> CreateTask(int number)
		{
			numbers.Add(number);
			return Ok(numbers);
		}
	}
}
