﻿// <auto-generated />
using System;
using DarkNetCoursePlatform.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DarkNetCoursePlatform.Persistence.Migrations
{
    [DbContext(typeof(DarkNetCoursePlatformDbContext))]
    partial class DarkNetCoursePlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4");

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Release")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1154571-4781-416b-b7bc-25a1adb5e1d9"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5871),
                            Title = "Practical Cotton Bacon"
                        },
                        new
                        {
                            Id = new Guid("9c2b9bfb-5008-4abd-91f1-391664bf8ced"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5939),
                            Title = "Generic Concrete Salad"
                        },
                        new
                        {
                            Id = new Guid("49e84375-d2f3-48ec-a3e5-0abc00fa457f"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5984),
                            Title = "Ergonomic Concrete Chair"
                        },
                        new
                        {
                            Id = new Guid("5786b22e-deca-41b7-b4a4-66203ad91771"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6043),
                            Title = "Gorgeous Soft Hat"
                        },
                        new
                        {
                            Id = new Guid("b308ef62-b5ed-44dc-b08a-af28155debd1"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6084),
                            Title = "Sleek Cotton Chair"
                        },
                        new
                        {
                            Id = new Guid("e1fdcd35-3a4b-4491-9325-1e7311ea57f4"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6156),
                            Title = "Handmade Wooden Ball"
                        },
                        new
                        {
                            Id = new Guid("a9243e59-9fd0-4049-a1cc-7b23aa3276f1"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6197),
                            Title = "Fantastic Fresh Chair"
                        },
                        new
                        {
                            Id = new Guid("acd24a87-05a8-46ab-9367-ccf086617ab0"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6238),
                            Title = "Intelligent Soft Ball"
                        },
                        new
                        {
                            Id = new Guid("5ae872d1-1d6a-4a9a-a0b5-0fc027143c84"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6279),
                            Title = "Tasty Frozen Sausages"
                        },
                        new
                        {
                            Id = new Guid("dc90494f-1806-4022-a3b5-2e8853541868"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Release = new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6320),
                            Title = "Handmade Rubber Shirt"
                        });
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.CourseInstructor", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("course_instructors", (string)null);
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.CoursePrice", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PriceId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "PriceId");

                    b.HasIndex("PriceId");

                    b.ToTable("course_prices", (string)null);
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AcademyDegree")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("27a24b2f-0d94-48fa-934a-0bccfdb694cb"),
                            AcademyDegree = "Central Implementation Engineer",
                            LastName = "Klocko",
                            Name = "Rollin"
                        },
                        new
                        {
                            Id = new Guid("d04abd95-ed32-47e6-978d-37a7af87ae0b"),
                            AcademyDegree = "Dynamic Data Assistant",
                            LastName = "Mann",
                            Name = "Elenora"
                        },
                        new
                        {
                            Id = new Guid("109b6893-a081-4457-b81d-f1dc0b50b1b3"),
                            AcademyDegree = "National Solutions Orchestrator",
                            LastName = "Stiedemann",
                            Name = "Liana"
                        },
                        new
                        {
                            Id = new Guid("f45ea9e8-1a27-4a6f-a708-ae54599da45b"),
                            AcademyDegree = "Chief Usability Strategist",
                            LastName = "McDermott",
                            Name = "Katarina"
                        },
                        new
                        {
                            Id = new Guid("1d6529b7-1f41-433e-92e4-8dafaec5495d"),
                            AcademyDegree = "Regional Branding Agent",
                            LastName = "Terry",
                            Name = "Marcellus"
                        },
                        new
                        {
                            Id = new Guid("a23c804d-ac66-469a-9279-dc478d2517ea"),
                            AcademyDegree = "Chief Markets Associate",
                            LastName = "Ledner",
                            Name = "Zoie"
                        },
                        new
                        {
                            Id = new Guid("7aaaa492-05fd-46d4-a7da-b28a8688e1e7"),
                            AcademyDegree = "Forward Web Officer",
                            LastName = "O'Keefe",
                            Name = "Henry"
                        },
                        new
                        {
                            Id = new Guid("7660647d-298c-4365-9749-08a8ebc1c47f"),
                            AcademyDegree = "Forward Functionality Supervisor",
                            LastName = "Casper",
                            Name = "Dion"
                        },
                        new
                        {
                            Id = new Guid("ec902854-928f-4d66-95f9-c1550142d813"),
                            AcademyDegree = "Global Branding Director",
                            LastName = "Johns",
                            Name = "Shane"
                        },
                        new
                        {
                            Id = new Guid("ac129ea5-f1d2-4a91-8e82-057199d3f762"),
                            AcademyDegree = "Future Solutions Administrator",
                            LastName = "Torphy",
                            Name = "Jayme"
                        });
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("pictures", (string)null);
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CurrentPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PromotionalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("prices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b2b6b546-9bd0-4da1-9e5a-8042bc66da1b"),
                            CurrentPrice = 11.99m,
                            Name = "Precio Regular",
                            PromotionalPrice = 75.0m
                        });
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("ratings", (string)null);
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.CourseInstructor", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Course", "Course")
                        .WithMany("CourseInstructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Instructor", "Instructor")
                        .WithMany("CourseInstructors")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.CoursePrice", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Course", "Course")
                        .WithMany("CoursePrices")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Price", "Price")
                        .WithMany("CoursePrices")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Picture", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Course", "Course")
                        .WithMany("Pictures")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Rating", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Domain.Models.Course", "Course")
                        .WithMany("Ratings")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Course", b =>
                {
                    b.Navigation("CourseInstructors");

                    b.Navigation("CoursePrices");

                    b.Navigation("Pictures");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Instructor", b =>
                {
                    b.Navigation("CourseInstructors");
                });

            modelBuilder.Entity("DarkNetCoursePlatform.Domain.Models.Price", b =>
                {
                    b.Navigation("CoursePrices");
                });
#pragma warning restore 612, 618
        }
    }
}
