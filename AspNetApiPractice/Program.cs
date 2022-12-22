using AspNetApiPractice.Application;
using AspNetApiPractice.Application.ExceptionMiddleware;
using AspNetApiPractice.Infrastructure;
using AspNetApiPractice.Infrastructure.Seed;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var logger = new LoggerConfiguration()
    .WriteTo.File("Log.txt", restrictedToMinimumLevel:Serilog.Events.LogEventLevel.Error,rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureService(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Host.UseSerilog((hostContext, services, configuration) => {
    configuration.WriteTo.File("log.txt");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   

    app.UseSwagger();
    app.UseSwaggerUI();
    SeedData.SeedingData(builder.Services.BuildServiceProvider());
    app.UseMiddleware<ExceptionMiddleware>();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
