using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DarkNetCoursePlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Release = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    AcademyDegree = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PromotionalPrice = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pictures_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ratings_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "course_instructors",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_instructors", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_course_instructors_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_instructors_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_prices",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_prices", x => new { x.CourseId, x.PriceId });
                    table.ForeignKey(
                        name: "FK_course_prices_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_prices_prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "Release", "Title" },
                values: new object[,]
                {
                    { new Guid("49e84375-d2f3-48ec-a3e5-0abc00fa457f"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5984), "Ergonomic Concrete Chair" },
                    { new Guid("5786b22e-deca-41b7-b4a4-66203ad91771"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6043), "Gorgeous Soft Hat" },
                    { new Guid("5ae872d1-1d6a-4a9a-a0b5-0fc027143c84"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6279), "Tasty Frozen Sausages" },
                    { new Guid("9c2b9bfb-5008-4abd-91f1-391664bf8ced"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5939), "Generic Concrete Salad" },
                    { new Guid("a1154571-4781-416b-b7bc-25a1adb5e1d9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(5871), "Practical Cotton Bacon" },
                    { new Guid("a9243e59-9fd0-4049-a1cc-7b23aa3276f1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6197), "Fantastic Fresh Chair" },
                    { new Guid("acd24a87-05a8-46ab-9367-ccf086617ab0"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6238), "Intelligent Soft Ball" },
                    { new Guid("b308ef62-b5ed-44dc-b08a-af28155debd1"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6084), "Sleek Cotton Chair" },
                    { new Guid("dc90494f-1806-4022-a3b5-2e8853541868"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6320), "Handmade Rubber Shirt" },
                    { new Guid("e1fdcd35-3a4b-4491-9325-1e7311ea57f4"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 9, 25, 20, 35, 14, 826, DateTimeKind.Utc).AddTicks(6156), "Handmade Wooden Ball" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademyDegree", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("109b6893-a081-4457-b81d-f1dc0b50b1b3"), "National Solutions Orchestrator", "Stiedemann", "Liana" },
                    { new Guid("1d6529b7-1f41-433e-92e4-8dafaec5495d"), "Regional Branding Agent", "Terry", "Marcellus" },
                    { new Guid("27a24b2f-0d94-48fa-934a-0bccfdb694cb"), "Central Implementation Engineer", "Klocko", "Rollin" },
                    { new Guid("7660647d-298c-4365-9749-08a8ebc1c47f"), "Forward Functionality Supervisor", "Casper", "Dion" },
                    { new Guid("7aaaa492-05fd-46d4-a7da-b28a8688e1e7"), "Forward Web Officer", "O'Keefe", "Henry" },
                    { new Guid("a23c804d-ac66-469a-9279-dc478d2517ea"), "Chief Markets Associate", "Ledner", "Zoie" },
                    { new Guid("ac129ea5-f1d2-4a91-8e82-057199d3f762"), "Future Solutions Administrator", "Torphy", "Jayme" },
                    { new Guid("d04abd95-ed32-47e6-978d-37a7af87ae0b"), "Dynamic Data Assistant", "Mann", "Elenora" },
                    { new Guid("ec902854-928f-4d66-95f9-c1550142d813"), "Global Branding Director", "Johns", "Shane" },
                    { new Guid("f45ea9e8-1a27-4a6f-a708-ae54599da45b"), "Chief Usability Strategist", "McDermott", "Katarina" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "CurrentPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("b2b6b546-9bd0-4da1-9e5a-8042bc66da1b"), 11.99m, "Precio Regular", 75.0m });

            migrationBuilder.CreateIndex(
                name: "IX_course_instructors_InstructorId",
                table: "course_instructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_course_prices_PriceId",
                table: "course_prices",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_pictures_CourseId",
                table: "pictures",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_CourseId",
                table: "ratings",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_instructors");

            migrationBuilder.DropTable(
                name: "course_prices");

            migrationBuilder.DropTable(
                name: "pictures");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
