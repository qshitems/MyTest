using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_UserLogOn
    {
        public string F_Id { get; set; }
        public string F_UserId { get; set; }
        public string F_UserPassword { get; set; }
        public string F_UserSecretkey { get; set; }
        public Nullable<System.DateTime> F_AllowStartTime { get; set; }
        public Nullable<System.DateTime> F_AllowEndTime { get; set; }
        public Nullable<System.DateTime> F_LockStartDate { get; set; }
        public Nullable<System.DateTime> F_LockEndDate { get; set; }
        public Nullable<System.DateTime> F_FirstVisitTime { get; set; }
        public Nullable<System.DateTime> F_PreviousVisitTime { get; set; }
        public Nullable<System.DateTime> F_LastVisitTime { get; set; }
        public Nullable<System.DateTime> F_ChangePasswordDate { get; set; }
        public Nullable<bool> F_MultiUserLogin { get; set; }
        public Nullable<int> F_LogOnCount { get; set; }
        public Nullable<bool> F_UserOnLine { get; set; }
        public string F_Question { get; set; }
        public string F_AnswerQuestion { get; set; }
        public Nullable<bool> F_CheckIPAddress { get; set; }
        public string F_Language { get; set; }
        public string F_Theme { get; set; }
    }
}
