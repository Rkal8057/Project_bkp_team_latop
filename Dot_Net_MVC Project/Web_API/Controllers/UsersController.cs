using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_API.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Web_API.Middleware;
using System.Linq;



using System.Net.Http;
using Web_API.Migrations;
using Web_API.InterfaceModel;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using System.Text.Json;
using static Web_API.Validations.CommonValidation;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DBContext _context;
        private readonly HttpClient _httpClient;

        public UsersController(DBContext context, IConfiguration configuration, HttpClient httpClient)
        {
            _context = context;
            _configuration = configuration;
            _httpClient = httpClient;
        }

        [HttpGet]
        //[Authorize(Policy = "CustomPolicy")]
        [Route("getAllUsers")]
        public async Task<ActionResult> GetAllUser()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                return Ok(new { Message = "List of Users", StatusCode = 200, Data = users });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
        }

        [HttpGet]
        //[CustomMiddleware] 
        [Route("{id}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            try
            {
               /* var userIdClaim = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                var usernameClaim = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
                var customClaim = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "CustomClaim");

                //contains all claims from the user's identity
                var allClaims = HttpContext.User.Claims.ToList();

                Console.WriteLine(userIdClaim );
                Console.WriteLine(usernameClaim );
                Console.WriteLine(customClaim );*/

                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound("User not found.");
                }
                return Ok(new { Message = "User detail ", StatusCode = 200, Data = user });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
        }

        [HttpPost]
        //[ValidationActionFilterAttribute]
        //[UserMiddleware]
        [Route("create")]
        public async Task<ActionResult> Create([FromBody] UserReq user)
        {
            try
            {
                var newUser = new User
                {
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    PasswordConfirmed = user.PasswordConfirmed,
                    PhoneNumber = user.PhoneNumber
                };

                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return Ok(new { Message = "new user create", StatusCode = 200, Data = true });

            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> Update([FromQuery]  int id, string Name , string PhoneNumber)
        {
            try
            {
                if(id== null)
                {
                    return NotFound("User not found.");

                }

                var existingUser = await _context.Users.FindAsync(id);
                if (existingUser == null)
                {
                    return NotFound("User not found.");
                }


                existingUser.Name = Name;
                //existingUser.Email = updatedUser.Email;
                //existingUser.Password = updatedUser.Password;
                //existingUser.PasswordConfirmed = updatedUser.PasswordConfirmed;
                existingUser.PhoneNumber = PhoneNumber;



                /*  _context.Entry(updatedUser).State = EntityState.Modified;
                  await _context.SaveChangesAsync(); */

                await _context.SaveChangesAsync();
                return Ok(new { Message = "User profile updated successfully.", StatusCode = 200, Data = true });

            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var existingUser = await _context.Users.FindAsync(id);
                if (existingUser == null)
                {
                    return NotFound("User not found.");
                }


                /*  _studentDbContext.Entry(student).State = EntityState.Deleted;
                  _studentDbContext.SaveChanges();*/
                _context.Users.Remove(existingUser);
                _context.SaveChanges();

                return Ok(new { Message = "User deleted successfully.", StatusCode = 200, Data = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult> UserLogin([FromQuery] string Email,string Password)
        {
            try
            {
                var emailCheck = await _context.Users.FirstOrDefaultAsync(u => u.Email == Email);
                if (emailCheck == null)
                {
                    return NotFound(new { Message = "Email not found.", StatusCode = 404, Data = false });
                }

                if (emailCheck.Password != Password)
                {
                    return BadRequest(new { Message = "Password does not match.", StatusCode = 400, Data = false});
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var now = DateTime.UtcNow;
                var expires = DateTime.UtcNow.AddMinutes(30);

                var claims = new[]
                {
                    new Claim(ClaimTypes.Email, Email),
                    new Claim(ClaimTypes.Name, emailCheck?.Name),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim("CustomClaim", "customClaim"), // Include custom claim
                    new Claim(ClaimTypes.NameIdentifier, emailCheck?.Id.ToString()) // Assuming Id is of integer type
                };
               
            
                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audiance"],
                    claims: claims,
                    notBefore: now,
                    expires: expires,
                    signingCredentials: creds
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                var obj = new Token
                {
                    UserId = emailCheck.Id,
                    Tokens = tokenString,
                    FcmToken = "",
                    DeviceId = ""
                };

                var existingToken = await _context.Tokens.FindAsync(emailCheck.Id);
                if (existingToken != null)
                {
                    existingToken.Tokens = tokenString;
                    existingToken.FcmToken = "NewFcmToken1"; // Update with the new FcmToken value
                    existingToken.DeviceId = "NewDeviceId1"; // Update with the new DeviceId value
                    await _context.SaveChangesAsync();
/*                    return Ok(new { Message = "User Login successfully.", StatusCode = 200, Data = tokenString });
*/
                }
                else
                {
                    _context.Tokens.AddAsync(obj);
                    _context.SaveChanges();
/*                    return Ok(new { Message = "User Login successfully.", StatusCode = 200, Data = tokenString });
*/
                }

                return Ok(new { Message = "User Login successfully.", StatusCode = 200, Data = tokenString });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "An error occurred", StatusCode = 400, Data = ex.Message});
            }
        }

        [AllowAnonymous]
        [HttpPost("thirdAPICall")]
        public async Task<ActionResult> APIcall()
        {
            try
            {
                var apiUrl = "http://127.0.0.1:9000/users/search?searchKey=rohit&page=1&limit=50&userId=64fee49448454e33c93fdd7a"; // Replace with your API URL

                var url = "https://api.suvajitroy.in/api/CheckLogin?Mobile=8327347078";

                // Construct the URL with the query parameters
                var response = await _httpClient.PostAsync(apiUrl, null);
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content if needed
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return Content(responseContent, "application/json");
                }
                else
                {
                    // Handle API error response (e.g., return a specific error message)
                    return BadRequest("API request failed"+response);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("userdetail/{id}")]
            public async Task<ActionResult> GetUserDetail(int id)
            {
            try
            {
                if (id == null)
                {
                    return BadRequest("Id did not found.");
                }
                //var result = from user in _context.Users
                //             join file in _context.Files on user.Id equals file.userId
                //             select new
                //             {
                //                 UserName = user.Name,
                //                 FileId = file.Id,
                //                 FileName = file.FileName,
                //                
                //                 UploadDate = file.UploadDate,
                //                 UploadTime = file.UploadTime
                //             };
                var result = _context.Users.Include(r => r.Files)
                   .Where(r => r.Id == id).FirstOrDefault();
                if (result == null)
                {
                    return NotFound("result not found.");
                }

               

                return Ok(result);
            }

            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error!!", StatusCode = 400, Data = ex.Message });
            }
            }


        [HttpGet]
        [Route("SearchUser/{searchKeyword}")]

        public async Task<ActionResult> GetSearchUser(string searchKeyword)
        {
            try
            {
                if (searchKeyword == null)
                {
                    return BadRequest("searchKeyword did not found.");
                }
                List<User> user = new List<User>();

                var results = _context.Users.Include(u => u.Files)
                .Where(user =>
                    EF.Functions.Like(user.Name, $"%{searchKeyword}%") || // Search by first name
                    EF.Functions.Like(user.Email, $"%{searchKeyword}%")   // Search by email
                ).ToList();
                if (results == null)
                {
                    return NotFound("result not found.");
                }

                var apiResponse = new ApiResponse<List<User>>
                {
                    Success = true,
                    Message = "Success",
                    Data = results
                };

                return Ok(apiResponse);

            }
            catch (Exception ex)
            {
                return BadRequest("Erro!"+ ex.Message);
            }

        }


        [HttpGet]
        [Route("run")]
        public IActionResult runDat()
        { 
            try
            {
               
                var result = _context.Users
                .GroupJoin(_context.Tokens,
                users => users.Id,
                tokens => tokens.UserId,
                (user, token) => new
                {
                    UserDetail = user,
                    Tokens = token.Select(item => new
                    {
                        Id = item.Id,
                        Token = item.Tokens
                    })
                }).ToList();

                return Ok(result);

            }catch (Exception ex) { 
            return BadRequest(ex.Message);
            }
        }


        
    }
}
