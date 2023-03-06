using DirectoryAPI.Repositories.Domain;
using DirectoryAPI.Repositories.InterFaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<DirectoryAPI.Repositories.InterFaces.IDirectory, DirectoryAPI.Repositories.Domain.Directory>();
var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
