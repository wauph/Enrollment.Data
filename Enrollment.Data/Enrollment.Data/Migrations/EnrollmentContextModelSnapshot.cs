﻿// <auto-generated />
using Enrollment.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enrollment.Data.Migrations
{
    [DbContext(typeof(EnrollmentContext))]
    partial class EnrollmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Enrollment.Data.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Subject", b =>
                {
                    b.Property<string>("SubjectID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.HasIndex("StudentID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Teacher", b =>
                {
                    b.Property<string>("TeacherID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Subject", b =>
                {
                    b.HasOne("Enrollment.Data.Models.Student", null)
                        .WithMany("Subjects")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Teacher", b =>
                {
                    b.HasOne("Enrollment.Data.Models.Subject", null)
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectID");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Student", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Enrollment.Data.Models.Subject", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
