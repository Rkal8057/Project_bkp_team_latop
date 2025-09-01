using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelSh14Req
    {
        public string? company_name { get; set; }
        public string? company_address { get; set; }
        public string? nominee_type_cancel { get; set; }
        public string? nominate_type_required { get; set; }
        public string? particulars_nominee_name { get; set; }
        public DateTime? particulars_nominee_dob { get; set; }
        public string? particulars_nominee_father_mother_spouse_name { get; set; }
        public string? particulars_nominee_occupation { get; set; }
        public string? particulars_nominee_nationality { get; set; }
        public string? particulars_nominee_address_1 { get; set; }
        public string? particulars_nominee_address_2 { get; set; }
        public string? particulars_nominee_address_3 { get; set; }
        public string? particulars_nominee_city { get; set; }
        public long? particulars_nominee_pincode { get; set; }
        public string? particulars_nominee_email { get; set; }
        public string? particulars_nominee_security_holder { get; set; }
        public bool? minor_nominee_status { get; set; }
        public DateTime? minor_nominee_dob { get; set; }
        public DateTime? minor_nominee_date_of_attaining_majority { get; set; }
        public string? minor_nominee_guardian_name { get; set; }
        public string? minor_nominee_address_line_1 { get; set; }
        public string? minor_nominee_address_line_2 { get; set; }
        public string? minor_nominee_address_line_3 { get; set; }
        public string? minor_nominee_city { get; set; }
        public long? minor_nominee_pincode { get; set; }
        public string? holder1 { get; set; }
        public string? holder2 { get; set; }
        public string? holder3 { get; set; }
        public virtual ICollection<Sh_14_securities>? Sh_14_securities { get; set; }
    }
}
