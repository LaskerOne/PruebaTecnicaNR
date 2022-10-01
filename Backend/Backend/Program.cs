using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*Configuración de los Cors para habilitar la conexión del front con el back
 En el método estamos indicando que permita cualquier origen, cabecera de página y cualquier método*/
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())); ;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuración para agregar el DB context con el motor de la base de datos a usar
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Uso de la nueva configuración
app.UseCors("AllowWebApp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
