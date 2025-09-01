using CsvHelper;
using System.Globalization;
using static System.Console;
using RTA.Common.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.RegularExpressions;
using DB.Login;
using DB.RTAComp;
using DB.Login.Tables;
using DB.RTAComp.Tables;

namespace RTA.Common;
public class FilesMstBLL
{
    private compDbContext CompDB;
    private loginDBContext loginDB;
    private string CompDBConnStr;
    private string LoginDBConnStr;

    public FilesMstBLL(string _CompDBConnStr,string _LoginDBConnStr)
    {
        CompDBConnStr = _CompDBConnStr;
        LoginDBConnStr = _LoginDBConnStr;
        loginDB = loginDBContextFactory.Create(CompDBConnStr);
        CompDB = compDbContextFactory.Create(LoginDBConnStr);
    }

    public ModelFileResp GetTrxDate()
    {
        ModelFileResp modelFileResp = new ModelFileResp()
        {
            status = true,
            Message = "TRX DATE FETCHED SUCCESSFULLY",
            fileList = CompDB.Files_Master.Where(x => x.form_name=="benpos").Select(m =>new Files_Master{
                id = m.id,
                trx_date = m.trx_date,
            }).ToList()
        };

        return modelFileResp;
    }

    public ModelFileResp UploadFile(ModelFileReq fileReq,long user_id ,string BaseDir)
    {
        ModelFileResp Resp = new ModelFileResp();
        string status = "true";

        Forms_Master forms_data = loginDB.Forms_Master.Where(x => x.id == fileReq.form_id).FirstOrDefault();

        Comp_Selection_Master comp_data = loginDB.Comp_Selection_Master.Where(x => x.id == fileReq.company_id).FirstOrDefault();

       
        if (comp_data == null)
        {
            Resp.status = false;
            Resp.Message = "The comp id is not correct or does not exist";
            throw new Exception("The comp id is not correct or does not exist");

        }

        if (fileReq.Files == null)
        {
            throw new Exception("NO FILES SELECTED");
        }

        if (fileReq.trx_id == null)
        {
            status = "false";
        }

        string Month = DateTime.Now.ToString("MMMM");
        string Year = DateTime.Now.Year.ToString();

        string fileName = fileReq.Files.FileName;
        string fileNameWoExt = Path.GetFileNameWithoutExtension(fileName);
        string ext = Path.GetExtension(fileName);
        fileNameWoExt = Regex.Replace(fileNameWoExt, @"[^\w\d]", "_") + "_" + DateTime.Now.ToString("yyyymmddMMss");

        string clean_filename = fileNameWoExt + ext;

        string directoryPath = Path.Combine(BaseDir, 
        comp_data.c_comp_short_name + "/" + forms_data.form_name + "/" + Year + "/" + Month );

        System.IO.Directory.CreateDirectory(directoryPath);

        string filePath = Path.Combine(directoryPath, clean_filename);

        Files_Master fileMaster = new Files_Master()
        {
            user_id = user_id,
            form_id = fileReq.form_id,
            trx_id = fileReq.trx_id,
            trx_date = fileReq.trx_date,
            comp_id = fileReq.company_id,
            comp_name = comp_data.c_comp_name,                  
            file_name = clean_filename,
            file_path = filePath,
            file_type = ext,
            form_name = forms_data.form_name,
            status = "true", //if trxid is not null
            uploaded_on = DateTime.Now,

        };

        CompDB.Files_Master.Add(fileMaster);
        CompDB.SaveChanges();

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            fileReq.Files.CopyTo(stream);
        }

        Resp.status = true;
        Resp.Message = "File Uploaded successfully";

        return Resp;
    }

    public ModelFileResp GetFilePath(long Image_Id,string filterType)
    {
        ModelFileResp fileResp = new ModelFileResp();
        Files_Master fileData = CompDB.Files_Master.Where(x => x.id == Image_Id).FirstOrDefault();
        if(fileData.form_name == "benpos"&&filterType!="all")
        {
            fileResp.benposData = CSVFileReader(fileData.file_path,filterType);        
        }
        fileResp.status = true;
        fileResp.Message = "files data fetched successfully";
        fileResp.fileData = fileData;
        return fileResp;
    }

    public Images_Store_Master_In_Ward GetFile(long Inward_Id, long Image_Id)
    {
        Images_Store_Master_In_Ward filePaths = loginDB.Images_Store_Master_In_Ward.Where(x => x.store_id == Inward_Id && x.id == Image_Id).FirstOrDefault();
        return filePaths;

    }

    public List<ModelBenposReader> CSVFileReader(string filePath,string filterType)
    {
        
        //using var reader = new StreamReader(@"F:\juni_docs\DETAIL-HPL_217-03-02-2023.csv");
        using var reader = new StreamReader(@filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        // csv.Context.TypeConverterOptionsCache.GetOptions<decimal>().NumberStyles = NumberStyles.Number | NumberStyles.AllowExponent;

        // Read CSV file
        List<ModelBenposReader> benposReaders = new List<ModelBenposReader>();
        if(filterType=="Top10")
        {
            benposReaders = csv.GetRecords<ModelBenposReader>().OrderByDescending(s => s.Share_Qty).Take(10).ToList();
        }
        if(filterType=="MoreThan1%")
        {
            benposReaders = csv.GetRecords<ModelBenposReader>().Where(s=> s.Share_Qty_Per>=1).ToList();
        }
        if(filterType=="PromoterList")
        {
            benposReaders = csv.GetRecords<ModelBenposReader>().Where(s=> s.Client_Type=="PROMOTER").ToList();
        }

        if(benposReaders.Count()==0)
        {
            throw new Exception("Records not found");    
        }

        //WriteLine("CHECK "+ benposReaders[0].Holding_Rpt_Date);

        return benposReaders;

    }

}

