﻿// <auto-generated />
using Bunkong.WorkLogs.Database.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace Bunkong.WorkLogs.Database.MySql.Migrations.IDMySqlDb
{
    [DbContext(typeof(IDMySqlDbContext))]
    partial class IDMySqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Bunkong.WorkLogs.Database.Schema.Roles", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<string>("NameLocale")
                        .HasMaxLength(90);

                    b.Property<string>("Remark")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Bunkong.WorkLogs.Database.Schema.UserRoles", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("RoleId")
                        .HasMaxLength(36);

                    b.Property<string>("UserId")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Bunkong.WorkLogs.Database.Schema.Users", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasMaxLength(200);

                    b.Property<string>("UserFullName")
                        .HasMaxLength(80);

                    b.Property<string>("UserName")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bunkong.WorkLogs.Database.Schema.WorkLog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<DateTime>("LogTime");

                    b.Property<string>("Remark")
                        .HasMaxLength(90);

                    b.Property<string>("WorkContent")
                        .HasMaxLength(500);

                    b.Property<DateTime>("WorkDate");

                    b.Property<double>("WorkHoures");

                    b.HasKey("Id");

                    b.ToTable("WorkLogs");
                });
#pragma warning restore 612, 618
        }
    }
}