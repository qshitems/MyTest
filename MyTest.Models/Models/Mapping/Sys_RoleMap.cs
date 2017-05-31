using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_RoleMap : EntityTypeConfiguration<Sys_Role>
    {
        public Sys_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_OrganizeId)
                .HasMaxLength(50);

            this.Property(t => t.F_EnCode)
                .HasMaxLength(50);

            this.Property(t => t.F_FullName)
                .HasMaxLength(50);

            this.Property(t => t.F_Type)
                .HasMaxLength(50);

            this.Property(t => t.F_Description)
                .HasMaxLength(500);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_LastModifyUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_DeleteUserId)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Sys_Role");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_OrganizeId).HasColumnName("F_OrganizeId");
            this.Property(t => t.F_Category).HasColumnName("F_Category");
            this.Property(t => t.F_EnCode).HasColumnName("F_EnCode");
            this.Property(t => t.F_FullName).HasColumnName("F_FullName");
            this.Property(t => t.F_Type).HasColumnName("F_Type");
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
