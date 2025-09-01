using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Assign_1.Models
{
    public class User
    {
     /* private DateTime CreateAt = DateTime.Now; */
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }
       /* public int Otp { get; set; }
        public string Auth_Token { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean verify { get; set; }
        
        [Display(Name = "Created At")]
        public System.DateTime CreatedAt { get; set; }

        [Display(Name = "Updated At")]
        public System.DateTime UpdatedAt { get; set; }

        [Display(Name = "Deleted At")]
        public string DeletedAt { get; set; }*/
    }
}