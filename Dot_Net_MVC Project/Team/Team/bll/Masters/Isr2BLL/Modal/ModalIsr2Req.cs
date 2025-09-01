using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace RTA.Masters.Models
{
    public class ModalIsr2Req
    {
        public string? bank_name { get; set; }
        public string? bank_branch_name { get; set; }
        public string? branch_address1 { get; set; }
        public string? branch_address2 { get; set; }
        public string? branch_address3 { get; set; }
        public string? branch_city { get; set; }
        public int branch_pin_code { get; set; }
        public long branch_phone { get; set; }
        public string? branch_email { get; set; }
        public long branch_account_number { get; set; }
        public DateTime account_opening_date { get; set; }
        public string? account_first_holder { get; set; }
        public string? account_joint1_holder { get; set; }
        public string? account_joint2_holder { get; set; }
        public IFormFile? account_holder1_photo { get; set; }
        public IFormFile? account_holder2_photo { get; set; }
        public IFormFile? account_holder3_photo { get; set; }
        public string? investor_address1 { get; set; }
        public string? investor_address2 { get; set; }
        public string? investor_address3 { get; set; }
        public string? investor_city { get; set; }
        public int investor_pin_code { get; set; }
        public long investor_number { get; set; }
        public string? investor_email { get; set; }
        public IFormFile investor_signature1 { get; set; }
        public IFormFile? investor_signature2 { get; set; }
        public IFormFile? investor_signature3 { get; set; }
        public string? bank_manager_name { get; set; }
        public string? employee_code { get; set; }
        public string? email_address { get; set; }
        public string? place { get; set; }
        public DateTime date { get; set; }
    }
}
