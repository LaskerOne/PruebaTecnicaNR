﻿// <auto-generated />
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220921025008_firstMig")]
    partial class firstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Models.UsersBC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<byte>("age")
                        .HasColumnType("tinyint");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("genre")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("lastName2")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("secondName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.ToTable("UsersBC");
                });
#pragma warning restore 612, 618
        }
    }
}
