using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_FilterIP
    {
        public string F_Id { get; set; }
        public Nullable<bool> F_Type { get; set; }
        public string F_StartIP { get; set; }
        public string F_EndIP { get; set; }
        public Nullable<int> F_SortCode { get; set; }
        public Nullable<bool> F_DeleteMark { get; set; }
        public Nullable<bool> F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public Nullable<System.DateTime> F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public Nullable<System.DateTime> F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public Nullable<System.DateTime> F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
    }
}
