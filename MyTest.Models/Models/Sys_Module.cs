using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_Module
    {
        public string F_Id { get; set; }
        public string F_ParentId { get; set; }
        public Nullable<int> F_Layers { get; set; }
        public string F_EnCode { get; set; }
        public string F_FullName { get; set; }
        public string F_Icon { get; set; }
        public string F_UrlAddress { get; set; }
        public string F_Target { get; set; }
        public Nullable<bool> F_IsMenu { get; set; }
        public Nullable<bool> F_IsExpand { get; set; }
        public Nullable<bool> F_IsPublic { get; set; }
        public Nullable<bool> F_AllowEdit { get; set; }
        public Nullable<bool> F_AllowDelete { get; set; }
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
