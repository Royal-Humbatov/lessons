using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApplication2;
using WebApplication2.Repositories.Core;
using WebApplication2.Repositories.Implementation;
using WebApplication2.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof (ICategoryRepository<>), typeof(CategoryRepository<>));
builder.Services.AddScoped(typeof(IPersonRepository<>), typeof(PersonRepository<>));   
builder.Services.AddScoped(typeof(IProductRepository<>), typeof(ProductRepository<>));
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SQL100"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
}); 

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
