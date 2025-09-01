using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Assign_1.Models
{
    public class Query
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        [Display(Name = "Created At")]
        public DateTime  createdAt { get; set;} = DateTime.UtcNow;

        [Display(Name = "Updated At")]
        public DateTime updatedAt { get; set; } = DateTime.UtcNow; 

    }
}