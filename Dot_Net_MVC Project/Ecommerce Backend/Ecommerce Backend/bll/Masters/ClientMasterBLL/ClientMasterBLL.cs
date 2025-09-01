using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ClientMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ClientMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
           
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public ClientMasterResp GetClientMaster()
        {
            ClientMasterResp data = new ClientMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ClientMasterData = DB.ClientMaster.Where(e => e.client_status == 0).ToList()
            };
            return data;
        }


        public ClientMasterResp GetClientMasterById(long clientId)
        {
            ClientMasterResp data = new ClientMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ClientMasterDataByID = DB.ClientMaster.Where(e => e.client_status == 0 && e.id == clientId).FirstOrDefault()
            };
            return data;
        }

        public ClientMasterResp InsertClientMaster(ClientMasterReq samp)
        {
            ClientMaster SampData = new ClientMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                client_name = samp.client_name,
                client_feedback = samp.client_feedback,
                deleted = samp.deleted,
                img_url = samp.img_url,
                username = samp.username,
                created_on = DateTime.Now,
                updated_on = DateTime.Now
            };

            DB.ClientMaster.Add(SampData);
            DB.SaveChanges();
            ClientMasterResp data = new ClientMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ClientMasterResp UpdateClientMaster(long clientId, ClientMasterReq samp)
        {
            var existingClient = DB.ClientMaster.Find(clientId);

            if (existingClient == null)
            {
                ClientMasterResp data1 = new ClientMasterResp()
                {
                    status = false,
                    Message = "Client not found"
                };

                return data1;
            }

            existingClient.client_purchaser_code = samp.client_purchaser_code;
            existingClient.client_purchaser_name = samp.client_purchaser_name;
            existingClient.agent_code = samp.agent_code;
            existingClient.agent_name = samp.agent_name;
            existingClient.vender_code = samp.vender_code;
            existingClient.vender_name = samp.vender_name;
            existingClient.client_name = samp.client_name;
            existingClient.client_feedback = samp.client_feedback;
            existingClient.client_status = samp.client_status;
            existingClient.deleted = samp.deleted;
            existingClient.img_url = samp.img_url;
            existingClient.username = samp.username;
            existingClient.updated_on = DateTime.Now;
            DB.SaveChanges();

            ClientMasterResp data = new ClientMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public ClientMasterResp DeleteClientMaster(long clientId)
        {

            ClientMaster del = DB.ClientMaster.SingleOrDefault(parent => parent.id == clientId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.client_status = 1;
            DB.SaveChanges();

            ClientMasterResp data = new ClientMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}