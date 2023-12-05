using Mango.Services.StrategyApi.Data;
using Mango.Services.StrategyApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<AppDbContext>(
    option =>
        option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsAssembly("Mango.Services.StrategyApi")
        ));

//SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"));



builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", async () =>
{
    using var connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"));
    //var strategys = await connection.QueryAsync<Strategy>("SELECT TOP 10 ProductID, Name from ...");
    //return strategys;
});


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

