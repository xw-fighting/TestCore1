using Dream.Model.Models;
using Microsoft.EntityFrameworkCore;


namespace Dream.EntityFrameworkCore
{
    public class BaseDbContext :DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {

        }

        public DbSet<Function> Function { get; set; }
        public DbSet<KeyValue> KeyValue { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<OrganStruct> OrganStruct { get; set; }
        public DbSet<PermissList> PermissList { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserManageInfo> UserManageInfo { get; set; }

        public DbSet<UserManageInfoRole> UserManageInfoRole { get; set; }
        public DbSet<WorkFlowProcess> WorkFlowProcess { get; set; }
        public DbSet<WorkFlowRequestForm> WorkFlowRequestForm { get; set; }
        public DbSet<WorkFlowWork> WorkFlowWork { get; set; }
        public DbSet<WorkFlowWorkBranch> WorkFlowWorkBranch { get; set; }
        public DbSet<WorkFlowWorkNodes> WorkFlowWorkNodes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Function>().ToTable("Function")
                .HasKey(f => f.Id); 
            modelBuilder.Entity<KeyValue>().ToTable("KeyValue");

            modelBuilder.Entity<Menu>().ToTable("Menu");

            modelBuilder.Entity<OrganStruct>().ToTable("OrganStruct")
                .HasOne(o => o.KeyValue)
                .WithMany(k => k.OrganStruct)
                .HasForeignKey(o => o.CateId)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<PermissList>().ToTable("PermissList");

            modelBuilder.Entity<Role>().ToTable("Role")
                .HasOne(r => r.KeyValue)
                .WithMany(k => k.Role)
                .HasForeignKey(r => r.RoleType)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<Role>().ToTable("Role")
                .HasOne(r => r.OrganStruct)
                .WithMany(o => o.Role)
                .HasForeignKey(r => r.DepartmentId)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
            modelBuilder.Entity<UserManageInfo>().ToTable("UserManageInfo")
                .HasOne(u => u.OrganStruct2)
                .WithMany(o => o.UserManageInfo)
                .HasForeignKey(u => u.WorkGroupId)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<UserManageInfo>().ToTable("UserManageInfo")
                .HasOne(u => u.OrganStruct3)
                .WithMany(o => o.UserManageInfo1)
                .HasForeignKey(u => u.DepartmentId)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<UserManageInfoRole>().ToTable("UserManageInfoRole");

            modelBuilder.Entity<WorkFlowProcess>().ToTable("WorkFlowProcess");

            modelBuilder.Entity<WorkFlowRequestForm>().ToTable("WorkFlowRequestForm")
                .HasOne(w => w.KeyValue1)
                .WithMany(k => k.WorkFolwRequestForm1)
                .HasForeignKey(w => w.Priority)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkFlowRequestForm>().ToTable("WorkFlowRequestForm")
                .HasOne(w => w.KeyValue2)
                .WithMany(k => k.WorkFlowRequestForm2)
                .HasForeignKey(w => w.Status)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkFlowWork>().ToTable("WorkFlowWork");
            modelBuilder.Entity<WorkFlowWorkBranch>().ToTable("WorkFlowWorkBranch");

            modelBuilder.Entity<WorkFlowWorkNodes>().ToTable("WorkFlowWorkNodes")
                .HasOne(w => w.KeyValue1)
                .WithMany(k => k.WorkFolwWorkNodes1)
                .HasForeignKey(w => w.Type)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkFlowWorkNodes>().ToTable("WorkFlowWorkNodes")
                .HasOne(w => w.KeyValue2)
                .WithMany(k => k.WorkFolwWorkNodes2)
                .HasForeignKey(w => w.RoleType)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
        }


    }
}
