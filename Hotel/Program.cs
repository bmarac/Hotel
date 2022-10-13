using Hotel.API;
using Hotel.DAL;
using Hotel.Model.Interfaces.Repositories;
using Hotel.Model.Interfaces.Services;
using Hotel.Model.Models;
using Hotel.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//SERVICES
builder.Services.AddScoped<IHotelServices, HotelServices>();

//REPOSITORIES
builder.Services.AddScoped<IHotelRepositories, HotelRepositories>();

//DbContext
builder.Services.AddDbContext<HotelDBContext>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
