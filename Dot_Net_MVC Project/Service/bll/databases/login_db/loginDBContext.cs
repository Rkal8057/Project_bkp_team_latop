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
        public virtual DbSet<ServiceMaster> ServiceMaster { get; set; }
        public virtual DbSet<CategoryMaster> CategoryMaster { get; set; }
        public virtual DbSet<CheckListMaster> CheckListMaster { get; set; }
        public virtual DbSet<GeneralRequestedDetail> GeneralRequestedDetail { get; set; }
        public virtual DbSet<ProcessRequestDetail> ProcessRequestDetail { get; set; }
        public virtual DbSet<CorrespondenceRequest> CorrespondenceRequest { get; set; }

        public virtual DbSet<ApplicationMaster> ApplicationMaster { get; set; }
        public virtual DbSet<HolderDetail> HolderDetail { get; set; }
        public virtual DbSet<NomineeDetail> NomineeDetail { get; set; }
        public virtual DbSet<KYCDetail> KYCDetail { get; set; }
        public virtual DbSet<PowerAttorney> PowerAttorney { get; set; }

        public virtual DbSet<NSDLMaster> NSDLMaster { get; set; }

    }
}