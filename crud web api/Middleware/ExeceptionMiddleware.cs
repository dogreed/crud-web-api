namespace crud_web_api.Middleware
{
	public class ExeceptionMiddleware

	{
		private readonly RequestDelegate _next;
		public ExeceptionMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				context.Response.StatusCode = StatusCodes.Status500InternalServerError;
				await context.Response.WriteAsync($"An error occurred: {ex.Message}");
			}
		}
	}
}
