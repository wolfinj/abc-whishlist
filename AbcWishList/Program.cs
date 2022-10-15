using AbcSoftwareWishList.Helpers;
using AbcWishList.Core.Models;
using AbcWishList.Core.Services;
using AbcWishList.Data;
using AbcWishList.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<WishListDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEntityService<Item>, EntityService<Item>>();
builder.Services.AddScoped<IWishListDbContext, WishListDbContext>();
builder.Services.AddSingleton(ConvertExtensionMethods.CreateMapper());

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
