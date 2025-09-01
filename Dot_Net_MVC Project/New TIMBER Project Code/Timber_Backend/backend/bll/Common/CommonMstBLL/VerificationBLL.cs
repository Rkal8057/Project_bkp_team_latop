using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login;
using DB.Login.Tables;

namespace RTA.Common;

public class VerificationBLL

{
    private loginDBContext DB;
    private string DBConnStr;
    public VerificationBLL(string _DBConnStr)
    {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
    }

    // public Forms_Trx_Master VerifyUserRights(long FormId, long UserCode)
    //     {
           
    //         var userRights = DB.Forms_Trx_Master.Where(x=>x.form_master_id==FormId && x.user_code==UserCode).FirstOrDefault();
    //         if(userRights==null)
    //         {
    //             throw new Exception("No Rights allotted to the user"); 
    //         }

    //         return userRights;
    //     }
}