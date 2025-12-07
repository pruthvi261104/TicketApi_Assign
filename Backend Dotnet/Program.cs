var builder = WebApplication.CreateBuilder(args);

//Enabling Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", p => p.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();


app.UseCors("AllowAngular");
app.MapControllers();

app.Run();
