using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WShopApi.Data;
using WShopApi;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WShopApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WShopApiContext") ?? throw new InvalidOperationException("Connection string 'WShopApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{

    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
app.UseRouting();
app.UseAuthentication();
app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

//app.MapProductoEndpoints();

app.Run();
