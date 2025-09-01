using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RTA.Masters
{
    public class BusinessUserDetailBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public BusinessUserDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public BusinessUserDetailResp GetBusinessUserDetail(string? searchKey = null)
        {
            var query = DB.BusinessUserDetail.Where(e => e.delete == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                string pattern = $"%{searchKey}%";
                query = query.Where(e => EF.Functions.Like(e.user_name, pattern) ||
                                         EF.Functions.Like(e.user_title, pattern) ||
                                         EF.Functions.Like(e.user_company, pattern) ||
                                         EF.Functions.Like(e.user_ph, pattern) ||
                                         EF.Functions.Like(e.user_email, pattern) ||
                                         EF.Functions.Like(e.party_name, pattern));
            }

            var businessUserDetails = query.Take(10).ToList();


            BusinessUserDetailResp data = new BusinessUserDetailResp()
            {
                status = true,
                Message = "Data fetched successfully",
                BusinessUserDetailData = businessUserDetails
            };
            return data;
        }

        public BusinessUserDetailResp GetBusinessUserDetailById(long bUserId)
        {

            BusinessUserDetail userDetail = DB.BusinessUserDetail.Where(e => e.delete == 0 && e.id == bUserId)
            .FirstOrDefault();

            var sectionsWithContents = DB.BusinessSection
                .Where(section => section.delete == 0 && section.business_user_detail_id == bUserId)
                .OrderBy(section => section.section_position)
                .Select(section => new
                {
                    Section = section,
                    Contents = DB.BusinessContent
                        .Where(content => content.business_section_name == section.title && content.delete == 0 && content.business_user_detail_id == bUserId)
                        .OrderBy(content => content.content_position)
                        .ToList()
                })
                .ToList();


            BusinessUserDetailResp data = new BusinessUserDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                BusinessUserDetailByID = userDetail,
                BusinessSectionDataByIDType = sectionsWithContents

            };
            return data;
        }

        public BusinessUserDetailResp InsertBusinessUserDetail(BusinessUserDetailReq samp)
        {
            BusinessUserDetail SampData = new BusinessUserDetail()
            {
                user_name = samp.user_name,
                user_title = samp.user_title,
                user_company = samp.user_company,
                user_ph = samp.user_ph,
                user_email = samp.user_email,
                user_img = samp.user_img,
                party_id = samp.party_id,
                party_name = samp.party_name,
                delete = 0,
                theme_color = samp.theme_color,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            DB.BusinessUserDetail.Add(SampData);
            DB.SaveChanges();

            string json = @"[
    {
        ""section"": {
            ""id"": 1,
            ""title"": ""Abouts"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""1"",
            ""delete"": 0,
            ""created_at"": ""2024-08-03T11:09:29"",
            ""updated_at"": ""2024-08-03T11:09:29""
        },
        ""contents"": [
            {
                ""id"": 1,
                ""type"": ""text"",
                ""label"": """",
                ""value"": ""About Detail"",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-location-arrow"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""About"",
                ""created_at"": ""2024-08-03T11:10:04"",
                ""updated_at"": ""2024-08-03T11:10:13""
            }
        ]
    },
    {
        ""section"": {
            ""id"": 2,
            ""title"": ""Contact Us"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""2"",
            ""delete"": 0,
            ""created_at"": ""2024-08-03T11:10:28"",
            ""updated_at"": ""2024-08-03T11:10:28""
        },
        ""contents"": [
            {
                ""id"": 2,
                ""type"": ""text"",
                ""label"": ""Name"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-location-arrow"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Contact Us"",
                ""created_at"": ""2024-08-03T11:10:40"",
                ""updated_at"": ""2024-08-03T11:10:40""
            },
            {
                ""id"": 3,
                ""type"": ""text"",
                ""label"": ""Email"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-location-arrow"",
                ""button_alignment"": null,
                ""content_position"": ""2"",
                ""delete"": 0,
                ""business_section_name"": ""Contact Us"",
                ""created_at"": ""2024-08-03T11:10:54"",
                ""updated_at"": ""2024-08-03T11:10:54""
            },
            {
                ""id"": 4,
                ""type"": ""text"",
                ""label"": ""Address"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-location-arrow"",
                ""button_alignment"": null,
                ""content_position"": ""3"",
                ""delete"": 0,
                ""business_section_name"": ""Contact Us"",
                ""created_at"": ""2024-08-03T11:11:14"",
                ""updated_at"": ""2024-08-03T11:11:14""
            }
        ]
    },

    {
        ""section"": {
            ""id"": 4,
            ""title"": ""Business Detail"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""4"",
            ""delete"": 0,
            ""created_at"": ""2024-09-01T10:15:00"",
            ""updated_at"": ""2024-09-01T10:15:00""
        },
        ""contents"": [
            {
                ""id"": 7,
                ""type"": ""text"",
                ""label"": ""Company"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-building"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Business Detail"",
                ""created_at"": ""2024-09-01T10:20:00"",
                ""updated_at"": ""2024-09-01T10:20:00""
            }
        ]
    },
    {
        ""section"": {
            ""id"": 5,
            ""title"": ""Hobby"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""5"",
            ""delete"": 0,
            ""created_at"": ""2024-09-01T10:25:00"",
            ""updated_at"": ""2024-09-01T10:25:00""
        },
        ""contents"": [
            {
                ""id"": 8,
                ""type"": ""text"",
                ""label"": ""Favorite Hobby"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-camera"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Hobby"",
                ""created_at"": ""2024-09-01T10:30:00"",
                ""updated_at"": ""2024-09-01T10:30:00""
            }
        ]
    },
    {
        ""section"": {
            ""id"": 6,
            ""title"": ""Experience"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""6"",
            ""delete"": 0,
            ""created_at"": ""2024-09-01T10:35:00"",
            ""updated_at"": ""2024-09-01T10:35:00""
        },
        ""contents"": [
            {
                ""id"": 9,
                ""type"": ""text"",
                ""label"": ""Company"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-briefcase"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Experience"",
                ""created_at"": ""2024-09-01T10:40:00"",
                ""updated_at"": ""2024-09-01T10:40:00""
            },
            {
                ""id"": 9,
                ""type"": ""text"",
                ""label"": ""Designation"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-briefcase"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Experience"",
                ""created_at"": ""2024-09-01T10:40:00"",
                ""updated_at"": ""2024-09-01T10:40:00""
            },
            {
                
                ""type"": ""text"",
                ""label"": ""Year"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-briefcase"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Experience"",
                ""created_at"": ""2024-09-01T10:40:00"",
                ""updated_at"": ""2024-09-01T10:40:00""
            },
            {
                
                ""type"": ""text"",
                ""label"": ""Descriptions"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-briefcase"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Experience"",
                ""created_at"": ""2024-09-01T10:40:00"",
                ""updated_at"": ""2024-09-01T10:40:00""
            }



        ]
    },
    {
        ""section"": {
            ""id"": 7,
            ""title"": ""Address"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""7"",
            ""delete"": 0,
            ""created_at"": ""2024-09-01T10:45:00"",
            ""updated_at"": ""2024-09-01T10:45:00""
        },
        ""contents"": [
            {
                ""id"": 10,
                ""type"": ""text"",
                ""label"": ""Home Address"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-map-marker-alt"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Address"",
                ""created_at"": ""2024-09-01T10:50:00"",
                ""updated_at"": ""2024-09-01T10:50:00""
            },
            {
                ""type"": ""text"",
                ""label"": ""Current Address"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-map-marker-alt"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Address"",
                ""created_at"": ""2024-09-01T10:50:00"",
                ""updated_at"": ""2024-09-01T10:50:00""
            }
        ]
    },
    {
        ""section"": {
            ""id"": 8,
            ""title"": ""Family Detail"",
            ""title_alignment"": ""left"",
            ""title_bold"": ""true"",
            ""title_font_size"": ""15"",
            ""section_position"": ""8"",
            ""delete"": 0,
            ""created_at"": ""2024-09-01T10:55:00"",
            ""updated_at"": ""2024-09-01T10:55:00""
        },
        ""contents"": [
            {
                ""id"": 11,
                ""type"": ""text"",
                ""label"": ""Family Member"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-user-friends"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Family Detail"",
                ""created_at"": ""2024-09-01T11:00:00"",
                ""updated_at"": ""2024-09-01T11:00:00""
            },
            {
               
                ""type"": ""text"",
                ""label"": ""Mother Name"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-user-friends"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Family Detail"",
                ""created_at"": ""2024-09-01T11:00:00"",
                ""updated_at"": ""2024-09-01T11:00:00""
            },
            {
               
                ""type"": ""text"",
                ""label"": ""Father Name"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-user-friends"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Family Detail"",
                ""created_at"": ""2024-09-01T11:00:00"",
                ""updated_at"": ""2024-09-01T11:00:00""
            },
            {
               
                ""type"": ""text"",
                ""label"": ""Sister Name"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-user-friends"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Family Detail"",
                ""created_at"": ""2024-09-01T11:00:00"",
                ""updated_at"": ""2024-09-01T11:00:00""
            },
            {
               
                ""type"": ""text"",
                ""label"": ""Brother Name"",
                ""value"": """",
                ""label_bold"": ""true"",
                ""value_bold"": ""false"",
                ""alignment"": ""left"",
                ""icon"": ""fas fa-user-friends"",
                ""button_alignment"": null,
                ""content_position"": ""1"",
                ""delete"": 0,
                ""business_section_name"": ""Family Detail"",
                ""created_at"": ""2024-09-01T11:00:00"",
                ""updated_at"": ""2024-09-01T11:00:00""
            }
        ]
    }
]";

            //string json = @"[
            //            {
            //                'section': {
            //                    'id': 1,
            //                    'title': 'About',
            //                    'title_alignment': 'left',
            //                    'title_bold': 'true',
            //                    'title_font_size': '15',
            //                    'section_position': '1',
            //                    'delete': 0,
            //                    'created_at': '2024-08-03T11:09:29',
            //                    'updated_at': '2024-08-03T11:09:29'
            //                },
            //                'contents': [
            //                    {
            //                        'id': 1,
            //                        'type': 'text',
            //                        'label': '',
            //                        'value': 'A Software Developer is responsible for the design, development, testing, and maintenance of software applications...',
            //                        'label_bold': 'true',
            //                        'value_bold': 'false',
            //                        'alignment': 'left',
            //                        'icon': 'fas fa-location-arrow',
            //                        'button_alignment': null,
            //                        'content_position': '1',
            //                        'delete': 0,
            //                        'business_section_name': 'About',
            //                        'created_at': '2024-08-03T11:10:04',
            //                        'updated_at': '2024-08-03T11:10:13'
            //                    }
            //                ]
            //            },
            //            {
            //                'section': {
            //                    'id': 2,
            //                    'title': 'Contact Us',
            //                    'title_alignment': 'left',
            //                    'title_bold': 'true',
            //                    'title_font_size': '15',
            //                    'section_position': '2',
            //                    'delete': 0,
            //                    'created_at': '2024-08-03T11:10:28',
            //                    'updated_at': '2024-08-03T11:10:28'
            //                },
            //                'contents': [
            //                    {
            //                        'id': 2,
            //                        'type': 'text',
            //                        'label': 'Name',
            //                        'value': 'Mohit',
            //                        'label_bold': 'true',
            //                        'value_bold': 'false',
            //                        'alignment': 'left',
            //                        'icon': 'fas fa-location-arrow',
            //                        'button_alignment': null,
            //                        'content_position': '1',
            //                        'delete': 0,
            //                        'business_section_name': 'Contact Us',
            //                        'created_at': '2024-08-03T11:10:40',
            //                        'updated_at': '2024-08-03T11:10:40'
            //                    },
            //                    {
            //                        'id': 3,
            //                        'type': 'text',
            //                        'label': 'Email',
            //                        'value': 'mohit@gmail.com',
            //                        'label_bold': 'true',
            //                        'value_bold': 'false',
            //                        'alignment': 'left',
            //                        'icon': 'fas fa-location-arrow',
            //                        'button_alignment': null,
            //                        'content_position': '2',
            //                        'delete': 0,
            //                        'business_section_name': 'Contact Us',
            //                        'created_at': '2024-08-03T11:10:54',
            //                        'updated_at': '2024-08-03T11:10:54'
            //                    },
            //                    {
            //                        'id': 4,
            //                        'type': 'text',
            //                        'label': 'Address',
            //                        'value': 'New Delhi',
            //                        'label_bold': 'true',
            //                        'value_bold': 'false',
            //                        'alignment': 'left',
            //                        'icon': 'fas fa-location-arrow',
            //                        'button_alignment': null,
            //                        'content_position': '3',
            //                        'delete': 0,
            //                        'business_section_name': 'Contact Us',
            //                        'created_at': '2024-08-03T11:11:14',
            //                        'updated_at': '2024-08-03T11:11:14'
            //                    }
            //                ]
            //            }
            //        ]";

            dynamic businessSectionData = JsonConvert.DeserializeObject(json);

            BusinessSection SampData1 = null;
            foreach (var sectionData in businessSectionData)
            {

                SampData1 = new BusinessSection()
                {
                    title = sectionData.section.title,
                    title_alignment = sectionData.section.title_alignment,
                    title_bold = sectionData.section.title_bold,
                    title_font_size = sectionData.section.title_font_size,
                    section_position = sectionData.section.section_position,
                    delete = 0,
                    business_user_detail_id = SampData.id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now

                };

                DB.BusinessSection.Add(SampData1);


                foreach (var content in sectionData.contents)
                {

                    BusinessContent SampData2 = new BusinessContent()
                    {
                        type = content.type,
                        label = content.label,
                        value = content.value,
                        label_bold = content.label_bold,
                        value_bold = content.value_bold,
                        alignment = content.alignment,
                        icon = content.icon,
                        button_alignment = content.button_alignment,
                        content_position = content.content_position,
                        delete = 0,
                        business_section_name = content.business_section_name,
                        business_section_id = SampData1.id,
                        business_user_detail_id = SampData.id,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    DB.BusinessContent.Add(SampData2);
                    DB.SaveChanges();

                }
                DB.SaveChanges();
            }

            BusinessUserDetail userDetail = DB.BusinessUserDetail.Where(e => e.id == SampData.id).FirstOrDefault();
            BusinessUserDetailResp data = new BusinessUserDetailResp()
            {
                status = true,
                Message = "inserted successfully",
                BusinessUserDetailByID = userDetail,
            };
            return data;
        }

        public BusinessUserDetailResp UpdateBusinessUserDetail(long bUserId, BusinessUserDetailReq samp)
        {
            var existingRecord = DB.BusinessUserDetail.Find(bUserId);

            if (existingRecord == null)
            {
                BusinessUserDetailResp data1 = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = "Business User Detail is not found"
                };

                return data1;
            }

            existingRecord.user_name = samp.user_name;
            existingRecord.user_title = samp.user_title;
            existingRecord.user_company = samp.user_company;
            existingRecord.user_ph = samp.user_ph;
            existingRecord.user_email = samp.user_email;
            existingRecord.user_img = samp.user_img;
            existingRecord.party_id = samp.party_id;
            existingRecord.party_name = samp.party_name;
            existingRecord.updated_at = DateTime.Now;
            existingRecord.theme_color = samp.theme_color;


            DB.SaveChanges();

            BusinessUserDetailResp data = new BusinessUserDetailResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }

        public BusinessUserDetailResp DeleteBusinessUserDetail(long bUserId)
        {

            BusinessUserDetail del = DB.BusinessUserDetail.SingleOrDefault(parent => parent.id == bUserId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete = 1;
            DB.SaveChanges();

            BusinessUserDetailResp data = new BusinessUserDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}