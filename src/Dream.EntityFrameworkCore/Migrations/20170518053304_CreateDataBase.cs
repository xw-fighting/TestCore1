using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dream.EntityFrameworkCore.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyValue",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ParentId = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 250, nullable: false),
                    Type = table.Column<int>(maxLength: 40, nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    Action = table.Column<string>(maxLength: 50, nullable: false),
                    Area = table.Column<string>(maxLength: 50, nullable: false),
                    Controller = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Exp2 = table.Column<int>(maxLength: 5, nullable: false),
                    Expl = table.Column<string>(maxLength: 250, nullable: false),
                    Level = table.Column<int>(maxLength: 3, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ParentId = table.Column<string>(maxLength: 40, nullable: false),
                    PicName = table.Column<string>(maxLength: 50, nullable: false),
                    SortId = table.Column<string>(maxLength: 5, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 150, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    DepartmentName = table.Column<int>(maxLength: 140, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Gender = table.Column<int>(maxLength: 2, nullable: false),
                    Mobile = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    QQ = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 240, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    TelPhone = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowWork",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 240, nullable: false),
                    Status = table.Column<int>(maxLength: 4, nullable: false),
                    Title = table.Column<string>(maxLength: 120, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganStruct",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CateId = table.Column<string>(maxLength: 40, nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Level = table.Column<int>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    ParentId = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 240, nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganStruct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganStruct_KeyValue_CateId",
                        column: x => x.CateId,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    ActionName = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    MenuId = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PicName = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Function_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    LoginName = table.Column<string>(maxLength: 50, nullable: false),
                    LoginPwd = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 40, nullable: false),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    UserInfoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserInfo_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowWorkNodes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    BizMethod = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Ext1 = table.Column<int>(maxLength: 50, nullable: true),
                    Ext2 = table.Column<string>(maxLength: 50, nullable: false),
                    MaxNum = table.Column<decimal>(maxLength: 50, nullable: false),
                    RoleType = table.Column<string>(maxLength: 40, nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    WorkFlowId = table.Column<string>(maxLength: 40, nullable: false),
                    WorkFlowOrderNo = table.Column<int>(maxLength: 10, nullable: false),
                    WorkFlowfWorkId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowWorkNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowWorkNodes_KeyValue_RoleType",
                        column: x => x.RoleType,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowWorkNodes_KeyValue_Type",
                        column: x => x.Type,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowWorkNodes_WorkFlowWork_WorkFlowfWorkId",
                        column: x => x.WorkFlowfWorkId,
                        principalTable: "WorkFlowWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    DepartmentId = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Remark = table.Column<string>(maxLength: 240, nullable: false),
                    RoleType = table.Column<string>(maxLength: 40, nullable: false),
                    Sort = table.Column<int>(maxLength: 3, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_OrganStruct_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "OrganStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_KeyValue_RoleType",
                        column: x => x.RoleType,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserManageInfo",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CompanyId = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    DepartmentId = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Gender = table.Column<int>(maxLength: 4, nullable: false),
                    Mobile = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    OrganStruct1Id = table.Column<string>(nullable: true),
                    QQ = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 250, nullable: false),
                    Status = table.Column<int>(maxLength: 2, nullable: false),
                    TelPhone = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    WorkGroupId = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManageInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserManageInfo_OrganStruct_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "OrganStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserManageInfo_OrganStruct_OrganStruct1Id",
                        column: x => x.OrganStruct1Id,
                        principalTable: "OrganStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserManageInfo_OrganStruct_WorkGroupId",
                        column: x => x.WorkGroupId,
                        principalTable: "OrganStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowWorkBranch",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateId = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    WorkFlowNodeToken = table.Column<string>(maxLength: 40, nullable: false),
                    WorkFlowWorkNodesId = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowWorkBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowWorkBranch_WorkFlowWorkNodes_WorkFlowWorkNodesId",
                        column: x => x.WorkFlowWorkNodesId,
                        principalTable: "WorkFlowWorkNodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissList",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    FunctionId = table.Column<string>(maxLength: 40, nullable: false),
                    MenuId = table.Column<string>(maxLength: 40, nullable: false),
                    RoleId = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissList_Function_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissList_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissList_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserManageInfoRole",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    RoleId = table.Column<string>(maxLength: 40, nullable: false),
                    UserId = table.Column<string>(maxLength: 40, nullable: false),
                    UserManageInfoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManageInfoRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserManageInfoRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserManageInfoRole_UserManageInfo_UserManageInfoId",
                        column: x => x.UserManageInfoId,
                        principalTable: "UserManageInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowRequestForm",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Ext1 = table.Column<string>(maxLength: 140, nullable: false),
                    Ext2 = table.Column<int>(maxLength: 40, nullable: false),
                    LogicSymbol = table.Column<string>(maxLength: 40, nullable: false),
                    Num = table.Column<decimal>(maxLength: 40, nullable: false),
                    Priority = table.Column<string>(maxLength: 40, nullable: false),
                    Remark = table.Column<string>(maxLength: 240, nullable: false),
                    Status = table.Column<string>(maxLength: 40, nullable: false),
                    Title = table.Column<string>(maxLength: 140, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserManageInfoId = table.Column<string>(nullable: true),
                    WorkFlowWorkId = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowRequestForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowRequestForm_KeyValue_Priority",
                        column: x => x.Priority,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowRequestForm_KeyValue_Status",
                        column: x => x.Status,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowRequestForm_UserManageInfo_UserManageInfoId",
                        column: x => x.UserManageInfoId,
                        principalTable: "UserManageInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowRequestForm_WorkFlowWork_WorkFlowWorkId",
                        column: x => x.WorkFlowWorkId,
                        principalTable: "WorkFlowWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowProcess",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 40, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(maxLength: 240, nullable: false),
                    Ext1 = table.Column<string>(maxLength: 240, nullable: false),
                    Ext2 = table.Column<int>(maxLength: 40, nullable: false),
                    Processor = table.Column<string>(maxLength: 40, nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    WorkFlowRequestFormId = table.Column<string>(maxLength: 40, nullable: false),
                    WorkFlowRequestFormStatus = table.Column<string>(maxLength: 40, nullable: false),
                    WorkFlowWorkNodesId = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowProcess_WorkFlowRequestForm_WorkFlowRequestFormId",
                        column: x => x.WorkFlowRequestFormId,
                        principalTable: "WorkFlowRequestForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkFlowProcess_KeyValue_WorkFlowRequestFormStatus",
                        column: x => x.WorkFlowRequestFormStatus,
                        principalTable: "KeyValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowProcess_WorkFlowWorkNodes_WorkFlowWorkNodesId",
                        column: x => x.WorkFlowWorkNodesId,
                        principalTable: "WorkFlowWorkNodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Function_MenuId",
                table: "Function",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganStruct_CateId",
                table: "OrganStruct",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissList_FunctionId",
                table: "PermissList",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissList_MenuId",
                table: "PermissList",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissList_RoleId",
                table: "PermissList",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_DepartmentId",
                table: "Role",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleType",
                table: "Role",
                column: "RoleType");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserInfoId",
                table: "User",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManageInfo_DepartmentId",
                table: "UserManageInfo",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManageInfo_OrganStruct1Id",
                table: "UserManageInfo",
                column: "OrganStruct1Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserManageInfo_WorkGroupId",
                table: "UserManageInfo",
                column: "WorkGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManageInfoRole_RoleId",
                table: "UserManageInfoRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManageInfoRole_UserManageInfoId",
                table: "UserManageInfoRole",
                column: "UserManageInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowProcess_WorkFlowRequestFormId",
                table: "WorkFlowProcess",
                column: "WorkFlowRequestFormId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowProcess_WorkFlowRequestFormStatus",
                table: "WorkFlowProcess",
                column: "WorkFlowRequestFormStatus");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowProcess_WorkFlowWorkNodesId",
                table: "WorkFlowProcess",
                column: "WorkFlowWorkNodesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowRequestForm_Priority",
                table: "WorkFlowRequestForm",
                column: "Priority");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowRequestForm_Status",
                table: "WorkFlowRequestForm",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowRequestForm_UserManageInfoId",
                table: "WorkFlowRequestForm",
                column: "UserManageInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowRequestForm_WorkFlowWorkId",
                table: "WorkFlowRequestForm",
                column: "WorkFlowWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowWorkBranch_WorkFlowWorkNodesId",
                table: "WorkFlowWorkBranch",
                column: "WorkFlowWorkNodesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowWorkNodes_RoleType",
                table: "WorkFlowWorkNodes",
                column: "RoleType");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowWorkNodes_Type",
                table: "WorkFlowWorkNodes",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowWorkNodes_WorkFlowfWorkId",
                table: "WorkFlowWorkNodes",
                column: "WorkFlowfWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissList");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserManageInfoRole");

            migrationBuilder.DropTable(
                name: "WorkFlowProcess");

            migrationBuilder.DropTable(
                name: "WorkFlowWorkBranch");

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "WorkFlowRequestForm");

            migrationBuilder.DropTable(
                name: "WorkFlowWorkNodes");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "UserManageInfo");

            migrationBuilder.DropTable(
                name: "WorkFlowWork");

            migrationBuilder.DropTable(
                name: "OrganStruct");

            migrationBuilder.DropTable(
                name: "KeyValue");
        }
    }
}
