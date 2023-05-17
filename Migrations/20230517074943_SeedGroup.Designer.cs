﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zaj10.Entities;

#nullable disable

namespace Zaj10.Migrations
{
    [DbContext(typeof(UniversityDbContext))]
    [Migration("20230517074943_SeedGroup")]
    partial class SeedGroup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Zaj10.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id")
                        .HasName("Group_pk");

                    b.ToTable("Group", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "18c"
                        });
                });

            modelBuilder.Entity("Zaj10.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("indexNumber")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("Student_pk");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("Zaj10.Entities.StudentGroup", b =>
                {
                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("IdStudent", "IdGroup")
                        .HasName("StudentGroup_pk");

                    b.HasIndex("GroupId");

                    b.ToTable("Student_Group", (string)null);
                });

            modelBuilder.Entity("Zaj10.Entities.StudentGroup", b =>
                {
                    b.HasOne("Zaj10.Entities.Group", "Group")
                        .WithMany("StudentGroups")
                        .HasForeignKey("GroupId");

                    b.HasOne("Zaj10.Entities.Student", "Student")
                        .WithMany("StudentGroups")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("StudentGroup_Student");

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Zaj10.Entities.Group", b =>
                {
                    b.Navigation("StudentGroups");
                });

            modelBuilder.Entity("Zaj10.Entities.Student", b =>
                {
                    b.Navigation("StudentGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
