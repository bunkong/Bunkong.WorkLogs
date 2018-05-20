using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bunkong.WorkLogs.DAL.Migrations
{
    public partial class workLogsfoward : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkContent",
                table: "WorkLogs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkDate",
                table: "WorkLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "WorkHoures",
                table: "WorkLogs",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkContent",
                table: "WorkLogs");

            migrationBuilder.DropColumn(
                name: "WorkDate",
                table: "WorkLogs");

            migrationBuilder.DropColumn(
                name: "WorkHoures",
                table: "WorkLogs");
        }
    }
}
