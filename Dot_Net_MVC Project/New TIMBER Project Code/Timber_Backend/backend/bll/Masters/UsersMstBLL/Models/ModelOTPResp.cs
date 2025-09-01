using DB.Login.Tables;

namespace RTA.Admin.Models
{
    public class ModelOTPResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public string? Otp { get; set; }
        public object? otp_transaction { get; set; }

        
    }
}
