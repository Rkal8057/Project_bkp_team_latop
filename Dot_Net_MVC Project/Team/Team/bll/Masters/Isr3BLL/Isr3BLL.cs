using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class Isr3BLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public Isr3BLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelIsr3Resp InsertIsr3(ModelIsr3Req isr3Req)
        {

            Isr_3 SampData = new Isr_3()
            {
                company_name = isr3Req.company_name,
                company_address = isr3Req.company_name,
                company_email = isr3Req.company_email,
                company_phone = isr3Req.company_phone,
                descriptions1 = isr3Req.descriptions1,
                descriptions2 = isr3Req.descriptions2,
                descriptions3 = isr3Req.descriptions3,
                Isr_3_securities = isr3Req.Isr_3_securities,
            };
            
            DB.Isr_3.Add(SampData);
            DB.SaveChanges();
            ModelIsr3Resp data = new ModelIsr3Resp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

    }
}