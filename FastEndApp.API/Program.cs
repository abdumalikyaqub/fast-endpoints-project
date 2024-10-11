using FastEndApp.API.Database.Contexts;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFastEndpoints()
    .SwaggerDocument();

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
//builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("FastEndAppConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseFastEndpoints()
    .UseSwaggerGen();

app.Run();