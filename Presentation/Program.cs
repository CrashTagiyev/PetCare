using Application.BuilderRegisters;
using Application.Validators.FluentValidators.ModelValidators;
using Domain.BuilderRegisters;
using Infrastructure.BuilderRegisters;
using Infrastructure.Hubs.ChatHub;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Persistance.BuilderRegisters;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Text;
using System.Text.Json.Serialization;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowSpecificOrigin",
			builder => builder.WithOrigins("http://localhost:5174").WithOrigins("http://localhost:3000").WithOrigins("http://localhost:5173")
			.AllowAnyMethod()
			.AllowCredentials()
			.AllowAnyHeader());
});


builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddControllers()
		 .AddJsonOptions(options =>
		 {
			 options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
			 options.JsonSerializerOptions.WriteIndented = true;
			 options.JsonSerializerOptions.MaxDepth = 64;
		 }).AddXmlDataContractSerializerFormatters();

builder.Services.AddScoped<LoginRequestValidator>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Custom service extensions ---------------------------------------

//Custom Services
builder.Services.AddPetCareServices();
//Identity
builder.Services.AddPetCareIdentity();
//Db Context
builder.AddPetCareDbContext();
//Azure Blob Service Client
builder.AddPetCareImageBlobServiceClient();
//Repositories
builder.Services.AddPetCareRepositories();
builder.Services.AddPetCareFluentValidators();
//Automapper
builder.Services.AddPetCareAutoMapper();

//Validators
//builder.Services.AddPetCareFluentValidators();
builder.Services.AddPetCareFluentValidators();
//-------------------------------------------------------------------


builder.Services.AddSwaggerGen(option =>
{
	option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
	option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
	{
		In = ParameterLocation.Header,
		Description = "Please enter a valid token",
		Name = "Authorization",
		Type = SecuritySchemeType.Http,
		BearerFormat = "JWT",
		Scheme = "Bearer"
	});
	option.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{
			new OpenApiSecurityScheme
			{
				Reference = new OpenApiReference
				{
					Type=ReferenceType.SecurityScheme,
					Id="Bearer"
				}
			},
			new string[]{}
		}
	});
});




builder.Services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
	options.TokenValidationParameters = new TokenValidationParameters()
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		LifetimeValidator = (before, expires, token, param) => expires > DateTime.UtcNow,
		ValidIssuer = builder.Configuration["JWT:Issuer"],
		ValidAudience = builder.Configuration["JWT:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]!)),
	
	};

	//options.Events = new JwtBearerEvents
	//{
	//	OnMessageReceived= context =>
	//	{
	//		context.Request.Cookies.TryGetValue("accessToken", out var accessToken);
	//		if (!string.IsNullOrEmpty(accessToken))
	//			context.Token = accessToken;
	//		return Task.CompletedTask;
	//	}
	//};
});








//builder.Services.AddIdentity<Shelter, IdentityRole>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");
app.MapHub<ChatHub>("api/chathub");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
