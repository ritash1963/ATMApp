﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220401142747_AdditionalCreate")]
    partial class AdditionalCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("ClientName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AccountsTbl");
                });

            modelBuilder.Entity("API.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PIN")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("CardsTbl");
                });

            modelBuilder.Entity("API.Entities.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardName")
                        .HasColumnType("TEXT");

                    b.Property<float>("Commission")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("CardTypesTbl");
                });

            modelBuilder.Entity("API.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypesTbl");
                });

            modelBuilder.Entity("API.Entities.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Commissions")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentRef")
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentType")
                        .HasColumnType("INTEGER");

                    b.Property<float>("OperationSum")
                        .HasColumnType("REAL");

                    b.Property<int>("OperationType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("OperationsTbl");
                });

            modelBuilder.Entity("API.Entities.OperationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OperationName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OperationTypesTbl");
                });

            modelBuilder.Entity("API.Entities.Card", b =>
                {
                    b.HasOne("API.Entities.Account", "Account")
                        .WithMany("CardsTbl")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("API.Entities.Account", b =>
                {
                    b.Navigation("CardsTbl");
                });
#pragma warning restore 612, 618
        }
    }
}