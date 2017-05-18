using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Dream.EntityFrameworkCore;

namespace Dream.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dream.Model.Models.Function", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("MenuId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PicName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Status")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("Dream.Model.Models.KeyValue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Type")
                        .HasMaxLength(40);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("KeyValue");
                });

            modelBuilder.Entity("Dream.Model.Models.Menu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int?>("Exp2")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Expl")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Level")
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("PicName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SortId")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("Status")
                        .HasMaxLength(2);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Dream.Model.Models.OrganStruct", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("CateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int?>("Level")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Status")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("CateId");

                    b.ToTable("OrganStruct");
                });

            modelBuilder.Entity("Dream.Model.Models.PermissList", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("FunctionId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("MenuId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissList");
                });

            modelBuilder.Entity("Dream.Model.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Sort")
                        .HasMaxLength(3);

                    b.Property<int>("Status")
                        .HasMaxLength(2);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleType");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Dream.Model.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LoginPwd")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("RegisterTime");

                    b.Property<string>("UserInfoId");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Dream.Model.Models.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int?>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Gender")
                        .HasMaxLength(2);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("QQ")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<int>("Status")
                        .HasMaxLength(2);

                    b.Property<string>("TelPhone")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("Dream.Model.Models.UserManageInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Gender")
                        .HasMaxLength(4);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OrganStruct1Id");

                    b.Property<string>("QQ")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Status")
                        .HasMaxLength(2);

                    b.Property<string>("TelPhone")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("WorkGroupId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("OrganStruct1Id");

                    b.HasIndex("WorkGroupId");

                    b.ToTable("UserManageInfo");
                });

            modelBuilder.Entity("Dream.Model.Models.UserManageInfoRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UserManageInfoId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserManageInfoId");

                    b.ToTable("UserManageInfoRole");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowProcess", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("Ext1")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<int?>("Ext2")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("WorkFlowRequestFormId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("WorkFlowRequestFormStatus")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("WorkFlowWorkNodesId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("WorkFlowRequestFormId");

                    b.HasIndex("WorkFlowRequestFormStatus");

                    b.HasIndex("WorkFlowWorkNodesId");

                    b.ToTable("WorkFlowProcess");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowRequestForm", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Ext1")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.Property<int?>("Ext2")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LogicSymbol")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<decimal>("Num")
                        .HasMaxLength(40);

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserManageInfoId");

                    b.Property<string>("WorkFlowWorkId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Priority");

                    b.HasIndex("Status");

                    b.HasIndex("UserManageInfoId");

                    b.HasIndex("WorkFlowWorkId");

                    b.ToTable("WorkFlowRequestForm");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowWork", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<int>("Status")
                        .HasMaxLength(4);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.ToTable("WorkFlowWork");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowWorkBranch", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("WorkFlowNodeToken")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("WorkFlowWorkNodesId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("WorkFlowWorkNodesId");

                    b.ToTable("WorkFlowWorkBranch");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowWorkNodes", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(40);

                    b.Property<string>("BizMethod")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int?>("Ext1")
                        .HasMaxLength(50);

                    b.Property<string>("Ext2")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("MaxNum")
                        .HasMaxLength(50);

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UpdateId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("WorkFlowId")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("WorkFlowOrderNo")
                        .HasMaxLength(10);

                    b.Property<string>("WorkFlowfWorkId");

                    b.HasKey("Id");

                    b.HasIndex("RoleType");

                    b.HasIndex("Type");

                    b.HasIndex("WorkFlowfWorkId");

                    b.ToTable("WorkFlowWorkNodes");
                });

            modelBuilder.Entity("Dream.Model.Models.Function", b =>
                {
                    b.HasOne("Dream.Model.Models.Menu", "Menus")
                        .WithMany("Function")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream.Model.Models.OrganStruct", b =>
                {
                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue")
                        .WithMany("OrganStruct")
                        .HasForeignKey("CateId");
                });

            modelBuilder.Entity("Dream.Model.Models.PermissList", b =>
                {
                    b.HasOne("Dream.Model.Models.Function", "Function")
                        .WithMany("PermissList")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream.Model.Models.Menu", "Menu")
                        .WithMany("PermissList")
                        .HasForeignKey("MenuId");

                    b.HasOne("Dream.Model.Models.Role", "Role")
                        .WithMany("PermissList")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream.Model.Models.Role", b =>
                {
                    b.HasOne("Dream.Model.Models.OrganStruct", "OrganStruct")
                        .WithMany("Role")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue")
                        .WithMany("Role")
                        .HasForeignKey("RoleType");
                });

            modelBuilder.Entity("Dream.Model.Models.User", b =>
                {
                    b.HasOne("Dream.Model.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId");
                });

            modelBuilder.Entity("Dream.Model.Models.UserManageInfo", b =>
                {
                    b.HasOne("Dream.Model.Models.OrganStruct", "OrganStruct3")
                        .WithMany("UserManageInfo1")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Dream.Model.Models.OrganStruct", "OrganStruct1")
                        .WithMany("UserManageInfo3")
                        .HasForeignKey("OrganStruct1Id");

                    b.HasOne("Dream.Model.Models.OrganStruct", "OrganStruct2")
                        .WithMany("UserManageInfo2")
                        .HasForeignKey("WorkGroupId");
                });

            modelBuilder.Entity("Dream.Model.Models.UserManageInfoRole", b =>
                {
                    b.HasOne("Dream.Model.Models.Role", "Role")
                        .WithMany("UserManageInfoRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream.Model.Models.UserManageInfo", "UserManageInfo")
                        .WithMany("UserManageInfoRole")
                        .HasForeignKey("UserManageInfoId");
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowProcess", b =>
                {
                    b.HasOne("Dream.Model.Models.WorkFlowRequestForm", "WorkFlowRequestForm")
                        .WithMany("WorkFlowProcess")
                        .HasForeignKey("WorkFlowRequestFormId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue")
                        .WithMany("WorkFolwProcess")
                        .HasForeignKey("WorkFlowRequestFormStatus");

                    b.HasOne("Dream.Model.Models.WorkFlowWorkNodes", "WorkFlowWorkNodes")
                        .WithMany("WorkFlowProcess")
                        .HasForeignKey("WorkFlowWorkNodesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowRequestForm", b =>
                {
                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue1")
                        .WithMany("WorkFolwRequestForm1")
                        .HasForeignKey("Priority");

                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue2")
                        .WithMany("WorkFlowRequestForm2")
                        .HasForeignKey("Status");

                    b.HasOne("Dream.Model.Models.UserManageInfo", "UserManageInfo")
                        .WithMany("WorkFlowRequestForm")
                        .HasForeignKey("UserManageInfoId");

                    b.HasOne("Dream.Model.Models.WorkFlowWork", "WorkFlowWork")
                        .WithMany("WorkFlowRequestForm")
                        .HasForeignKey("WorkFlowWorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowWorkBranch", b =>
                {
                    b.HasOne("Dream.Model.Models.WorkFlowWorkNodes", "WorkFlowWorkNodes")
                        .WithMany("WorkFlowWorkBranch")
                        .HasForeignKey("WorkFlowWorkNodesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream.Model.Models.WorkFlowWorkNodes", b =>
                {
                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue2")
                        .WithMany("WorkFolwWorkNodes2")
                        .HasForeignKey("RoleType");

                    b.HasOne("Dream.Model.Models.KeyValue", "KeyValue1")
                        .WithMany("WorkFolwWorkNodes1")
                        .HasForeignKey("Type");

                    b.HasOne("Dream.Model.Models.WorkFlowWork", "WorkFlowfWork")
                        .WithMany("WorkFlowWorkNodes")
                        .HasForeignKey("WorkFlowfWorkId");
                });
        }
    }
}
