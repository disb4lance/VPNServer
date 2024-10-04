using Service;
using Sevice.Contracts;
using UserManagment.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureSqlContext(builder.Configuration);


builder.Services.AddControllers();
builder.Services.ConfigureIdentity();
builder.Services.AddAuthentication();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IServiceManager, ServiceManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
app.MapControllers();

app.Run();
