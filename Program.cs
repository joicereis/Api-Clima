using Api_Clima.Interface;
using Api_Clima.Repositories;
using Api_Clima.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IClimaRepository, ClimaRepository>();
builder.Services.AddScoped<ClimaService>();

// Habilitar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirRequisicoes", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use a política de CORS
app.UseCors("PermitirRequisicoes");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
