using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;


namespace RTA.Masters{
   
public class ReqRecBLL
{
        private loginDBContext DB;
        private string DBConnStr;
        public ReqRecBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelReqResp GetRecordData()
        {
            ModelReqResp data = new ModelReqResp()
            {
                status = true,
                Message = "Data fetched successfully",
                ReqData = DB.Req_Rec_Master.ToList()
                
            };
            return data;
        }

        public ModelReqResp GetRecordDataById(int id)
        {
            ModelReqResp data = new ModelReqResp()
            {
                status = true,
                Message = "Data fetched successfully",
                ReqDatabyId = DB.Req_Rec_Master.Where(e => e.id == id).SingleOrDefault()

            };
            return data;
        }

        public ModelReqResp InsertSample(ModelReq samp)
        {
            Req_Rec_Master ReqData = new Req_Rec_Master()
            {
                req_id = samp.req_id,
                req_status = samp.req_status,
                reject_code = samp.reject_code,
            };

            DB.Req_Rec_Master.Add(ReqData);
            DB.SaveChanges();
            ModelReqResp data = new ModelReqResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ModelReqResp UpdateSample(long ID, ModelReq samp)
        {
            Console.WriteLine(samp);
            Console.WriteLine(ID);


            /*  Req_Rec_Master update = DB.Req_Rec_Master.Where(x => x.id == ID).SingleOrDefault();

              if (update == null)
              {
                  throw new Exception("RECORD NOT FOUND");
              }*/
            /* update.req_id = samp.req_id;
             update.req_status = samp.req_status;
             update.reject_code = samp.reject_code;*/
            Req_Rec_Master ReqData = new Req_Rec_Master()
            {
                id = ID,
                req_id = samp.req_id,
                req_status = samp.req_status,
                reject_code = samp.reject_code,
            };

            /*            DB.Req_Rec_Master.Update(ReqData);
            */

            /*            DB.Req_Rec_Master.Update(update);*/

            /*            DB.Entry(ReqData).State = EntityState.Modified;
            */
            DB.Req_Rec_Master.Update(ReqData);
            DB.SaveChanges();
            ModelReqResp data = new ModelReqResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public ModelReqResp DeleteSample(int id)
        {
            Req_Rec_Master del = DB.Req_Rec_Master.Where(x => x.id == id).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.Req_Rec_Master.Remove(del);
            DB.SaveChanges();
            ModelReqResp data = new ModelReqResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }
}

