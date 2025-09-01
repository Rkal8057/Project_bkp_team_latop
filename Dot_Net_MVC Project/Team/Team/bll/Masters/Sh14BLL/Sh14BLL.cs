using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class Sh14BLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public Sh14BLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelSh14Resp InsertSh14(ModelSh14Req sh14Req)
        {

            Sh_14 SampData = new Sh_14()
            {
                company_name = sh14Req.company_name,
                company_address = sh14Req.company_address,
                nominee_type_cancel = sh14Req.nominee_type_cancel,
                nominate_type_required = sh14Req.nominate_type_required,
                particulars_nominee_name = sh14Req.particulars_nominee_name,
                particulars_nominee_dob = sh14Req.particulars_nominee_dob,
                particulars_nominee_father_mother_spouse_name = sh14Req.particulars_nominee_father_mother_spouse_name,
                particulars_nominee_occupation = sh14Req.particulars_nominee_occupation,
                particulars_nominee_nationality = sh14Req.particulars_nominee_nationality,
                particulars_nominee_address_1 = sh14Req.particulars_nominee_address_1,
                particulars_nominee_address_2 = sh14Req.particulars_nominee_address_2,
                particulars_nominee_address_3 = sh14Req.particulars_nominee_address_3,
                particulars_nominee_city = sh14Req.particulars_nominee_city,
                particulars_nominee_pincode = sh14Req.particulars_nominee_pincode,
                particulars_nominee_email = sh14Req.particulars_nominee_email,
                particulars_nominee_security_holder = sh14Req.particulars_nominee_security_holder,
                minor_nominee_status = sh14Req.minor_nominee_status,
                minor_nominee_dob = sh14Req.minor_nominee_dob,
                minor_nominee_date_of_attaining_majority = sh14Req.minor_nominee_date_of_attaining_majority,
                minor_nominee_guardian_name = sh14Req.minor_nominee_guardian_name,
                minor_nominee_address_line_1 = sh14Req.minor_nominee_address_line_1,
                minor_nominee_address_line_2 = sh14Req.minor_nominee_address_line_2,
                minor_nominee_address_line_3 = sh14Req.minor_nominee_address_line_3,
                minor_nominee_city = sh14Req.minor_nominee_city,
                minor_nominee_pincode = sh14Req.minor_nominee_pincode,
                holder1 = sh14Req.holder1,
                holder2 = sh14Req.holder2,  
                holder3 = sh14Req.holder3,
                Sh_14_securities = sh14Req.Sh_14_securities,
            };


            DB.Sh_14.Add(SampData);
            DB.SaveChanges();
            ModelSh14Resp data = new ModelSh14Resp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }
    }
}