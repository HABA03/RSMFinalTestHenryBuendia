using Microsoft.EntityFrameworkCore;
using RSM.API.DependencyContainer;
using RSM.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));

var config = new ConfigurationBuilder()
	  .AddJsonFile("appsettings.json", optional: false)
	  .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FinalTestDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction")));

builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(builder =>
	builder.WithOrigins(config["Cors:ClientUrl"])
		   .AllowAnyMethod()
		   .AllowAnyHeader());
});


DependencyContainer.RegisterServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
