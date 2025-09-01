using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserId is required.")]
        [Column(TypeName = "int")] 
        public int UserId { get; set; }

        [Required(ErrorMessage = "Token is required.")]
        [Column(TypeName = "nvarchar(1000)")]
        public string?Tokens { get; set; }
       
        [Column(TypeName = "nvarchar(1000)")]
        public string? FcmToken { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? DeviceId { get; set; }

    }
}
