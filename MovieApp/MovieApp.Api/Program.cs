using Microsoft.EntityFrameworkCore;
using MovieApp.Api.configaration;
using MovieApp.Application.Configer;
using MovieApp.Infrastrcuter.persstens.Configer;
using MovieSystem.Domain.Entites.ApplicationContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddInfrastarcterServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddApiServices(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//GetConnectionString
        builder.Services.AddDbContext<ApplicationContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



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
