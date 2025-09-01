using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Login.Tables
{
    public class Sample_Detail
    {
        [Key]
        public long id {get;set;}
        public string profession {get;set;}
        public string name {get;set;}
        public int phone {get;set;}
        public string email {get;set;}
        public string institute {get;set;}
        public string isActive {get;set;}
    }
}