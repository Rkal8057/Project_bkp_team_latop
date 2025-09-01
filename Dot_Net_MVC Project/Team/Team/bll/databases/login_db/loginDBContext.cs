using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB.Login.Tables;
namespace DB.Login
{
    public partial class loginDBContext : DbContext
    {
        public loginDBContext(DbContextOptions<loginDBContext> options) : base(options)
        { }
        public virtual DbSet<A_Pas_6_Master_Tmp> A_Pas_6_Master_Tmp { get; set; }
        public virtual DbSet<A_Pas_6_Qty_Master_Tmp> A_Pas_6_Qty_Master_Tmp { get; set; }
        public virtual DbSet<A1_Dn_Test> A1_Dn_Test { get; set; }
        public virtual DbSet<Ac_Category_Master> Ac_Category_Master { get; set; }
        public virtual DbSet<All_Comp_Holding_Master> All_Comp_Holding_Master { get; set; }
        public virtual DbSet<Appointment_Master_2022> Appointment_Master_2022 { get; set; }
        public virtual DbSet<Balance_Sheet> Balance_Sheet { get; set; }
        public virtual DbSet<Benpos_Path_Master_1718> Benpos_Path_Master_1718 { get; set; }
        public virtual DbSet<Benpos_Process_Control_Mst_1718> Benpos_Process_Control_Mst_1718 { get; set; }
        public virtual DbSet<Benpos_Process_Master_1718> Benpos_Process_Master_1718 { get; set; }
        public virtual DbSet<Ca_Codes_Type_Master> Ca_Codes_Type_Master { get; set; }
        public virtual DbSet<Ca_Upload_Cdsl_01> Ca_Upload_Cdsl_01 { get; set; }
        public virtual DbSet<Ca_Upload_Cdsl_03> Ca_Upload_Cdsl_03 { get; set; }
        public virtual DbSet<Category_Master> Category_Master { get; set; }
        public virtual DbSet<Category_Master_4_All_Exchange> Category_Master_4_All_Exchange { get; set; }
        public virtual DbSet<Categroy_Master_Nsdl> Categroy_Master_Nsdl { get; set; }
        public virtual DbSet<Categroy_Master_Phy> Categroy_Master_Phy { get; set; }
        public virtual DbSet<Cdsl_Category_Master> Cdsl_Category_Master { get; set; }
        public virtual DbSet<Cdsl_Master> Cdsl_Master { get; set; }
        public virtual DbSet<Cdsl_Master_01> Cdsl_Master_01 { get; set; }
        public virtual DbSet<Cdsl_Master_02> Cdsl_Master_02 { get; set; }
        public virtual DbSet<Check_List_Master> Check_List_Master { get; set; }
        public virtual DbSet<Comp_Name> Comp_Name { get; set; }
        public virtual DbSet<Comp_Per_Day_Holding_Det> Comp_Per_Day_Holding_Det { get; set; }
        public virtual DbSet<Comp_Per_Day_Holding_Det_All_Comp> Comp_Per_Day_Holding_Det_All_Comp { get; set; }
        public virtual DbSet<Comp_Selection_Master> Comp_Selection_Master { get; set; }
        public virtual DbSet<Comp_Selection_Master_Recently> Comp_Selection_Master_Recently { get; set; }
        public virtual DbSet<Complaint_Rec_Master> Complaint_Rec_Master { get; set; }
        public virtual DbSet<Complaint_Rec_Trn> Complaint_Rec_Trn { get; set; }
        public virtual DbSet<Complaint_Reply_Trn> Complaint_Reply_Trn { get; set; }
        public virtual DbSet<Correspondence_Master> Correspondence_Master { get; set; }
        public virtual DbSet<Delete_And_Create_Master> Delete_And_Create_Master { get; set; }
        public virtual DbSet<Demat_Batch_Id_Master> Demat_Batch_Id_Master { get; set; }
        public virtual DbSet<Demat_Out_Cdsl_01> Demat_Out_Cdsl_01 { get; set; }
        public virtual DbSet<Demat_Out_Cdsl_02> Demat_Out_Cdsl_02 { get; set; }
        public virtual DbSet<Demat_Out_Nsdl_01> Demat_Out_Nsdl_01 { get; set; }
        public virtual DbSet<Demat_Out_Nsdl_02> Demat_Out_Nsdl_02 { get; set; }
        public virtual DbSet<Despatch_By_Mst> Despatch_By_Mst { get; set; }
        public virtual DbSet<Destination_Mst> Destination_Mst { get; set; }
        public virtual DbSet<Distribution_Slab_Master> Distribution_Slab_Master { get; set; }
        public virtual DbSet<Docs_Multi_Save_Trx_Master> Docs_Multi_Save_Trx_Master { get; set; }
        public virtual DbSet<Docu_Type_Mst> Docu_Type_Mst { get; set; }
        public virtual DbSet<Dp_Cl_Id_Master> Dp_Cl_Id_Master { get; set; }
        public virtual DbSet<Dp_Import_Row_File> Dp_Import_Row_File { get; set; }
        public virtual DbSet<Dp_Master_Nsdl_Cdsl> Dp_Master_Nsdl_Cdsl { get; set; }
        public virtual DbSet<Dp_Master_Nsdl_Cdsl_01> Dp_Master_Nsdl_Cdsl_01 { get; set; }
        public virtual DbSet<Email_Log_Master> Email_Log_Master { get; set; }
        public virtual DbSet<Email_Sender_Master> Email_Sender_Master { get; set; }
        public virtual DbSet<Email_Sent_To_Master> Email_Sent_To_Master { get; set; }
        public virtual DbSet<Email_Smtserver_Master> Email_Smtserver_Master { get; set; }
        public virtual DbSet<Email_Users_Master> Email_Users_Master { get; set; }
        public virtual DbSet<Error_Code_Master> Error_Code_Master { get; set; }
        public virtual DbSet<Event_Multi_Save_Trx_Master> Event_Multi_Save_Trx_Master { get; set; }
        public virtual DbSet<Exch_Category_Master> Exch_Category_Master { get; set; }
        public virtual DbSet<Exch_Category_Master_Software> Exch_Category_Master_Software { get; set; }
        public virtual DbSet<Exch_Sub_Category_Master> Exch_Sub_Category_Master { get; set; }
        public virtual DbSet<Field_Master_4_Error> Field_Master_4_Error { get; set; }
        public virtual DbSet<Field_Master_4_Update> Field_Master_4_Update { get; set; }
        public virtual DbSet<Filling_Doc_Maintain_Master> Filling_Doc_Maintain_Master { get; set; }
        public virtual DbSet<Filling_Doc_Trx_Master> Filling_Doc_Trx_Master { get; set; }
        public virtual DbSet<Fin_Year_Selection_Master> Fin_Year_Selection_Master { get; set; }
        public virtual DbSet<Folio_Multi_Dist_Save_Trx_Master> Folio_Multi_Dist_Save_Trx_Master { get; set; }
        public virtual DbSet<Holiday_Master_2022> Holiday_Master_2022 { get; set; }
        public virtual DbSet<Iepf_Detail_Ndsl_Ndsl> Iepf_Detail_Ndsl_Ndsl { get; set; }
        public virtual DbSet<Images_Store_Master_Ac_Purc> Images_Store_Master_Ac_Purc { get; set; }
        public virtual DbSet<Images_Store_Master_Ac_Req_Iss> Images_Store_Master_Ac_Req_Iss { get; set; }
        public virtual DbSet<Images_Store_Master_Ac_Req_Rec> Images_Store_Master_Ac_Req_Rec { get; set; }
        public virtual DbSet<Images_Store_Master_Ac_Sale> Images_Store_Master_Ac_Sale { get; set; }
        public virtual DbSet<Images_Store_Master_Companies> Images_Store_Master_Companies { get; set; }
        public virtual DbSet<Images_Store_Master_In_Ward> Images_Store_Master_In_Ward { get; set; }
        public virtual DbSet<Images_Store_Master_Out_Ward> Images_Store_Master_Out_Ward { get; set; }
        public virtual DbSet<Images_Store_Master_Req_Rec> Images_Store_Master_Req_Rec { get; set; }
        public virtual DbSet<In_Out_Ward_Cate_Mst> In_Out_Ward_Cate_Mst { get; set; }
        public virtual DbSet<Inter_Depository_01> Inter_Depository_01 { get; set; }
        public virtual DbSet<Inter_Depository_02> Inter_Depository_02 { get; set; }
        public virtual DbSet<Inter_Depository_Row_File> Inter_Depository_Row_File { get; set; }
        public virtual DbSet<Isin_Status_Import_Row_File> Isin_Status_Import_Row_File { get; set; }
        public virtual DbSet<Isin_Status_Master_Nsdl_Cdsl> Isin_Status_Master_Nsdl_Cdsl { get; set; }
        public virtual DbSet<Isin_Status_Master_Nsdl_Cdsl_01> Isin_Status_Master_Nsdl_Cdsl_01 { get; set; }
        public virtual DbSet<Item_Group_Master> Item_Group_Master { get; set; }
        public virtual DbSet<Item_Master> Item_Master { get; set; }
        public virtual DbSet<Item_Service_Type_Master> Item_Service_Type_Master { get; set; }
        public virtual DbSet<Item_Trn> Item_Trn { get; set; }
        public virtual DbSet<Letter_Alert_4_Phy> Letter_Alert_4_Phy { get; set; }
        public virtual DbSet<Letter_Alert_4_Phy_Trx> Letter_Alert_4_Phy_Trx { get; set; }
        public virtual DbSet<Log_Comp_Master> Log_Comp_Master { get; set; }
        public virtual DbSet<Maker_Checker_Ac_Log_Master> Maker_Checker_Ac_Log_Master { get; set; }
        public virtual DbSet<Maker_Checker_Log_Master> Maker_Checker_Log_Master { get; set; }
        public virtual DbSet<Masters_Show_Allow_User> Masters_Show_Allow_User { get; set; }
        public virtual DbSet<Mker_Cker_Trans_Status_Msg_Master> Mker_Cker_Trans_Status_Msg_Master { get; set; }
        public virtual DbSet<Multi_Purpose_Type_Master> Multi_Purpose_Type_Master { get; set; }
        public virtual DbSet<Name_Change_Master> Name_Change_Master { get; set; }
        public virtual DbSet<Nominee_Change_Master> Nominee_Change_Master { get; set; }
        public virtual DbSet<Nsdl_Category_Master> Nsdl_Category_Master { get; set; }
        public virtual DbSet<Nsdl_Master> Nsdl_Master { get; set; }
        public virtual DbSet<Nsdl_Master_01> Nsdl_Master_01 { get; set; }
        public virtual DbSet<Nsdl_Master_02> Nsdl_Master_02 { get; set; }
        public virtual DbSet<Nsdl_Master_03> Nsdl_Master_03 { get; set; }
        public virtual DbSet<Partymaster> Partymaster { get; set; }
        public virtual DbSet<Partytrn> Partytrn { get; set; }
        public virtual DbSet<Pdf_Store_Master_Ac_Purc> Pdf_Store_Master_Ac_Purc { get; set; }
        public virtual DbSet<Pdf_Store_Master_Ac_Req_Iss> Pdf_Store_Master_Ac_Req_Iss { get; set; }
        public virtual DbSet<Pdf_Store_Master_Ac_Req_Rec> Pdf_Store_Master_Ac_Req_Rec { get; set; }
        public virtual DbSet<Pdf_Store_Master_Ac_Sale> Pdf_Store_Master_Ac_Sale { get; set; }
        public virtual DbSet<Pdf_Store_Master_Companies> Pdf_Store_Master_Companies { get; set; }
        public virtual DbSet<Pdf_Store_Master_In_Ward> Pdf_Store_Master_In_Ward { get; set; }
        public virtual DbSet<Pdf_Store_Master_Out_Ward> Pdf_Store_Master_Out_Ward { get; set; }
        public virtual DbSet<Pdf_Store_Master_Req_Rec> Pdf_Store_Master_Req_Rec { get; set; }
        public virtual DbSet<Pendency_Event_Master> Pendency_Event_Master { get; set; }
        public virtual DbSet<Pendency_Event_Master_Log> Pendency_Event_Master_Log { get; set; }
        public virtual DbSet<Pendency_Event_Master_Trn> Pendency_Event_Master_Trn { get; set; }
        public virtual DbSet<Per_Day_Holding_All_Comp> Per_Day_Holding_All_Comp { get; set; }
        public virtual DbSet<Phy_Category_Master> Phy_Category_Master { get; set; }
        public virtual DbSet<Protal_Link_Maitain_Master> Protal_Link_Maitain_Master { get; set; }
        public virtual DbSet<Purpose_Mst> Purpose_Mst { get; set; }
        public virtual DbSet<Recent_Comp_Selection_Master> Recent_Comp_Selection_Master { get; set; }
        public virtual DbSet<Reco_Cdsl_01> Reco_Cdsl_01 { get; set; }
        public virtual DbSet<Reco_Cdsl_02> Reco_Cdsl_02 { get; set; }
        public virtual DbSet<Reco_Import_01> Reco_Import_01 { get; set; }
        public virtual DbSet<Reco_Import_02> Reco_Import_02 { get; set; }
        public virtual DbSet<Reco_Import_Row_File> Reco_Import_Row_File { get; set; }
        public virtual DbSet<Reco_Nsdl_01> Reco_Nsdl_01 { get; set; }
        public virtual DbSet<Reco_Nsdl_02> Reco_Nsdl_02 { get; set; }
        public virtual DbSet<Reco_Nsdl_Row_File> Reco_Nsdl_Row_File { get; set; }
        public virtual DbSet<Reco_Process_Report_Master> Reco_Process_Report_Master { get; set; }
        public virtual DbSet<Reco_Row_File_Cdsl> Reco_Row_File_Cdsl { get; set; }
        public virtual DbSet<Reject_Code_Msg_Master> Reject_Code_Msg_Master { get; set; }
        public virtual DbSet<Reject_Code_Msg_Master_Trx> Reject_Code_Msg_Master_Trx { get; set; }
        public virtual DbSet<Rejres> Rejres { get; set; }
        public virtual DbSet<Req_Rec_Drn_Status> Req_Rec_Drn_Status { get; set; }
        public virtual DbSet<Req_Rec_Drn_Status_Cdsl> Req_Rec_Drn_Status_Cdsl { get; set; }
        public virtual DbSet<Req_Rec_Drn_Status_Nsdl> Req_Rec_Drn_Status_Nsdl { get; set; }
        public virtual DbSet<Req_Rec_Master> Req_Rec_Master { get; set; }
        public virtual DbSet<Req_Rec_Master_Comp> Req_Rec_Master_Comp { get; set; }
        public virtual DbSet<Req_Rec_Master_Comp_Docus> Req_Rec_Master_Comp_Docus { get; set; }
        public virtual DbSet<Req_Rec_Master_Comp_Schedule> Req_Rec_Master_Comp_Schedule { get; set; }
        public virtual DbSet<Req_Rec_Master_Multi> Req_Rec_Master_Multi { get; set; }
        public virtual DbSet<Req_Rec_Online_01_Cdsl> Req_Rec_Online_01_Cdsl { get; set; }
        public virtual DbSet<Req_Rec_Online_01_Nsdl> Req_Rec_Online_01_Nsdl { get; set; }
        public virtual DbSet<Req_Rec_Online_02_Cdsl> Req_Rec_Online_02_Cdsl { get; set; }
        public virtual DbSet<Req_Rec_Online_02_Nsdl> Req_Rec_Online_02_Nsdl { get; set; }
        public virtual DbSet<Req_Rec_Online_03_Cdsl> Req_Rec_Online_03_Cdsl { get; set; }
        public virtual DbSet<Req_Rec_Online_03_Nsdl> Req_Rec_Online_03_Nsdl { get; set; }
        public virtual DbSet<Req_Rec_Online_Cdsl_Rtm8_01> Req_Rec_Online_Cdsl_Rtm8_01 { get; set; }
        public virtual DbSet<Req_Rec_Online_Cdsl_Rtm8_02> Req_Rec_Online_Cdsl_Rtm8_02 { get; set; }
        public virtual DbSet<Req_Rec_Online_Cdsl_Rtm8_Row_File> Req_Rec_Online_Cdsl_Rtm8_Row_File { get; set; }
        public virtual DbSet<Req_Rec_Online_Row_File_Cdsl> Req_Rec_Online_Row_File_Cdsl { get; set; }
        public virtual DbSet<Req_Rec_Online_Row_File_Nsdl> Req_Rec_Online_Row_File_Nsdl { get; set; }
        public virtual DbSet<Req_Recv_Master_Online_Alert> Req_Recv_Master_Online_Alert { get; set; }
        public virtual DbSet<Req_Rej_Flag_Master> Req_Rej_Flag_Master { get; set; }
        public virtual DbSet<Rta_Company_Detail> Rta_Company_Detail { get; set; }
        public virtual DbSet<State_Master> State_Master { get; set; }
        public virtual DbSet<System_Display_Helper_Master> System_Display_Helper_Master { get; set; }
        public virtual DbSet<System_Records> System_Records { get; set; }
        public virtual DbSet<Task_Event_Master> Task_Event_Master { get; set; }
        public virtual DbSet<Task_Event_Master_Log> Task_Event_Master_Log { get; set; }
        public virtual DbSet<Task_Event_Master_Trn> Task_Event_Master_Trn { get; set; }
        public virtual DbSet<Unit_Type_Master> Unit_Type_Master { get; set; }
        public virtual DbSet<User_Detail> User_Detail { get; set; }
        public virtual DbSet<User_Log_Master> User_Log_Master { get; set; }
        public virtual DbSet<Verify_Log_Master> Verify_Log_Master { get; set; }
        public virtual DbSet<Vers_Master> Vers_Master { get; set; }
        public virtual DbSet<Ward_Master_In> Ward_Master_In { get; set; }
        public virtual DbSet<Ward_Master_Out> Ward_Master_Out { get; set; }
        public virtual DbSet<Ward_Master_Out1> Ward_Master_Out1 { get; set; }
        public virtual DbSet<Auth_Token> Auth_Token { get; set; }
        public virtual DbSet<Comp_DB> Comp_DB {get;set;}
        public virtual DbSet<Sample_Detail> Sample_Detail {get;set;}
        public virtual DbSet<Forms_Master> Forms_Master {get;set;}
        public virtual DbSet<Forms_Trx_Master> Forms_Trx_Master {get;set;}
        public virtual DbSet<User_Profile_Master> User_Profile_Master {get;set;}
        public virtual DbSet<Model_Req> Model_Req { get; set;}
        public virtual DbSet<ISR_1> ISR_1 { get; set; }
        public virtual DbSet<Folio_Master> Folio_Master { get; set; }
        public virtual DbSet<Isr_2> Isr_2 { get; set; }
        public virtual DbSet<Isr_3> Isr_3 { get; set; }
        public virtual DbSet<Isr_3_securities> Isr_3_securities { get; set; }
        public virtual DbSet<Sh_13> Sh_13 { get; set; }
        public virtual DbSet<Sh_13_securities> Sh_13_securities { get; set; }
        public virtual DbSet<Sh_14> Sh_14 { get; set; }
        public virtual DbSet<Sh_14_securities> Sh_14_securities { get; set; }
        public virtual DbSet<Complaint_Master> Complaint_Master { get; set; }
        public virtual DbSet<Complaint_Trx_Master> Complaint_Trx_Master { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Detail>(entity => 
            {
                entity.HasIndex(e => e.user_code).IsUnique();
                entity.HasOne(e => e.User_Profile_Masters)
                    .WithMany(e => e.User_Details).HasForeignKey(e => e.user_profile_id);
            });

            modelBuilder.Entity<Comp_DB>(entity => 
            {
                entity.HasOne(e => e.Comp_Selection_Master)
                .WithMany(e => e.Comp_DBs).HasForeignKey(e => e.CompMstId);
            });

                modelBuilder.Entity<Forms_Trx_Master>(entity => 
                {
                    entity.HasOne(e => e.Forms_Master)
                    .WithMany(e => e.Forms_Trx_Masters).HasForeignKey(e => e.form_master_id);
                });

           
        }
    }
}