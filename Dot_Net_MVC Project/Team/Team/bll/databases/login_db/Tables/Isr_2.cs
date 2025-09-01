using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Isr_2
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("bank_name", Order = 2, TypeName = "text")]
        public string bank_name { get; set; }

        [Column("bank_branch_name", Order = 3, TypeName = "text")]
        public string bank_branch_name { get; set; }

        [Column("branch_address1", Order = 4, TypeName = "text")]
        public string branch_address1 { get; set; }

        [Column("branch_address2", Order = 5, TypeName = "text")]
        public string branch_address2 { get; set; }

        [Column("branch_address3", Order = 6, TypeName = "text")]
        public string branch_address3 { get; set; }

        [Column("branch_city", Order = 7, TypeName = "text")]
        public string branch_city { get; set; }

        [Column("branch_pin_code", Order = 8, TypeName = "int(6)")]
        public int branch_pin_code { get; set; }

        [Column("branch_phone", Order = 9, TypeName = "bigint")]
        public long branch_phone { get; set; }

        [Column("branch_email", Order = 10, TypeName = "text")]
        public string branch_email { get; set; }

        [Column("branch_account_number", Order = 11, TypeName = "bigint")]
        public long branch_account_number { get; set; }

        [Column("account_opening_date", Order = 12, TypeName = "Date")]
        public DateTime account_opening_date { get; set; }

        [Column("account_first_holder", Order = 13, TypeName = "text")]
        public string account_first_holder { get; set; }

        [Column("account_joint1_holder", Order = 14, TypeName = "text")]
        public string account_joint1_holder { get; set; }

        [Column("account_joint2_holder", Order = 15, TypeName = "text")]
        public string account_joint2_holder { get; set; }

        [Column("account_holder1_photo", Order = 16, TypeName = "text")]
        public string account_holder1_photo { get; set; }

        [Column("account_holder2_photo", Order = 17, TypeName = "text")]
        public string account_holder2_photo { get; set; }

        [Column("account_holder3_photo", Order = 18, TypeName = "text")]
        public string account_holder3_photo { get; set; }

        [Column("investor_address1", Order = 19, TypeName = "text")]
        public string investor_address1 { get; set; }

        [Column("investor_address2", Order = 20, TypeName = "text")]
        public string investor_address2 { get; set; }

        [Column("investor_address3", Order = 21, TypeName = "text")]
        public string investor_address3 { get; set; }

        [Column("investor_city", Order = 22, TypeName = "text")]
        public string investor_city { get; set; }

        [Column("investor_pin_code", Order = 23, TypeName = "int")]
        public int investor_pin_code { get; set; }

        [Column("investor_number", Order = 24, TypeName = "bigint")]
        public long investor_number { get; set; }

        [Column("investor_email", Order = 25, TypeName = "text")]
        public string investor_email { get; set; }

        [Column("investor_signature1", Order = 26, TypeName = "text")]
        public string investor_signature1 { get; set; }

        [Column("investor_signature2", Order = 27, TypeName = "text")]
        public string investor_signature2 { get; set; }

        [Column("investor_signature3", Order = 28, TypeName = "text")]
        public string investor_signature3 { get; set; }

        [Column("bank_manager_name", Order = 29, TypeName = "text")]
        public string bank_manager_name { get; set; }

        [Column("employee_code", Order = 30, TypeName = "text")]
        public string employee_code { get; set; }

        [Column("email_address", Order = 31, TypeName = "text")]
        public string email_address { get; set; }

        [Column("place", Order = 32, TypeName = "text")]
        public string place { get; set; }

        [Column("date", Order = 33, TypeName = "date")]
        public DateTime date { get; set; }
       
    }
}
