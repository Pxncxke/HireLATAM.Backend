using HireLATAM.Application;
using HireLATAM.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("HireLATAMUI", builder =>
    builder.WithOrigins("http://localhost:4200")
    .AllowAnyHeader()
    .WithMethods("GET", "POST", "PUT", "DELETE")
    .WithExposedHeaders("*"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("HireLATAMUI");

app.UseAuthorization();

app.MapControllers();

app.Run();
