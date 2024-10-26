using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using user_mgt.Data;
using user_mgt.Mapping;
using user_mgt.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:5173") // Specify allowed origins
               .AllowAnyHeader()                  // Allow any header
               .AllowAnyMethod()                  // Allow any HTTP method (GET, POST, etc.)
               .AllowCredentials();               // If you need credentials (like cookies)
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Authdbstring"));
});

builder.Services.AddAutoMapper(typeof(MappingConfig));

// Configure Identity and password hashing
builder.Services.AddScoped<IPasswordHasher<string>, PasswordHasher>();

// Add Authentication service and configure JWT Bearer authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Secret"]))
    };
});

builder.Services.AddAuthorizationBuilder()
    .AddPolicy("AdminOnly", policy =>
        policy.RequireClaim("isAdmin", "True"));


// Register application services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCorsPolicy");

app.UseHttpsRedirection();

// Enable Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Exclude the registration endpoint from authentication
app.MapControllerRoute(
    name: "register",
    pattern: "api/Auth/register",
    defaults: new { controller = "Auth", action = "Register" }
).AllowAnonymous(); // Allow anonymous access for registration

// Apply database migrations
ApplyMigration();

app.Run();

void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (_db.Database.GetPendingMigrations().Any())
        {
            _db.Database.Migrate();
        }
    }
}
