using Microsoft.EntityFrameworkCore;
using UniCareer.API.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Zaregistrování DbContextu pro SQLite (Naše databáze)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=unicareer.db"));

// 2. Přidání podpory pro Kontroléry (Naše CRUD endpointy)
builder.Services.AddControllers();

// 3. Konfigurace Swaggeru (Dokumentace a testování API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4. Nastavení pro vývojové prostředí (Zobrazení Swaggeru)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// 5. Zmapování našich kontrolérů na URL adresy
app.MapControllers();

app.Run();