using Microsoft.EntityFrameworkCore;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.Services;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Data.Repositories;
using SIPRA_FESC.Entities;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(config => {
    
    config.AddSecurityDefinition("Bearer",new OpenApiSecurityScheme
    {
        Description = "Jwt Authorization",
        Name ="Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    config.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.AddDbContext<SipraContext>(optionsAction: options => {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
  _ = options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
});

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<SipraContext>();
builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService,UsuarioService>();
builder.Services.AddScoped<IAuthService,AuthService>();
builder.Services.AddScoped<IDocumentoRepository,DocumentoRepository>();
builder.Services.AddScoped<IDocumentoService,DocumentoService>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(config =>
{
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddCors(options => {
    options.AddPolicy("CorsPolicy", builder => {
        builder.WithOrigins("*");
        builder.WithMethods("*");
        builder.WithHeaders("*");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
