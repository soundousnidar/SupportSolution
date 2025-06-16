using Microsoft.EntityFrameworkCore;
using SupportService.Data;

var builder = WebApplication.CreateBuilder(args);

// Ajouter le contexte de base de donn�es avec une base en m�moire
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Ajouter les services de contr�leurs
builder.Services.AddControllers();

// Configuration de Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
