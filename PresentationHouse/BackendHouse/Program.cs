using System.Text.Json.Serialization;
using ApplicationHouse.Contracts;
using ApplicationHouse.Services;
using ArchitectureHouse.Data;
using ArchitectureHouse.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<HouseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IHouse, HouseRepository>();
builder.Services.AddScoped<IMode, ModeRepository>();
builder.Services.AddSwaggerGen();
// To Avois cycling  we need to add this part otherwise we need tomake some change Reposotory to introduce ModelVieewDtos
//builder.Services.AddControllers().AddJsonOptions(options =>
//{
    //options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
   // options.JsonSerializerOptions.WriteIndented = true;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    builder.Services.AddCors();
    app.UseCors(policy =>
    {
        policy.WithOrigins("https://localhost:7287")
          .AllowAnyMethod()
          .AllowAnyHeader()
          .WithHeaders(HeaderNames.ContentType);

    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

