using Application.BuilderRegisters;
using Domain.BuilderRegisters;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Persistance.BuilderRegisters;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
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
