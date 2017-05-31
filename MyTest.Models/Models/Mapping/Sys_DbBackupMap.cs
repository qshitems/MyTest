using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_DbBackupMap : EntityTypeConfiguration<Sys_DbBackup>
    {
        public Sys_DbBackupMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_BackupType)
                .HasMaxLength(50);

            this.Property(t => t.F_DbName)
                .HasMaxLength(50);

            this.Property(t => t.F_FileName)
                .HasMaxLength(50);

            this.Property(t => t.F_FileSize)
                .HasMaxLength(50);

            this.Property(t => t.F_FilePath)
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
            this.ToTable("Sys_DbBackup");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_BackupType).HasColumnName("F_BackupType");
            this.Property(t => t.F_DbName).HasColumnName("F_DbName");
            this.Property(t => t.F_FileName).HasColumnName("F_FileName");
            this.Property(t => t.F_FileSize).HasColumnName("F_FileSize");
            this.Property(t => t.F_FilePath).HasColumnName("F_FilePath");
            this.Property(t => t.F_BackupTime).HasColumnName("F_BackupTime");
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
