﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TemplateFileSystem.Data.DbContexts;

#nullable disable

namespace TemplateFileSystem.Data.Migrations
{
    [DbContext(typeof(ConfigurationContext))]
    [Migration("20240803192505_UpdateStringLengthForEndpointConfiguration")]
    partial class UpdateStringLengthForEndpointConfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("TemplateFileSystem.Data.Models.EndpointConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TblConfiguration", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Endpoint1",
                            Url = "https://endpoint1.com"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Endpoint2",
                            Url = "https://endpoint2.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
