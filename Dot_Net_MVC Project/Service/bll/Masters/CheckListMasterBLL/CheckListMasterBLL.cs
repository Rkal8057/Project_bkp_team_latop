using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class CheckListMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CheckListMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public CheckListMasterResp UpdateCheckListMaster(int id, string document_required_name, string document_required_type)
        {


            CheckListMaster checklist = DB.CheckListMaster.FirstOrDefault(x => x.id == id);
            checklist.document_required_name = document_required_name;
            checklist.document_required_type = document_required_type;

            DB.CheckListMaster.Update(checklist);
            DB.SaveChanges();
            CheckListMasterResp data = new CheckListMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public CheckListMasterResp DeleteCheckListMaster(long id)
        {
            CheckListMaster del = DB.CheckListMaster.Where(x => x.id == id).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.CheckListMaster.Remove(del);
            DB.SaveChanges();
            CheckListMasterResp data = new CheckListMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

        public CheckListMasterResp InsertCheckListMaster(List<CheckListMasterReq> samp)
        {
            List<CheckListMaster> entitiesToInsert = new List<CheckListMaster>();
            foreach (var item in samp)
            {
                CheckListMaster entity = new CheckListMaster
                {
                        document_required_name  =item.document_required_name,
                        document_required_type=item.document_required_type,
                        category_id =   item.category_id
                };

                entitiesToInsert.Add(entity);
            }

            // Bulk insert
            DB.CheckListMaster.AddRange(entitiesToInsert);
            DB.SaveChanges();
            //var customers = new List<object>
            //{
            //    new  { Name = "John Smith", Age = 30 },
            //    new  { Name = "Jane Doe", Age = 25 },
            //    new  { Name = "Bob Johnson", Age = 40 },
            //};

            //DB.CheckListMaster.BulkInsert(customers);
            CheckListMasterResp data = new CheckListMasterResp()
            {
                status = true,
                Message = "Inserted successfully"
            };

            return data;
        }

    }
}