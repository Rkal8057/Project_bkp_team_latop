using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("userId")]
        public int? userId { get; set; }  // Specify the foreign key property name   
        public string FileName { get; set; } = "";
        public string FilePath { get; set; } = "";   
        public DateTime UploadDate { get; set; } = DateTime.Now;
        public DateTime UploadTime { get; set; } = new DateTime();
        public virtual User User { get; set; }
    }
}
