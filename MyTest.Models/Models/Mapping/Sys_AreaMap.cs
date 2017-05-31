using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_AreaMap : EntityTypeConfiguration<Sys_Area>
    {
        public Sys_AreaMap()
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

            this.Property(t => t.F_SimpleSpelling)
                .HasMaxLength(50);

            this.Property(t => t.F_Description)
                .HasMaxLength(500);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_LastModifyUserId)
                .HasMaxLength(50);

            this.Property(t => t.F_DeleteUserId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_Area");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_ParentId).HasColumnName("F_ParentId");
            this.Property(t => t.F_Layers).HasColumnName("F_Layers");
            this.Property(t => t.F_EnCode).HasColumnName("F_EnCode");
            this.Property(t => t.F_FullName).HasColumnName("F_FullName");
            this.Property(t => t.F_SimpleSpelling).HasColumnName("F_SimpleSpelling");
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
