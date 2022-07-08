using EventManagement.API.Models;
using EventManagement.BusinessLogic.Extensions;
using EventManagement.DataAccess.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var tokenSettings = builder.Configuration.GetSection("JwtTokenSettings").Get<TokenSettings>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.RequireHttpsMetadata = false;

        var secretBytes = Encoding.UTF8.GetBytes(tokenSettings.JwtSecretKey);

        var key = new SymmetricSecurityKey(secretBytes);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = tokenSettings.JwtIssuer,
            ValidAudience = tokenSettings.JwtAudience,
            IssuerSigningKey = key,
        };
    });

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEFDbContext(connectionString);

builder.Services.AddEFRepositories();

builder.Services.AddAutoMapper(typeof(EventManagement.BusinessLogic.Mappers.EventProfile));
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddServices();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new OpenApiInfo { Title = "EventManagement API", Version = "v1" });

    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        Description = "Jwt Token is required to access some endpoints.",
        In = ParameterLocation.Header,
        Name = "JWT Authentication",
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        BearerFormat = "JWT",
        Reference = new OpenApiReference()
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme,
        },
    };

    setup.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, jwtSecurityScheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() },
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();