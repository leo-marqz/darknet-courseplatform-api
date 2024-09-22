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
                            Id = new Guid("e6638bb1-dce0-4297-bbef-6e4fed4e58c3"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3550),
                            Title = "Incredible Frozen Keyboard"
                        },
                        new
                        {
                            Id = new Guid("1066680f-99c7-4988-a0ff-a17128d18a92"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3638),
                            Title = "Practical Rubber Chicken"
                        },
                        new
                        {
                            Id = new Guid("f603ac96-197e-42e7-80f7-8b1e990ff450"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3657),
                            Title = "Small Frozen Salad"
                        },
                        new
                        {
                            Id = new Guid("5a04f53e-77e9-4826-8f92-01e40bd83b1b"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3674),
                            Title = "Handmade Metal Computer"
                        },
                        new
                        {
                            Id = new Guid("73780eba-9f24-499e-a66a-56f8696ddc9f"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3688),
                            Title = "Licensed Fresh Hat"
                        },
                        new
                        {
                            Id = new Guid("d7a194ef-fb86-445f-b94a-41249bb62c4f"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3705),
                            Title = "Fantastic Soft Bacon"
                        },
                        new
                        {
                            Id = new Guid("23daaa64-b76f-4c9d-b5e8-658c6e46ad6d"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3722),
                            Title = "Intelligent Wooden Keyboard"
                        },
                        new
                        {
                            Id = new Guid("2c89ed45-f742-4fd7-9cc2-f9288b92b4ae"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3740),
                            Title = "Sleek Steel Chips"
                        },
                        new
                        {
                            Id = new Guid("a1dbe855-d7df-41e6-a5bb-fb4990ffc2b3"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3755),
                            Title = "Small Granite Computer"
                        },
                        new
                        {
                            Id = new Guid("90f4dc62-c9f3-4ad2-869c-3c6ab51d1b50"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Release = new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3773),
                            Title = "Sleek Frozen Shoes"
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
                            Id = new Guid("36160d71-5253-451d-bcf9-8e2a44ecd711"),
                            AcademyDegree = "Legacy Functionality Agent",
                            LastName = "Schulist",
                            Name = "Telly"
                        },
                        new
                        {
                            Id = new Guid("4a8592d0-95a7-46c2-8760-59a999d14692"),
                            AcademyDegree = "Customer Research Agent",
                            LastName = "Effertz",
                            Name = "Florine"
                        },
                        new
                        {
                            Id = new Guid("4e42fb1d-cfa2-42da-ace3-c35d187d8399"),
                            AcademyDegree = "Future Identity Orchestrator",
                            LastName = "Brown",
                            Name = "Gabe"
                        },
                        new
                        {
                            Id = new Guid("51fe6090-d53b-4643-888d-83b72b0d1820"),
                            AcademyDegree = "Forward Markets Executive",
                            LastName = "Ledner",
                            Name = "Chester"
                        },
                        new
                        {
                            Id = new Guid("8ef351bd-c6ef-402d-9fb4-31386bddfc3c"),
                            AcademyDegree = "Direct Brand Planner",
                            LastName = "Heaney",
                            Name = "Cheyenne"
                        },
                        new
                        {
                            Id = new Guid("6715ee7a-1cdc-48a7-af16-1418e9e6907d"),
                            AcademyDegree = "Direct Configuration Associate",
                            LastName = "Hickle",
                            Name = "Kenton"
                        },
                        new
                        {
                            Id = new Guid("849d4670-e3df-42ed-929f-d484d8447032"),
                            AcademyDegree = "District Data Technician",
                            LastName = "Hermann",
                            Name = "Isabelle"
                        },
                        new
                        {
                            Id = new Guid("58ec8fdb-3513-417e-bf27-273bca65d030"),
                            AcademyDegree = "District Markets Executive",
                            LastName = "Nader",
                            Name = "Jamir"
                        },
                        new
                        {
                            Id = new Guid("3d845bb4-77d1-45c3-9c0d-3742ec262c1d"),
                            AcademyDegree = "Central Tactics Associate",
                            LastName = "Lakin",
                            Name = "Elouise"
                        },
                        new
                        {
                            Id = new Guid("bdc3fbf8-3308-46f4-be97-853797da9809"),
                            AcademyDegree = "Product Operations Administrator",
                            LastName = "Osinski",
                            Name = "Frances"
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
                            Id = new Guid("5d45c1b0-9bc8-41cb-9d6d-1225bc78dd07"),
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

            modelBuilder.Entity("DarkNetCoursePlatform.Persistence.SystemModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AcademyDegree")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "027431e8-3aea-44ad-9f30-83ca8f2c0e20",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238",
                            Name = "CLIENT",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "SUPER_ADMIN",
                            RoleId = "027431e8-3aea-44ad-9f30-83ca8f2c0e20"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_READ",
                            RoleId = "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "RATING_READ",
                            RoleId = "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "RATING_CREATE",
                            RoleId = "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Persistence.SystemModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Persistence.SystemModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarkNetCoursePlatform.Persistence.SystemModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DarkNetCoursePlatform.Persistence.SystemModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
