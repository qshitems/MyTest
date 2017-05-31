using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_LogMap : EntityTypeConfiguration<Sys_Log>
    {
        public Sys_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_Account)
                .HasMaxLength(50);

            this.Property(t => t.F_NickName)
                .HasMaxLength(50);

            this.Property(t => t.F_Type)
                .HasMaxLength(50);

            this.Property(t => t.F_IPAddress)
                .HasMaxLength(50);

            this.Property(t => t.F_IPAddressName)
                .HasMaxLength(50);

            this.Property(t => t.F_ModuleId)
                .HasMaxLength(50);

            this.Property(t => t.F_ModuleName)
                .HasMaxLength(50);

            this.Property(t => t.F_Description)
                .HasMaxLength(500);

            this.Property(t => t.F_CreatorUserId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_Log");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_Date).HasColumnName("F_Date");
            this.Property(t => t.F_Account).HasColumnName("F_Account");
            this.Property(t => t.F_NickName).HasColumnName("F_NickName");
            this.Property(t => t.F_Type).HasColumnName("F_Type");
            this.Property(t => t.F_IPAddress).HasColumnName("F_IPAddress");
            this.Property(t => t.F_IPAddressName).HasColumnName("F_IPAddressName");
            this.Property(t => t.F_ModuleId).HasColumnName("F_ModuleId");
            this.Property(t => t.F_ModuleName).HasColumnName("F_ModuleName");
            this.Property(t => t.F_Result).HasColumnName("F_Result");
            this.Property(t => t.F_Description).HasColumnName("F_Description");
            this.Property(t => t.F_CreatorTime).HasColumnName("F_CreatorTime");
            this.Property(t => t.F_CreatorUserId).HasColumnName("F_CreatorUserId");
        }
    }
}
