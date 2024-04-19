using AdvisorMangementAPI.Interfaces;
using AdvisorMangementAPI.Repository;
using AdvisorMangementAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAdvisorRepository, AdvisorRepository>();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

//app.MapAuthorEndpoints();

app.Run();
