using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_ModuleFormInstance
    {
        public string F_Id { get; set; }
        public string F_FormId { get; set; }
        public string F_ObjectId { get; set; }
        public string F_InstanceJson { get; set; }
        public Nullable<int> F_SortCode { get; set; }
        public Nullable<System.DateTime> F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
