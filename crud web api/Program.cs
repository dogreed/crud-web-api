using crud_web_api.Data;
using crud_web_api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddScoped<Iwork,WorkService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<crud_web_api.Middleware.RequestLoggingMiddleware>();
app.UseMiddleware<crud_web_api.Middleware.ExeceptionMiddleware>();
app.MapControllers();

app.Run();
