﻿// <auto-generated />
using System;
using EventReg.DB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventReg.Data.Migrations
{
    [DbContext(typeof(EventDBContext))]
    [Migration("20220226221113_EventDB-v2")]
    partial class EventDBv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventReg.Data.Model.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Event");

                    b.HasDiscriminator<string>("EventType").HasValue("Event");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Software",
                            EndDateTime = new DateTime(2022, 2, 27, 5, 11, 13, 561, DateTimeKind.Local).AddTicks(5142),
                            Name = "Programming",
                            StartDateTime = new DateTime(2022, 3, 3, 0, 11, 13, 560, DateTimeKind.Local).AddTicks(6238)
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Hardware",
                            EndDateTime = new DateTime(2022, 3, 6, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5532),
                            Name = "Network",
                            StartDateTime = new DateTime(2022, 3, 3, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5522)
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Software",
                            EndDateTime = new DateTime(2022, 3, 2, 5, 11, 13, 561, DateTimeKind.Local).AddTicks(5543),
                            Name = "Devpos",
                            StartDateTime = new DateTime(2022, 3, 1, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5541)
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Software",
                            EndDateTime = new DateTime(2022, 3, 2, 5, 11, 13, 561, DateTimeKind.Local).AddTicks(5545),
                            Name = "C#",
                            StartDateTime = new DateTime(2022, 3, 2, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5544)
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Software",
                            EndDateTime = new DateTime(2022, 2, 28, 5, 11, 13, 561, DateTimeKind.Local).AddTicks(5548),
                            Name = "Java",
                            StartDateTime = new DateTime(2022, 2, 28, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5547)
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Software",
                            EndDateTime = new DateTime(2022, 2, 26, 5, 11, 13, 561, DateTimeKind.Local).AddTicks(5550),
                            Name = "Python",
                            StartDateTime = new DateTime(2022, 2, 26, 0, 11, 13, 561, DateTimeKind.Local).AddTicks(5549)
                        });
                });

            modelBuilder.Entity("EventReg.Data.Model.Registration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<long>("EventId")
                        .HasColumnType("bigint");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("EventReg.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            Password = "Admin12345",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("EventReg.Data.Model.NewInfoForEvent", b =>
                {
                    b.HasBaseType("EventReg.Data.Model.Event");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("NewInfoForEvent");
                });

            modelBuilder.Entity("EventReg.Data.Model.Registration", b =>
                {
                    b.HasOne("EventReg.Data.Model.Event", "EventRegisteration")
                        .WithMany("EventRegistrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
