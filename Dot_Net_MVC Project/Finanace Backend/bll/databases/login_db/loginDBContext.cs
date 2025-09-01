using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB.Login.Tables;
//using DB.Login.Migrations;

namespace DB.Login
{
    public partial class loginDBContext : DbContext
    {
        public loginDBContext(DbContextOptions<loginDBContext> options) : base(options)
        { }
       
        public virtual DbSet<CaseMaster> CaseMaster { get; set; }
        public virtual DbSet<CaseHireMaster> CaseHireMaster { get; set; }
        public virtual DbSet<Guarantor1Detail> Guarantor1Detail { get; set; }
        public virtual DbSet<Guarantor2Detail> Guarantor2Detail { get; set; }
        public virtual DbSet<RecieptDetail> RecieptDetail { get; set; }
        public virtual DbSet<ExtraDetail> ExtraDetail { get; set; }
        public virtual DbSet<EMIDetail> EMIDetail { get; set; }
        public virtual DbSet<UploadDocument> UploadDocument { get; set; }
        public virtual DbSet<CompanyDetail> CompanyDetail { get; set; }
        public virtual DbSet<HelperDetail> HelperDetail { get; set; }


    }
}