using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

public class CustomMiddlewareAttribute : ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        // Inject IConfiguration using [FromService]
        var configuration = context.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
        if (configuration == null)
        {
            throw new InvalidOperationException("IConfiguration is required but not available.");
        }

        var token = context.HttpContext.Request.Headers["Authorization"].ToString();
        if (string.IsNullOrEmpty(token))
        {
            context.HttpContext.Response.StatusCode = 400;
            await context.HttpContext.Response.WriteAsync("Token is required");
            return;
        }

        try
        {
            //var tokenValue = token.Substring("Bearer ".Length);
            var validationParameters = new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                RequireSignedTokens = true,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidAudience = configuration["Jwt:Issuer"],
                ValidateIssuer = true,
                ValidIssuer = configuration["Jwt:Audiance"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out var rawValidatedToken);
            var jwtSecurityToken = (JwtSecurityToken)rawValidatedToken;

            // Attach the claimsPrincipal to the current HttpContext for further authorization
            context.HttpContext.User = claimsPrincipal;
        }
        catch (Exception ex)
        {
            context.HttpContext.Response.StatusCode = 401;
            await context.HttpContext.Response.WriteAsync("Token validation failed: " + ex.Message);
            return;
        }

        await next(); // Call the next middleware in the pipeline
    }
}




/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

public class CustomMiddlewareAttribute : ActionFilterAttribute
{
    private readonly IConfiguration _configuration;
    private readonly JwtSecurityTokenHandler _tokenHandler;

    *//* public CustomMiddlewareAttribute(IConfiguration configuration)
     {
         _configuration = configuration;
         _tokenHandler = new JwtSecurityTokenHandler();
     }*//*
   
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        string token = context.HttpContext.Request.Headers["Authorization"].ToString();
        Console.WriteLine(token + "token");
        if (string.IsNullOrEmpty(token))
        {
            context.HttpContext.Response.StatusCode = 400;
            await context.HttpContext.Response.WriteAsync("Token is required");
            return;
        }

        try
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var tokenValue = token.Substring("Bearer ".Length);

            var validationParameters = new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"])),
                RequireSignedTokens = true,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidAudience = jwtSettings["Audience"],
                ValidateIssuer = true,
                ValidIssuer = jwtSettings["Issuer"]
            };

            var claimsPrincipal = _tokenHandler.ValidateToken(tokenValue, validationParameters, out var rawValidatedToken);
            var jwtSecurityToken = (JwtSecurityToken)rawValidatedToken;

            // Attach the claimsPrincipal to the current HttpContext for further authorization
            context.HttpContext.User = claimsPrincipal;
        }
        catch (Exception ex)
        {
            context.HttpContext.Response.StatusCode = 401;
            await context.HttpContext.Response.WriteAsync("Token validation failed: " + ex.Message);
            return;
        }
    }
}
*/