using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bunkong.WorkLogs.DAL.Migrations
{
    public partial class workLogsaddfieldsscripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WorkContent",
                table: "WorkLogs",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LogTime",
                table: "WorkLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "WorkLogs",
                maxLength: 90,
                nullable: true);

            migrationBuilder.Sql(@"
                -- test inserts
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),6.9,N'建立架构',N'','2018-05-01',getDate()) 
                
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),2.4,N'架构完善',N'','2018-05-02',getDate())

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),7,N'架构测试',N'','2018-05-03',getDate())

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),8,N'功能设计',N'','2018-05-04',getDate())
                
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),9,N'功能开发',N'','2018-05-05',getDate())

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),6,N'功能开发',N'','2018-05-06',getDate())

                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),19,N'框架实现',N'','2018-05-07',getDate())
 
                Insert Into WorkLogs(Id,WorkHoures,WorkContent,Remark,WorkDate,LogTime)
                Values(newid(),1,N'实用性检测',N'','2018-05-08',getDate())
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogTime",
                table: "WorkLogs");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "WorkLogs");

            migrationBuilder.AlterColumn<string>(
                name: "WorkContent",
                table: "WorkLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
