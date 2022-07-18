﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Infra.Context;

namespace Salon.Infra.Migrations
{
    [DbContext(typeof(SalonContext))]
    [Migration("20220718225534_add-class-task")]
    partial class addclasstask
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Salon.Model.Models.Services", b =>
                {
                    b.Property<int>("IdService")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceService")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdService");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Salon.Model.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateInitial")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ServiceIdService")
                        .HasColumnType("int");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceIdService");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Salon.Model.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Salon.Model.Models.Task", b =>
                {
                    b.HasOne("Salon.Model.Models.Services", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceIdService");

                    b.HasOne("Salon.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Service");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
