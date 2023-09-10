using Entities.DbContextEntities;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"), sqlServerOptions => sqlServerOptions.CommandTimeout(120));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

});
// Add services to the container.

builder.Services.AddScoped<IRegistration, Repository.Repository.Registration>();

builder.Services.AddControllers();
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
