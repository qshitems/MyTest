using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyTest.Models.Models.Mapping
{
    public class Sys_UserLogOnMap : EntityTypeConfiguration<Sys_UserLogOn>
    {
        public Sys_UserLogOnMap()
        {
            // Primary Key
            this.HasKey(t => t.F_Id);

            // Properties
            this.Property(t => t.F_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F_UserId)
                .HasMaxLength(50);

            this.Property(t => t.F_UserPassword)
                .HasMaxLength(50);

            this.Property(t => t.F_UserSecretkey)
                .HasMaxLength(50);

            this.Property(t => t.F_Question)
                .HasMaxLength(50);

            this.Property(t => t.F_AnswerQuestion)
                .HasMaxLength(500);

            this.Property(t => t.F_Language)
                .HasMaxLength(50);

            this.Property(t => t.F_Theme)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_UserLogOn");
            this.Property(t => t.F_Id).HasColumnName("F_Id");
            this.Property(t => t.F_UserId).HasColumnName("F_UserId");
            this.Property(t => t.F_UserPassword).HasColumnName("F_UserPassword");
            this.Property(t => t.F_UserSecretkey).HasColumnName("F_UserSecretkey");
            this.Property(t => t.F_AllowStartTime).HasColumnName("F_AllowStartTime");
            this.Property(t => t.F_AllowEndTime).HasColumnName("F_AllowEndTime");
            this.Property(t => t.F_LockStartDate).HasColumnName("F_LockStartDate");
            this.Property(t => t.F_LockEndDate).HasColumnName("F_LockEndDate");
            this.Property(t => t.F_FirstVisitTime).HasColumnName("F_FirstVisitTime");
            this.Property(t => t.F_PreviousVisitTime).HasColumnName("F_PreviousVisitTime");
            this.Property(t => t.F_LastVisitTime).HasColumnName("F_LastVisitTime");
            this.Property(t => t.F_ChangePasswordDate).HasColumnName("F_ChangePasswordDate");
            this.Property(t => t.F_MultiUserLogin).HasColumnName("F_MultiUserLogin");
            this.Property(t => t.F_LogOnCount).HasColumnName("F_LogOnCount");
            this.Property(t => t.F_UserOnLine).HasColumnName("F_UserOnLine");
            this.Property(t => t.F_Question).HasColumnName("F_Question");
            this.Property(t => t.F_AnswerQuestion).HasColumnName("F_AnswerQuestion");
            this.Property(t => t.F_CheckIPAddress).HasColumnName("F_CheckIPAddress");
            this.Property(t => t.F_Language).HasColumnName("F_Language");
            this.Property(t => t.F_Theme).HasColumnName("F_Theme");
        }
    }
}
