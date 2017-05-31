using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_OrganizeMap : EntityTypeConfiguration<Sys_Organize>
    {
        public Sys_OrganizeMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_ParentId)
                .HasMaxLength(50);

            this.Property(t => t.F_EnCode)
                .HasMaxLength(50);

            this.Property(t => t.F_FullName)
                .HasMaxLength(50);

            this.Property(t => t.F_ShortName)
                .HasMaxLength(50);

            this.Property(t => t.F_CategoryId)
                .HasMaxLength(50);

            this.Property(t => t.F_ManagerId)
                .HasMaxLength(50);

            this.Property(t => t.F_TelePhone)
                .HasMaxLength(20);

            this.Property(t => t.F_MobilePhone)
                .HasMaxLength(20);

            this.Property(t => t.F_WeChat)
                .HasMaxLength(50);

            this.Property(t => t.F_Fax)
                .HasMaxLength(20);

            this.Property(t => t.F_Email)
                .HasMaxLength(50);

            this.Property(t => t.F_AreaId)
                .HasMaxLength(50);

            this.Property(t => t.F_Address)
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
            this.ToTable("Sys_Organize");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_ParentId).HasColumnName("F_ParentId");
            this.Property(t => t.F_Layers).HasColumnName("F_Layers");
            this.Property(t => t.F_EnCode).HasColumnName("F_EnCode");
            this.Property(t => t.F_FullName).HasColumnName("F_FullName");
            this.Property(t => t.F_ShortName).HasColumnName("F_ShortName");
            this.Property(t => t.F_CategoryId).HasColumnName("F_CategoryId");
            this.Property(t => t.F_ManagerId).HasColumnName("F_ManagerId");
            this.Property(t => t.F_TelePhone).HasColumnName("F_TelePhone");
            this.Property(t => t.F_MobilePhone).HasColumnName("F_MobilePhone");
            this.Property(t => t.F_WeChat).HasColumnName("F_WeChat");
            this.Property(t => t.F_Fax).HasColumnName("F_Fax");
            this.Property(t => t.F_Email).HasColumnName("F_Email");
            this.Property(t => t.F_AreaId).HasColumnName("F_AreaId");
            this.Property(t => t.F_Address).HasColumnName("F_Address");
            this.Property(t => t.F_AllowEdit).HasColumnName("F_AllowEdit");
            this.Property(t => t.F_AllowDelete).HasColumnName("F_AllowDelete");
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
