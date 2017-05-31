using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_RoleAuthorizeMap : EntityTypeConfiguration<Sys_RoleAuthorize>
    {
        public Sys_RoleAuthorizeMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_ItemId)
                .HasMaxLength(50);

            this.Property(t => t.F_ObjectId)
                .HasMaxLength(50);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_RoleAuthorize");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_ItemType).HasColumnName("F_ItemType");
            this.Property(t => t.F_ItemId).HasColumnName("F_ItemId");
            this.Property(t => t.F_ObjectType).HasColumnName("F_ObjectType");
            this.Property(t => t.F_ObjectId).HasColumnName("F_ObjectId");
            this.Property(t => t.F_SortCode).HasColumnName("F_SortCode");
            this.Property(t => t.F_CreatorTime).HasColumnName("F_CreatorTime");
            this.Property(t => t.F_CreatorUserId).HasColumnName("F_CreatorUserId");
        }
    }
}
