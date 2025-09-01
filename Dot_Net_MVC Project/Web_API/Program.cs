using Microsoft.EntityFrameworkCore;
using Web_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Web_API.Middleware;
using Microsoft.OpenApi.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.FileProviders;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


/*builder.Services.AddSwaggerGen();*/
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FBI", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
    { new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer"}
            },
        new string[] {}
    }
    });
});


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
{    
    var jwtSettings = builder.Configuration.GetSection("Jwt");
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidateAudience = true,
        ValidAudience = jwtSettings["Audiance"],
        ClockSkew = TimeSpan.Zero,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"])),
    };
    options.Events = new JwtBearerEvents
    {
        OnTokenValidated = context =>
        {
            var token = context.SecurityToken as JwtSecurityToken;
            if (token == null || string.IsNullOrEmpty(token.RawData))
            {
                context.Fail("Token is missing or empty");
            }
            return Task.CompletedTask;
        }
    };
});



// /Dependency Injection of httpclient Class
builder.Services.AddHttpClient();
//builder.Services.AddHttpClient("MyApiClient", client =>
//{
//    client.BaseAddress = new Uri("http://127.0.0.1:9000");
//});



//builder.Services.AddAuthorization();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CustomPolicy", policy =>
    {
        policy.RequireRole("Admin");
        policy.RequireClaim("CustomClaim");
    });
});

//Dependency Injection of DbContext Class
builder.Services.AddDbContext<DBContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))) ;

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles(); // Enable serving static files.

// Configure serving static files from the custom "root" folder
//var rootFolder = Path.Combine(Directory.GetCurrentDirectory(), "root");
//var fileProvider = new PhysicalFileProvider(rootFolder);
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = fileProvider,
//    RequestPath = "/root" // This is the URL prefix for the custom folder
//});

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider( Path.Combine(Directory.GetCurrentDirectory(),"root")),
    RequestPath = new PathString("/root/users")
});


app.UseAuthentication(); /// add app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
