using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class CategoryMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CategoryMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public CategoryMasterResp InsertCategoryMaster(CategoryMasterReq samp)
        {
          
            CategoryMaster categoryObj = new CategoryMaster()
            {
                service_type = samp.service_type,
                approx_amount = samp.approx_amount,
                approx_days = samp.approx_days,
                service_id = samp.service_id
            };

            DB.CategoryMaster.Add(categoryObj);
            DB.SaveChanges();

            List<CheckListMaster> checklistItems = samp.CheckListMaster.Select(item => new CheckListMaster
            {
                document_required_name = item.document_required_name,
                document_required_type = item.document_required_type,
                category_id = categoryObj.id
            }).ToList();

            DB.CheckListMaster.AddRange(checklistItems);
            DB.SaveChanges();


            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        public CategoryMasterResp DeleteCategoryMaster(long id)
        {
            CategoryMaster del = DB.CategoryMaster
            .Include(x => x.CheckListMaster)
            .SingleOrDefault(x => x.id == id);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            if (del.CheckListMaster.Count > 0)
            {
                DB.CheckListMaster.RemoveRange(del.CheckListMaster);
            }
            DB.CategoryMaster.Remove(del);
            DB.SaveChanges();

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}