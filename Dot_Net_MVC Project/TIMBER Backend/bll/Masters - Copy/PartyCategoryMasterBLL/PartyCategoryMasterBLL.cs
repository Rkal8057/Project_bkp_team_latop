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
    public class PartyCategoryMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public PartyCategoryMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public PartyCategoryMasterResp InsertPartyCategoryMaster(PartyCategoryMasterReq samp)
        {
            PartyCategoryMaster categoryObj = new PartyCategoryMaster
            {
                party_category_name = samp.party_category_name
            };

            DB.PartyCategoryMaster.Add(categoryObj);
            DB.SaveChanges();

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "Inserted successfully"
            };

          
            return data;
        }


        public PartyCategoryMasterResp GetAllPartyCategoryMaster()
        {

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyCategoryMasterData = DB.PartyCategoryMaster.ToList(),

            };
            return data;
        }

        public PartyCategoryMasterResp GetPartyCategoryMasterById(long partyCategoryId)
        {

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyCategoryMasterByID = DB.PartyCategoryMaster.FirstOrDefault(e => e.id == partyCategoryId)
            };


            return data;
        }

        public PartyCategoryMasterResp UpdatePartyCategoryMaster(long categoryId, PartyCategoryMasterReq samp)
        {
            var existingCategory = DB.PartyCategoryMaster.Find(categoryId);

            if (existingCategory == null)
            {

                PartyCategoryMasterResp data1 = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existingCategory.party_category_name = samp.party_category_name;

            DB.SaveChanges();

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public PartyCategoryMasterResp DeletePartyCategoryMaster(long partyCategoryId)
        {

            PartyCategoryMaster del = DB.PartyCategoryMaster
                                            .SingleOrDefault(parent => parent.id == partyCategoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            DB.PartyCategoryMaster.Remove(del);
            DB.SaveChanges();

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }




        }
    }