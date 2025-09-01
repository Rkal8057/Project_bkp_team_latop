namespace RTA.Admin.Models
{
    public class ModelRegistrationReq
    {

        public long id { get; set; }
        public string user_name { get; set; }
        public long user_mobile { get; set; }
        public string user_email { get; set; }
        public string? user_pancard { get; set; }
        public string user_pass { get; set; }
        public string confirm_user_pass { get; set; }
        //public string u_mobile { get; set; }
        //public string u_email { get; set; }
        //public string ?u_pancard { get; set; }




    }
}