﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.Data;

namespace SchoolManagement.Data.Migrations
{
    [DbContext(typeof(SchoolManagementContext))]
    partial class SchoolManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("SchoolManagement.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hours = 36,
                            Name = "Learn C#",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Hours = 24,
                            Name = "Learn WPF",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 3,
                            Hours = 44,
                            Name = "Learn ASP.NET Core",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 4,
                            Hours = 16,
                            Name = "Learn EF Core",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 5,
                            Hours = 52,
                            Name = "Learn Azure",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 6,
                            Hours = 10,
                            Name = "Learn Azure DevOps",
                            TeacherId = 2
                        });
                });

            modelBuilder.Entity("SchoolManagement.Data.CourseParticipation", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Notation")
                        .HasColumnType("INTEGER");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseParticipation");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1,
                            Notation = 13
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 2,
                            Notation = 15
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 3,
                            Notation = 8
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 4,
                            Notation = 19
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 1,
                            Notation = 11
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 2,
                            Notation = 8
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 3,
                            Notation = 5
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 4,
                            Notation = 15
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 1,
                            Notation = 17
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 2,
                            Notation = 17
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 3,
                            Notation = 16
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 4,
                            Notation = 12
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 1,
                            Notation = 11
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 2,
                            Notation = 18
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 3,
                            Notation = 12
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 4,
                            Notation = 20
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 1,
                            Notation = 11
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 2,
                            Notation = 10
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 3,
                            Notation = 11
                        });
                });

            modelBuilder.Entity("SchoolManagement.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Smith",
                            Name = "Paul"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "London",
                            Name = "Jack"
                        },
                        new
                        {
                            Id = 3,
                            LastName = "MacDonald",
                            Name = "John"
                        },
                        new
                        {
                            Id = 4,
                            LastName = "Sharp",
                            Name = "Will"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Data.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lastname = "Doe",
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            Lastname = "Smith",
                            Name = "John"
                        },
                        new
                        {
                            Id = 3,
                            Lastname = "Data",
                            Name = "Mark"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Data.Course", b =>
                {
                    b.HasOne("SchoolManagement.Data.Teacher", "TeachedBy")
                        .WithMany("TeachedCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolManagement.Data.CourseParticipation", b =>
                {
                    b.HasOne("SchoolManagement.Data.Course", "Course")
                        .WithMany("Participations")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagement.Data.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
