﻿// <auto-generated />
using System;
using BIBLIOTECA.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BIBLIOTECA.Infrastructure.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20210603161402_CreateBooksTable")]
    partial class CreateBooksTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BIBLIOTECA.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("authors");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("caption");

                    b.Property<int>("Pages")
                        .HasColumnType("integer")
                        .HasColumnName("pages");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<double>("Version")
                        .HasColumnType("double precision")
                        .HasColumnName("version");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
