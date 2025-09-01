using DB.Login.Tables;

namespace RTA.Admin.Models
{
    public class ModelRegistrationResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public User_Detail? User_Detail { get; set; }
        //ErrorMessage
    }
}
