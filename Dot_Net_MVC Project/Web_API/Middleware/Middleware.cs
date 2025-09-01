using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web_API.Middleware
{
    public class Middleware : IMiddleware
    {
        private readonly IConfiguration _configuration;
        private readonly JwtSecurityTokenHandler _tokenHandler;

      /*  public Middleware(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenHandler = new JwtSecurityTokenHandler();
        }*/

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            string token = context.Request.Headers["Authorization"].ToString();
            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = 400; // Set the status code to 400 Bad Request
                await context.Response.WriteAsync("Token is required and must be in the 'Bearer' format.");
                return;
            }

            try
            {
                var jwtSettings = _configuration.GetSection("Jwt");
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

                var claimsPrincipal = _tokenHandler.ValidateToken(token, validationParameters, out var rawValidatedToken);
                var jwtSecurityToken = (JwtSecurityToken)rawValidatedToken;

                // Attach the claimsPrincipal to the current HttpContext for further authorization
                context.User = claimsPrincipal;


                await next(context); // Continue to the next middleware
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 401; // Set the status code to 401 Unauthorized
                await context.Response.WriteAsync("Token validation failed: " + ex.Message);
                return;
            }
        }
    }
}
