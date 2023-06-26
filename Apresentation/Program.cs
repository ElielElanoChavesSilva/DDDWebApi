using Autofac.Extensions.DependencyInjection;
using Autofac;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Infrastructure.CrossCutting.IOC;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetCore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>(option => option.UseSqlServer("Server=127.0.0.1;Database=Loja;User ID=sa;Password=Eliel4321!;TrustServerCertificate=true;"));
builder.Services.AddMemoryCache();
builder.Services.AddMvc();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new ModuleIOC()));


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
