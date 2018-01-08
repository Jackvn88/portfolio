﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShuPortfolio.Models;
using System;

namespace ShuPortfolio.Migrations
{
    [DbContext(typeof(CategoriesDbContext))]
    [Migration("20171212201811_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShuPortfolio.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShuPortfolio.Models.Work", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryID");

                    b.Property<DateTime>("DataCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("ShuPortfolio.Models.Work", b =>
                {
                    b.HasOne("ShuPortfolio.Models.Category")
                        .WithMany("Works")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}