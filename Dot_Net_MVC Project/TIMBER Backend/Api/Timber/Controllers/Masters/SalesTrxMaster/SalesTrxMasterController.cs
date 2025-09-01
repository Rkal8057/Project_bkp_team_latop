using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB.Login;
using DB.Login.Tables;
using RTA.Masters;
using RTAAPI;
using RTA.Masters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesTrxMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public SalesTrxMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        //GET ALL RECORDS
        [HttpGet("getalldetail")]
        [Produces("application/json", Type = typeof(SalesTrxMasterResp))]
        public IActionResult GetSalesTrxMasterRecords()
        {
            try
            {
                SalesTrxMasterBLL sample = new SalesTrxMasterBLL(DBConnStr);

                var Res = sample.GetSalesTrxMaster();
                objAction = CreatedAtAction("GetSalesTrxMasterRecords", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSalesTrxMasterRecords", data);
                return objAction;
            }
        }


        [HttpGet("getdetailbyid")]
        [Produces("application/json", Type = typeof(SalesTrxMasterResp))]
        public IActionResult GetSalesTrxMasterByID(int id)
        {
            try
            {

                SalesTrxMasterBLL sample = new SalesTrxMasterBLL(DBConnStr);
                var Res = sample.GetSalesTrxMasterByID(id);
                objAction = CreatedAtAction("GetSalesTrxMasterByID", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesTrxMasterResp data = new SalesTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSalesTrxMasterByID", data);
                return objAction;
            }
        }





        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SalesTrxMasterResp))]
        public IActionResult InsertSalesTrxMasterByID( List <SalesTrxMasterReq> Data, 
            long grand_total, 
            long sales_master_id,
            decimal discount_percentage,
            decimal discount_amount,
            decimal grand_total_after_discount

            )
        {
            try
            {

                SalesTrxMasterBLL sample = new SalesTrxMasterBLL(DBConnStr);
                var Res = sample.InsertSalesTrxMaster(Data, grand_total,sales_master_id, discount_percentage, discount_amount,grand_total_after_discount);
                objAction = CreatedAtAction("GetSalesTrxMasterByID", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesTrxMasterResp data = new SalesTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSalesTrxMasterByID", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SalesTrxMasterResp))]
        public IActionResult UpdateSalesTrxMaster(long sale_master_id,
        [FromBody] List<SalesTrxMasterReq>samp ,
        long grand_total,decimal discount_percentage, decimal discount_amount,
        decimal grand_total_after_discount
        )
        {
            try
            {

                SalesTrxMasterBLL sample = new SalesTrxMasterBLL(DBConnStr);
                var Res = sample.UpdateSalesTrxMaster(sale_master_id, samp, grand_total,discount_percentage, discount_amount, grand_total_after_discount);
                objAction = CreatedAtAction("UpdateSalesTrxMaster", Res);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesTrxMasterResp data = new SalesTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSalesTrxMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SalesTrxMasterResp))]
        public IActionResult DeleteSalesTrxMaster(int id)
        {
            try
            {

                SalesTrxMasterBLL inwaard = new SalesTrxMasterBLL(DBConnStr);
                var Res = inwaard.DeleteSalesTrxMaster(id);
                objAction = CreatedAtAction("DeleteSalesTrxMaster", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesTrxMasterResp data = new SalesTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSalesTrxMaster", data);
                return objAction;
            }
        }
    }
}
