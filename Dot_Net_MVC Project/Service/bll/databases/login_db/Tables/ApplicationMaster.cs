using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace DB.Login.Tables
{
    public class ApplicationMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint auto_increment")]
        public long id { get; set;}

        [Column("first_email", Order = 2, TypeName = "text")]
        public string? first_email { get; set; }

        [Column("first_addres", Order = 3, TypeName = "text")]
        public string? first_addres { get; set; }

        [Column("first_city", Order = 4, TypeName = "text")]
        public string? first_city { get; set; }

        [Column("first_state", Order = 5, TypeName = "text")]
        public string? first_state { get; set; }

        [Column("first_pincode", Order = 6, TypeName = "text")]
        public string? first_pincode { get; set; }

        [Column("first_mobile", Order = 7, TypeName = "text")]
        public string? first_mobile { get; set; }

        [Column("date", Order = 8, TypeName = "date")]
        public DateTime? date { get; set; }

        [Column("second_name", Order = 9, TypeName = "text")]
        public string? second_name { get; set; }

        [Column("second_address", Order = 10, TypeName = "text")]
        public string? second_address { get; set; }

        [Column("second_city", Order = 11, TypeName = "text")]
        public string? second_city { get; set; }

        [Column("second_state", Order = 12, TypeName = "text")]
        public string? second_state { get; set; }

        [Column("second_pincode", Order = 13, TypeName = "text")]
        public string? second_pincode { get; set; }

        [Column("subject", Order = 14, TypeName = "text")]
        public string? subject { get; set; }

        [Column("total_day", Order = 15, TypeName = "text")]
        public string? total_day { get; set; }

        [Column("type_of_leave", Order = 16, TypeName = "text")]
        public string? type_of_leave { get; set; }

        [Column("coWorker_name", Order = 17, TypeName = "text")]
        public string? coWorker_name { get; set; }

        [Column("start_date", Order = 18, TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column("end_date", Order = 19, TypeName = "date")]
        public DateTime? end_date { get; set; }

        [Column("coming_date", Order = 20, TypeName = "date")]
        public DateTime? coming_date { get; set; }

        [Column("disease", Order = 21, TypeName = "text")]
        public string? disease { get; set; }

        [Column("file_path", Order = 22, TypeName = "text")]
        public string? file_path { get; set; }

        [Column("designation", Order = 23, TypeName = "text")]
        public string? designation { get; set; }

        [Column("logo_image", Order = 24, TypeName = "text")]
        public string? logo_image { get; set; }

        [Column("sign_image", Order = 25, TypeName = "text")]
        public string? sign_image { get; set; }

    }
}
