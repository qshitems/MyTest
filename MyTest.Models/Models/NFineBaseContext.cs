using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyTest.Models.Models.Mapping;

namespace MyTest.Models.Models
{
    public partial class NFineBaseContext : DbContext
    {
        static NFineBaseContext()
        {
            Database.SetInitializer<NFineBaseContext>(null);
        }

        public NFineBaseContext()
            : base("Name=NFineBaseContext")
        {
        }

        public DbSet<Sys_Area> Sys_Area { get; set; }
        public DbSet<Sys_DbBackup> Sys_DbBackup { get; set; }
        public DbSet<Sys_FilterIP> Sys_FilterIP { get; set; }
        public DbSet<Sys_Items> Sys_Items { get; set; }
        public DbSet<Sys_ItemsDetail> Sys_ItemsDetail { get; set; }
        public DbSet<Sys_Log> Sys_Log { get; set; }
        public DbSet<Sys_Module> Sys_Module { get; set; }
        public DbSet<Sys_ModuleButton> Sys_ModuleButton { get; set; }
        public DbSet<Sys_ModuleForm> Sys_ModuleForm { get; set; }
        public DbSet<Sys_ModuleFormInstance> Sys_ModuleFormInstance { get; set; }
        public DbSet<Sys_Organize> Sys_Organize { get; set; }
        public DbSet<Sys_Role> Sys_Role { get; set; }
        public DbSet<Sys_RoleAuthorize> Sys_RoleAuthorize { get; set; }
        public DbSet<Sys_User> Sys_User { get; set; }
        public DbSet<Sys_UserLogOn> Sys_UserLogOn { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Sys_AreaMap());
            modelBuilder.Configurations.Add(new Sys_DbBackupMap());
            modelBuilder.Configurations.Add(new Sys_FilterIPMap());
            modelBuilder.Configurations.Add(new Sys_ItemsMap());
            modelBuilder.Configurations.Add(new Sys_ItemsDetailMap());
            modelBuilder.Configurations.Add(new Sys_LogMap());
            modelBuilder.Configurations.Add(new Sys_ModuleMap());
            modelBuilder.Configurations.Add(new Sys_ModuleButtonMap());
            modelBuilder.Configurations.Add(new Sys_ModuleFormMap());
            modelBuilder.Configurations.Add(new Sys_ModuleFormInstanceMap());
            modelBuilder.Configurations.Add(new Sys_OrganizeMap());
            modelBuilder.Configurations.Add(new Sys_RoleMap());
            modelBuilder.Configurations.Add(new Sys_RoleAuthorizeMap());
            modelBuilder.Configurations.Add(new Sys_UserMap());
            modelBuilder.Configurations.Add(new Sys_UserLogOnMap());
        }
    }
}
