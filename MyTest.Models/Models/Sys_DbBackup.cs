using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_DbBackup
    {
        public string F_Id { get; set; }
        public string F_BackupType { get; set; }
        public string F_DbName { get; set; }
        public string F_FileName { get; set; }
        public string F_FileSize { get; set; }
        public string F_FilePath { get; set; }
        public Nullable<System.DateTime> F_BackupTime { get; set; }
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
