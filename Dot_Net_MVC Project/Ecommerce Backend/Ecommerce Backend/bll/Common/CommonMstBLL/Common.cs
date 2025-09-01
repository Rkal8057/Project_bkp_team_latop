using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DB.Login;
using DB.Login.Tables;
using RTA.Common.Models;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace RTA.Common;
public class CommonMstBLL
{
    private loginDBContext DB;
    private string DBConnStr;
    //private static string number;

    public CommonMstBLL(string _DBConnStr)
    {
        DBConnStr = _DBConnStr;
        DB = loginDBContextFactory.Create(DBConnStr);
    }

    public string GetComp_DB_ConnStr(long comp_id)
    {

        var DB_Cred = DB.Comp_DB.Where(c => c.CompMstId == comp_id).First();

        return "SERVER=" + DB_Cred.server +
                 ";PORT=3306;DATABASE=" + DB_Cred.db_name +
                 ";USER ID=" + DB_Cred.db_user +
                 ";PASSWORD=" + DB_Cred.db_pass + ";";

    }
    public (string, bool) GetComp_DB_ConnStrBy_IsinNo(string isin_No,out string company_Name)
    {
        try
        {
            var compid = DB.Comp_Selection_Master.Where(c => c.c_comp_isin == isin_No).FirstOrDefault();
            if (compid != null)
            {
                company_Name = compid.c_comp_name;
                var DB_Cred = DB.Comp_DB.Where(c => c.CompMstId == compid.id).FirstOrDefault();

                if (DB_Cred != null)
                {
                    return ("SERVER=" + DB_Cred.server +
                            ";PORT=3306;DATABASE=" + DB_Cred.db_name +
                            ";USER ID=" + DB_Cred.db_user +
                            ";PASSWORD=" + DB_Cred.db_pass + ";", true);
                }
                else
                {
                    return ("Invalid database configuration for company", false);
                }
            }
            else
            {
                company_Name = null;
                return ("No company available for the given Isin No", false);
                
            }
        }
        catch (Exception ex)
        {
            company_Name = null;
            // Log the exception or handle it appropriately
            return ($"Error: {ex.Message}", false);
        }
    }

    public bool Gettemporaryfile(string isin_No, string fileName, string formName)
    {
        try
        {
            var temporaryFile = DB.TemporaryFile.Where(c => c.file_name == fileName && c.comp_ISIN== isin_No && c.form_name== formName).FirstOrDefault();
            if (temporaryFile != null)
            {
                return true;
            }
            else
            {
                temporaryFile = new TemporaryFile();
                temporaryFile.comp_ISIN = isin_No;
                temporaryFile.form_name = formName;
                temporaryFile.file_name = fileName;
                DB.TemporaryFile.Add(temporaryFile);
                DB.SaveChanges();
                return true;
            }            
        }
        catch (Exception ex)
        {
            // Log the exception or handle it appropriately
            return  true;
        }
    }

    public void Addtemporaryfile(string isin_No, string fileName, string formName)
    {
        try
        {
            var temporaryFile = DB.TemporaryFile.Where(c => c.file_name == fileName && c.comp_ISIN == isin_No && c.form_name == formName).FirstOrDefault();
            if (temporaryFile == null)
            {
                temporaryFile = new TemporaryFile();
                temporaryFile.comp_ISIN = isin_No;
                temporaryFile.form_name = formName;
                temporaryFile.file_name = fileName;
                DB.TemporaryFile.Add(temporaryFile);
                DB.SaveChanges();
            }
            
        }
        catch (Exception ex)
        {

        }
    }
    public bool IsPhoneValid(string phoneNumber)
    {
        string regex = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";
        if (phoneNumber != null)
            return Regex.IsMatch(phoneNumber, regex);
        else return false;
    }

    // public object GetDrpDownData(string tbl_name,string column_name)
    // {
    //     var List = DB.Database.ExecuteSqlRaw("Select"+ column_name +" from " + tbl_name );

    //     return List;
    // }


}
