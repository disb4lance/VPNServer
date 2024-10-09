using Service.Contract;
using Services;
using VPN_Management.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ConfigureSqlContext(builder.Configuration);
//builder.Services.AddScoped<IVpnService, RabbitMQListenerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();