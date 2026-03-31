namespace crud_web_api.Middleware
{
	public class RequestLoggingMiddleware
	{

		private readonly RequestDelegate _next;
		public RequestLoggingMiddleware(RequestDelegate next)
		{
			_next = next;
		}
		public async Task InvokeAsync(HttpContext context)
		{
			if (context.Request.Path.StartsWithSegments("/api/works"))
			{
				context.Response.StatusCode = StatusCodes.Status403Forbidden;
				await context.Response.WriteAsync("Access to this path is forbidden.");
				return;
			}
			await _next(context);

		}



		//public async Task Herke(HttpContext context)
		//{
		//	if(context.Request.Path.StartsWithSegments("/api/task"))
		//	{
		//		// now here logic for checking if user is authenticated or not
		//		await context.Response.WriteAsync("Login First");
		//		return;
		//	}
		//}


	}
}
