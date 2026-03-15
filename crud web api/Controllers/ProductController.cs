using crud_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace crud_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly Data.ApplicationDbContext _context;

		public ProductController(Data.ApplicationDbContext context)
		{
			_context = context;
		}


		[HttpGet]
		public IActionResult getProduct()
		{

			return Ok(_context.Products.ToList());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> get(int id)
		{
			var product = await _context.Products.FindAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}

		[HttpPost()]
		public async Task<IActionResult> createProduct(Product product)
		{
			_context.Products.Add(product);
			await _context.SaveChangesAsync();
			return Ok(product);

		}
		[HttpPut("{id}")]
		public async Task<IActionResult> updateProduct(int id, Product product)
		{
			var doProductExist = await _context.Products.FindAsync(id);
			if (doProductExist == null)
			{
				return NotFound();
			}

			doProductExist.productName = product.productName;
			doProductExist.productDescription = product.productDescription;
			doProductExist.price = product.price;
			await _context.SaveChangesAsync();
			return Ok(doProductExist);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> deleteProduct(int id)
		{
			var doproductExist = await _context.Products.FindAsync(id);
			if (doproductExist == null)
			{
				return NotFound();
			}
			 _context.Products.Remove(doproductExist);
			await _context.SaveChangesAsync();
			return Ok();
		}
	}
}
