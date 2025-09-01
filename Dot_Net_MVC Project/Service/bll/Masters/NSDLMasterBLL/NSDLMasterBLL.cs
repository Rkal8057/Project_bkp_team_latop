using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RTA.Masters
{
    public class NSDLMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public NSDLMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public NSDLMasterResp GetNSDLMaster()
        {           

            NSDLMasterResp data = new NSDLMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                NSDLMasterData = DB.NSDLMaster.ToList(),
                
            };

            return data;
        }

        public NSDLMasterResp GetNSDLMasterByID(long Id)
        {

            NSDLMasterResp data = new NSDLMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                NSDLMasterDataByID = DB.NSDLMaster.Where(e => e.id == Id).SingleOrDefault()

            };

            return data;
        }

    }
}