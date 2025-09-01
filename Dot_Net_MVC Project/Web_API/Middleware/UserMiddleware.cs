using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace Web_API.Middleware
{
    public class UserMiddleware : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Access IConfiguration using the HttpContext from the ServiceProvider
            var configuration = context.HttpContext.RequestServices.GetService<IConfiguration>();
            if (configuration == null)
            {
                throw new InvalidOperationException("IConfiguration is required but not available.");
            }

            string token = context.HttpContext.Request.Headers["Authorization"].ToString();
            if (string.IsNullOrEmpty(token))
            {
                context.HttpContext.Response.StatusCode = 400;
                await context.HttpContext.Response.WriteAsync("Token is required.");
                return;
            }

            try
            {
                //var jwtSettings = configuration.GetSection("Jwt");
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

                await next();
            }
            catch (Exception ex)
            {
                context.HttpContext.Response.StatusCode = 401;
                await context.HttpContext.Response.WriteAsync("Token validation failed: " + ex.Message);
                return;
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class UserMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserMiddleware>();
        }
    }
}
