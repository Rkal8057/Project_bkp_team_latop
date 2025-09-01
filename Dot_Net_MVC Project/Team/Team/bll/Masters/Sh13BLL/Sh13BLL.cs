using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class Sh13BLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public Sh13BLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelSh13Resp InsertSh13(ModelSh13Req sh13Req)
        {

            Sh_13 SampData = new Sh_13()
            {
                company_name = sh13Req.company_name,
                company_address = sh13Req.company_address,
                descriptions1 = sh13Req.descriptions1,
                descriptions2 = sh13Req.descriptions2,
                descriptions3 = sh13Req.descriptions3,
                particulars_nominee_name = sh13Req.particulars_nominee_name,
                particulars_nominee_dob = sh13Req.particulars_nominee_dob,
                particulars_nominee_father_mother_spouse_name = sh13Req.particulars_nominee_father_mother_spouse_name,
                particulars_nominee_occupation = sh13Req.particulars_nominee_occupation,
                particulars_nominee_nationality = sh13Req.particulars_nominee_nationality,
                particulars_nominee_address_1 = sh13Req.particulars_nominee_address_1,
                particulars_nominee_address_2 = sh13Req.particulars_nominee_address_2,
                particulars_nominee_address_3 = sh13Req.particulars_nominee_address_3,
                particulars_nominee_city = sh13Req.particulars_nominee_city,
                particulars_nominee_pincode = sh13Req.particulars_nominee_pincode,
                particulars_nominee_email = sh13Req.particulars_nominee_email,
                particulars_nominee_security_holder = sh13Req.particulars_nominee_security_holder,
                minor_nominee_status = sh13Req.minor_nominee_status,
                minor_nominee_dob = sh13Req.minor_nominee_dob,
                minor_nominee_date_of_attaining_majority = sh13Req.minor_nominee_date_of_attaining_majority,
                minor_nominee_guardian_name = sh13Req.minor_nominee_guardian_name,
                minor_nominee_address_line_1 = sh13Req.minor_nominee_address_line_1,
                minor_nominee_address_line_2 = sh13Req.minor_nominee_address_line_2,
                minor_nominee_address_line_3 = sh13Req.minor_nominee_address_line_3,
                minor_nominee_city = sh13Req.minor_nominee_city,
                minor_nominee_pincode = sh13Req.minor_nominee_pincode,
                Sh_13_securities = sh13Req.Sh_13_securities,
            };


            DB.Sh_13.Add(SampData);
            DB.SaveChanges();
            ModelSh13Resp data = new ModelSh13Resp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }
    }
}