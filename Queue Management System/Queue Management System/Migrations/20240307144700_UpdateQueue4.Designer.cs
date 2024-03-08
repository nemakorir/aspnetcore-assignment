﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Queue_Management_System.Models;

#nullable disable

namespace Queue_Management_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240307144700_UpdateQueue4")]
    partial class UpdateQueue4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Queue_Management_System.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Queue_Management_System.Models.QueueItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Finished")
                        .HasColumnType("boolean");

                    b.Property<bool>("NoShow")
                        .HasColumnType("boolean");

                    b.Property<int>("ServicePointId")
                        .HasColumnType("integer");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QueueItems");
                });

            modelBuilder.Entity("Queue_Management_System.Models.ServicePoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Finished")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("NoShow")
                        .HasColumnType("boolean");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ServicePoints");
                });

            modelBuilder.Entity("Queue_Management_System.Models.WaitingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("ServicePoint")
                        .HasColumnType("integer");

                    b.Property<string>("ServicePointName")
                        .HasColumnType("text");

                    b.Property<int?>("TicketNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ServicePoint");

                    b.ToTable("waitingModels");
                });

            modelBuilder.Entity("Queue_Management_System.Models.WaitingModel", b =>
                {
                    b.HasOne("Queue_Management_System.Models.ServicePoint", "Service")
                        .WithMany()
                        .HasForeignKey("ServicePoint");

                    b.Navigation("Service");
                });
#pragma warning restore 612, 618
        }
    }
}
