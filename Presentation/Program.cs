using Application.BuilderRegisters;
using Domain.BuilderRegisters;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Persistance.BuilderRegisters;
using System.Text.Json.Serialization;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
		 .AddJsonOptions(options =>
		 {
			 options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
			 options.JsonSerializerOptions.WriteIndented = true; // optional
			 options.JsonSerializerOptions.MaxDepth = 64; // optional, adjust as needed
		 }); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Custom service extensions ---------------------------------------

//Identity
builder.Services.AddPetCareIdentity();
//Db Context
builder.AddPetCareDbContext();

//Repositories
builder.Services.AddPetCareRepositories();

//Automapper
builder.Services.AddPetCareAutoMapper();

//Validators
builder.Services.AddPetCareFluentValidators();

//-------------------------------------------------------------------

//builder.Services.AddIdentity<Shelter, IdentityRole>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();
