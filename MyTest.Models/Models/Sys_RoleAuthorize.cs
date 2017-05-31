using System;
using System.Collections.Generic;

namespace MyTest.Models.Models
{
    public partial class Sys_RoleAuthorize
    {
        public string F_Id { get; set; }
        public Nullable<int> F_ItemType { get; set; }
        public string F_ItemId { get; set; }
        public Nullable<int> F_ObjectType { get; set; }
        public string F_ObjectId { get; set; }
        public Nullable<int> F_SortCode { get; set; }
        public Nullable<System.DateTime> F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
