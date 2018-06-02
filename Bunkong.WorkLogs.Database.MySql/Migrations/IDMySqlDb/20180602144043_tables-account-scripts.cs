using Bunkong.WorkLogs.Common;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bunkong.WorkLogs.Database.MySql.Migrations.IDMySqlDb
{
    public partial class tablesaccountscripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    NameLocale = table.Column<string>(maxLength: 90, nullable: true),
                    Remark = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    RoleId = table.Column<string>(maxLength: 36, nullable: true),
                    UserId = table.Column<string>(maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    UserFullName = table.Column<string>(maxLength: 80, nullable: true),
                    UserName = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLogs",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    LogTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(maxLength: 90, nullable: true),
                    WorkContent = table.Column<string>(maxLength: 500, nullable: true),
                    WorkDate = table.Column<DateTime>(nullable: false),
                    WorkHoures = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLogs", x => x.Id);
                });

            migrationBuilder.Sql($@"
                --   insert test worklogs
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),6.9,'建立架构','','2018-05-01',sysdate()) ;
                
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),2.4,'架构完善','','2018-05-02',sysdate());

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),7,'架构测试','','2018-05-03',sysdate());

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),8,'功能设计','','2018-05-04',sysdate());
                
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),9,'功能开发','','2018-05-05',sysdate());

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),6,'功能开发','','2018-05-06',sysdate());

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),19,'框架实现','','2018-05-07',sysdate());
 
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(uuid(),1,'实用性检测','','2018-05-08',sysdate());

                -- insert users 
                set @userIdGuest = uuid();
                Insert Into Users(Id,Name,UserName,Password,UserFullName)
                Values(@userIdGuest,'游客','guest','{"guest".ToMD5()}','游客');

                set @userIdAdmin = uuid();
                Insert Into Users(Id,Name,UserName,Password,UserFullName)
                Values(@userIdAdmin,'系统管理员','Admin','{"Admin_12340".ToMD5()}','系统管理员');

                -- insert roles
                set @roleIdGuest = uuid();
                Insert Into Roles(Id,Name,NameLocale)
                Values(@roleIdGuest,'Guest','游客'); 
                
                set @roleIdAdmin = uuid();
                Insert Into Roles(Id,Name,NameLocale)
                Values(@roleIdAdmin,'Administrator','系统管理员');

                -- insert userRoles
                insert into UserRoles(Id,UserId,RoleId)
                Values(uuid(),@userIdGuest,@roleIdGuest);
 
                insert into UserRoles(Id,UserId,RoleId)
                Values(uuid(),@userIdAdmin,@roleIdAdmin);

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkLogs");
        }
    }
}
