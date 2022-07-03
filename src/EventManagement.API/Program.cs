using EventManagement.BusinessLogic.Extensions;
using EventManagement.DataAccess.Extensions;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEFDbContext(connectionString);

builder.Services.AddEFRepositories();

builder.Services.AddAutoMapper(typeof(EventManagement.BusinessLogic.Mappers.EventProfile));
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddServices();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();