using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_ModuleButtonMap : EntityTypeConfiguration<Sys_ModuleButton>
    {
        public Sys_ModuleButtonMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_ModuleId)
                .HasMaxLength(50);

            this.Property(t => t.F_ParentId)
                .HasMaxLength(50);

            this.Property(t => t.F_EnCode)
                .HasMaxLength(50);

            this.Property(t => t.F_FullName)
                .HasMaxLength(50);

            this.Property(t => t.F_Icon)
                .HasMaxLength(50);

            this.Property(t => t.F_JsEvent)
                .HasMaxLength(50);

            this.Property(t => t.F_UrlAddress)
                .HasMaxLength(500);

            this.Property(t => t.F_Description)
                .HasMaxLength(500);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_LastModifyUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_DeleteUserId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_ModuleButton");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_ModuleId).HasColumnName("F_ModuleId");
            this.Property(t => t.F_ParentId).HasColumnName("F_ParentId");
            this.Property(t => t.F_Layers).HasColumnName("F_Layers");
            this.Property(t => t.F_EnCode).HasColumnName("F_EnCode");
            this.Property(t => t.F_FullName).HasColumnName("F_FullName");
            this.Property(t => t.F_Icon).HasColumnName("F_Icon");
            this.Property(t => t.F_Location).HasColumnName("F_Location");
            this.Property(t => t.F_JsEvent).HasColumnName("F_JsEvent");
            this.Property(t => t.F_UrlAddress).HasColumnName("F_UrlAddress");
            this.Property(t => t.F_Split).HasColumnName("F_Split");
            this.Property(t => t.F_IsPublic).HasColumnName("F_IsPublic");
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