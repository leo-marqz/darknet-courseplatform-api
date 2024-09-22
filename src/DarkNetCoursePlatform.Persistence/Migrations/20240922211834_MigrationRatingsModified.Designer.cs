﻿// <auto-generated />
using System;
using DarkNetCoursePlatform.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DarkNetCoursePlatform.Persistence.Migrations
{
    [DbContext(typeof(DarkNetCoursePlatformDbContext))]
    [Migration("20240922211834_MigrationRatingsModified")]
    partial class MigrationRatingsModified
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("ac61c30a-400c-4fa9-aecf-b037895514b6"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7197),
                            Title = "Refined Steel Keyboard"
                        },
                        new
                        {
                            Id = new Guid("ae8f0452-a691-4f82-ae12-eb03fc7648f3"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7259),
                            Title = "Small Metal Bike"
                        },
                        new
                        {
                            Id = new Guid("887b91cb-2eb0-403d-b812-495da5506b4c"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7354),
                            Title = "Refined Steel Chips"
                        },
                        new
                        {
                            Id = new Guid("3207c590-dae3-434c-83f5-b3b3d04f8680"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7397),
                            Title = "Small Fresh Computer"
                        },
                        new
                        {
                            Id = new Guid("d5b3478d-f8cb-4604-820e-66391220ca6f"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7439),
                            Title = "Tasty Cotton Towels"
                        },
                        new
                        {
                            Id = new Guid("0d635835-1909-4882-b407-3db2268fe0bc"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7485),
                            Title = "Fantastic Soft Bacon"
                        },
                        new
                        {
                            Id = new Guid("cbaf3045-afe3-478f-b0b6-e0e5bb3308ce"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7548),
                            Title = "Unbranded Soft Bike"
                        },
                        new
                        {
                            Id = new Guid("05be3055-6652-424b-87be-bf088d54d678"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7589),
                            Title = "Unbranded Frozen Shoes"
                        },
                        new
                        {
                            Id = new Guid("fb73629e-4abd-4057-a671-929b5ef6ed5e"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7629),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = new Guid("6e9cd534-0ca9-4172-ac6e-fee60a664b23"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Release = new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7672),
                            Title = "Rustic Frozen Bacon"
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
                            Id = new Guid("fe5869ba-495c-4d44-9624-2eff1a8dc42e"),
                            AcademyDegree = "Regional Usability Developer",
                            LastName = "Bradtke",
                            Name = "Jada"
                        },
                        new
                        {
                            Id = new Guid("f808316b-0c41-4375-9a41-f2447949b15d"),
                            AcademyDegree = "Chief Brand Supervisor",
                            LastName = "Hauck",
                            Name = "Keeley"
                        },
                        new
                        {
                            Id = new Guid("860d8c39-ac38-43fa-8600-05be9a011bcd"),
                            AcademyDegree = "National Assurance Administrator",
                            LastName = "Berge",
                            Name = "Elmira"
                        },
                        new
                        {
                            Id = new Guid("a87feff9-90aa-4d5b-9ea3-9f2cee353f48"),
                            AcademyDegree = "Customer Research Assistant",
                            LastName = "Orn",
                            Name = "Burnice"
                        },
                        new
                        {
                            Id = new Guid("140b6062-1a4e-45c2-aaac-a0e3ec34b9f5"),
                            AcademyDegree = "Principal Security Representative",
                            LastName = "Nikolaus",
                            Name = "Ebony"
                        },
                        new
                        {
                            Id = new Guid("0e971ae8-237e-4125-9c17-2799308017f6"),
                            AcademyDegree = "Product Directives Designer",
                            LastName = "Hilpert",
                            Name = "Marisa"
                        },
                        new
                        {
                            Id = new Guid("5587a8ba-6c6c-464e-bb1b-ecba9070102e"),
                            AcademyDegree = "Future Creative Assistant",
                            LastName = "Osinski",
                            Name = "Filiberto"
                        },
                        new
                        {
                            Id = new Guid("65d155d4-fba5-4021-be70-6524409e1829"),
                            AcademyDegree = "Lead Marketing Analyst",
                            LastName = "Boyle",
                            Name = "Bert"
                        },
                        new
                        {
                            Id = new Guid("37279049-453d-4751-a655-2902af3943d5"),
                            AcademyDegree = "Investor Web Developer",
                            LastName = "Stehr",
                            Name = "Elmore"
                        },
                        new
                        {
                            Id = new Guid("64f235f1-257d-4979-978e-045f227c1007"),
                            AcademyDegree = "National Operations Architect",
                            LastName = "Hagenes",
                            Name = "Abel"
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
                            Id = new Guid("addd3973-7ad5-43dd-8cb9-d44cc2b2bbaa"),
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

                    b.Property<string>("Student")
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
                            Id = "933566c6-8acc-4313-a448-97dd5588411f",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ae8bcfb4-de80-424c-abab-e7ce023855ed",
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
                            RoleId = "933566c6-8acc-4313-a448-97dd5588411f"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_READ",
                            RoleId = "ae8bcfb4-de80-424c-abab-e7ce023855ed"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "RATING_READ",
                            RoleId = "ae8bcfb4-de80-424c-abab-e7ce023855ed"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "ae8bcfb4-de80-424c-abab-e7ce023855ed"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "RATING_CREATE",
                            RoleId = "ae8bcfb4-de80-424c-abab-e7ce023855ed"
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
