using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bunkong.WorkLogs.Database.MySql.Migrations
{
    public partial class MySql_WorkLogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkLogs",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 60, nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkLogs");
        }
    }
}
