using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DB.Login;
using DB.Login.Tables;
using RTA.Common.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Dynamic;

namespace RTA.Common;
public class CommonMstBLL
{
    private loginDBContext DB;
    private string DBConnStr;
    public CommonMstBLL(string _DBConnStr)
    {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
    }

    public string GetComp_DB_ConnStr(long comp_id)
    {
      
       var DB_Cred =  DB.Comp_DB.Where(c => c.CompMstId == comp_id).First();

       return "SERVER=" + DB_Cred.server +
                ";PORT=3306;DATABASE=" + DB_Cred.db_name +
                ";USER ID=" + DB_Cred.db_user +
                ";PASSWORD=" + DB_Cred.db_pass + ";";
        

    }

 
    public object GetDrpDownData(string tbl_name,string column_name)
    {
        var List = DB.Database.ExecuteSqlRaw("Select"+ column_name +" from " + tbl_name );

        return List;
    }
    

}
