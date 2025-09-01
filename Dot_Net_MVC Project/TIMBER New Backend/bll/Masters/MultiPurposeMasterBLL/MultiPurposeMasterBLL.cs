using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class MultiPurposeMasterBLL
    {


        private loginDBContext DB;
        private string DBConnStr;
        public MultiPurposeMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public Multi_Purpose_Type_Master_ModelResponse InsertMulti_Purpose_Type_Master(Multi_Purpose_Type_Master_ModelRequest add,User_Detail user
            )
        {
            Multi_Purpose_Type_Master admit = new Multi_Purpose_Type_Master()
            {
                auto_id = add.auto_id,
                multi_purpose_flag = add.multi_purpose_flag,
                multi_purpose_code = add.multi_purpose_code,
                multi_purpose_type = add.multi_purpose_type,
                multi_purpose_remark = add.multi_purpose_remark,
                multi_purpose_delete_allow_yn = add.multi_purpose_delete_allow_yn,
                exchange_name = add.exchange_name,
                created_on = DateTime.Now,
                user_id = user.id,
                user_name = user.user_name,
                user_mobile = user.user_mobile,
                user_profile = user.user_profile,


            };
            DB.Multi_Purpose_Type_Master.Add(admit);
            DB.SaveChanges();
            Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
            {
                status = true,
                Message = "Inserted successfully"
            };
            return data;
        }
        public Multi_Purpose_Type_Master_ModelResponse UpdateMulti_Purpose_Type_Master(int ID, Multi_Purpose_Type_Master_ModelRequest add ,User_Detail user)
        {
            try
            {
                var result = DB.Multi_Purpose_Type_Master.FirstOrDefault(s => s.id == ID);
                if (result != null)
                {
                    result.auto_id = add.auto_id;
                    result.multi_purpose_flag = add.multi_purpose_flag;
                    result.multi_purpose_code = add.multi_purpose_code;
                    result.multi_purpose_type = add.multi_purpose_type;
                    result.multi_purpose_remark = add.multi_purpose_remark;
                    result.multi_purpose_delete_allow_yn = add.multi_purpose_delete_allow_yn;
                    result.exchange_name = add.exchange_name;
                    result.updated_on = DateTime.Now;
                    result.user_id = user.id;
                    result.user_name = user.user_name;
                    result.user_mobile = user.user_mobile;
                    result.user_profile = user.user_profile;


                    DB.SaveChanges();

                    return new Multi_Purpose_Type_Master_ModelResponse
                    {
                        status = true,
                        Message = "Updated successfully "
                    };
                }

                return new Multi_Purpose_Type_Master_ModelResponse
                {
                    status = false,
                    Message = "ID does Not exist"
                };
            }
            catch (Exception ex)
            {
                // Log the exception For debugging
                Console.WriteLine(ex.Message);

                return new Multi_Purpose_Type_Master_ModelResponse
                {
                    status = false,
                    Message = "An Error occurred While updating Multi_Purpose_Type_Master"
                };
            }
        }
        public Multi_Purpose_Type_Master_ModelResponse GetMulti_Purpose_Type_Master(string? search)
        {
            IQueryable<Multi_Purpose_Type_Master> query = DB.Multi_Purpose_Type_Master.AsQueryable();

            // Apply search filters if search string is provided
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x =>
                    x.auto_id.ToString().Contains(search) ||
                    x.multi_purpose_flag.ToString().Contains(search) ||
                    x.multi_purpose_code.ToString().Contains(search) ||
                    x.multi_purpose_type.ToString().Contains(search) ||
                    x.multi_purpose_remark.ToString().Contains(search) ||
                    x.multi_purpose_delete_allow_yn.ToString().Contains(search) ||
                    x.exchange_name.ToString().Contains(search)
                );
            }

            // Order the results by Id in descending order
            query = query.OrderByDescending(admission => admission.id);

            // Take only the top 10 results
            query = query.Take(10);
            // Execute the query and convert the results to a list
            List<Multi_Purpose_Type_Master> LocalDataList = query.ToList();

            Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
            {
                status = true,
                Message = "Data Fetched Successfully ",
                Data = LocalDataList
            };
            return data;
        }

        public Multi_Purpose_Type_Master_ModelResponse Get_All_Multi_Purpose_Type_Master()
        {
          
            Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
            {
                status = true,
                Message = "Data Fetched Successfully ",
                Data = DB.Multi_Purpose_Type_Master.ToList()
            };
            return data;
        }
       

    public Multi_Purpose_Type_Master_ModelResponse DeleteMulti_Purpose_Type_Master(int ID)
        {
            Multi_Purpose_Type_Master del = DB.Multi_Purpose_Type_Master.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("Record Not Found");
            }

            DB.Multi_Purpose_Type_Master.Remove(del);
            DB.SaveChanges();
            Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
            {
                status = true,
                Message = "Deleted successfully"
            };
            return data;
        }


    }
}
