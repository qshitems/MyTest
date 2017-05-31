using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_UserMap : EntityTypeConfiguration<Sys_User>
    {
        public Sys_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_Account)
                .HasMaxLength(50);

            this.Property(t => t.F_RealName)
                .HasMaxLength(50);

            this.Property(t => t.F_NickName)
                .HasMaxLength(50);

            this.Property(t => t.F_HeadIcon)
                .HasMaxLength(50);

            this.Property(t => t.F_MobilePhone)
                .HasMaxLength(20);

            this.Property(t => t.F_Email)
                .HasMaxLength(50);

            this.Property(t => t.F_WeChat)
                .HasMaxLength(50);

            this.Property(t => t.F_ManagerId)
                .HasMaxLength(50);

            this.Property(t => t.F_Signature)
                .HasMaxLength(500);

            this.Property(t => t.F_OrganizeId)
                .HasMaxLength(50);

            this.Property(t => t.F_DepartmentId)
                .HasMaxLength(500);

            this.Property(t => t.F_RoleId)
                .HasMaxLength(500);

            this.Property(t => t.F_DutyId)
                .HasMaxLength(500);

            this.Property(t => t.F_Description)
                .HasMaxLength(500);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_LastModifyUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_DeleteUserId)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Sys_User");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_Account).HasColumnName("F_Account");
            this.Property(t => t.F_RealName).HasColumnName("F_RealName");
            this.Property(t => t.F_NickName).HasColumnName("F_NickName");
            this.Property(t => t.F_HeadIcon).HasColumnName("F_HeadIcon");
            this.Property(t => t.F_Gender).HasColumnName("F_Gender");
            this.Property(t => t.F_Birthday).HasColumnName("F_Birthday");
            this.Property(t => t.F_MobilePhone).HasColumnName("F_MobilePhone");
            this.Property(t => t.F_Email).HasColumnName("F_Email");
            this.Property(t => t.F_WeChat).HasColumnName("F_WeChat");
            this.Property(t => t.F_ManagerId).HasColumnName("F_ManagerId");
            this.Property(t => t.F_SecurityLevel).HasColumnName("F_SecurityLevel");
            this.Property(t => t.F_Signature).HasColumnName("F_Signature");
            this.Property(t => t.F_OrganizeId).HasColumnName("F_OrganizeId");
            this.Property(t => t.F_DepartmentId).HasColumnName("F_DepartmentId");
            this.Property(t => t.F_RoleId).HasColumnName("F_RoleId");
            this.Property(t => t.F_DutyId).HasColumnName("F_DutyId");
            this.Property(t => t.F_IsAdministrator).HasColumnName("F_IsAdministrator");
            this.Property(t => t.F_SortCode).HasColumnName("F_SortCode");
            this.Property(t => t.F_DeleteMark).HasColumnName("F_DeleteMark");
            this.Property(t => t.F_EnabledMark).HasColumnName("F_EnabledMark");
            this.Property(t => t.F_Description).HasColumnName("F_Description");
            this.Property(t => t.F_CreatorTime).HasColumnName("F_CreatorTime");
            this.Property(t => t.F_CreatorUserId).HasColumnName("F_CreatorUserId");
            this.Property(t => t.F_LastModifyTime).HasColumnName("F_LastModifyTime");
            this.Property(t => t.F_LastModifyUserId).HasColumnName("F_LastModifyUserId");
            this.Property(t => t.F_DeleteTime).HasColumnName("F_DeleteTime");
            this.Property(t => t.F_DeleteUserId).HasColumnName("F_DeleteUserId");
        }
    }
}
