using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_API.InterfaceModel
{
    public class UserReq
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar(250)")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required.")]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar(250)")]
        public string? PasswordConfirmed { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be a 10-digit numeric value.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? PhoneNumber { get; set; }
    }
}
