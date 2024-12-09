using Microsoft.EntityFrameworkCore;
using SevenApi.ContextDb;
using SevenApi.ORM.Repositories;
using System.Configuration;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers()/*.AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.WriteIndented = true; // Optional
})*/;

//builder.Services.AddDbContext<SevenContext>(opt=> opt.UseInMemoryDatabase("Articles"));

builder.Services.AddDbContext<SevenContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<ArticleRepositorie>();
builder.Services.AddTransient<CategorieRepositorie>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
