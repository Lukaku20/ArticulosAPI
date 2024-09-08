using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ArticulosAPI.Data; // Asegúrate de usar el espacio de nombres correcto

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext con SQL Server
builder.Services.AddDbContext<ArticulosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection" )));


// Añadir controladores
builder.Services.AddControllers();

var app = builder.Build();

// Configurar la app
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapGet("/", () => "Hello wordl!");

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
