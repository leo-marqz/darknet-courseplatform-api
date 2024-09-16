using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DarkNetCoursePlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SecurityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("49e84375-d2f3-48ec-a3e5-0abc00fa457f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("5786b22e-deca-41b7-b4a4-66203ad91771"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("5ae872d1-1d6a-4a9a-a0b5-0fc027143c84"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("9c2b9bfb-5008-4abd-91f1-391664bf8ced"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("a1154571-4781-416b-b7bc-25a1adb5e1d9"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("a9243e59-9fd0-4049-a1cc-7b23aa3276f1"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("acd24a87-05a8-46ab-9367-ccf086617ab0"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("b308ef62-b5ed-44dc-b08a-af28155debd1"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("dc90494f-1806-4022-a3b5-2e8853541868"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("e1fdcd35-3a4b-4491-9325-1e7311ea57f4"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("109b6893-a081-4457-b81d-f1dc0b50b1b3"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("1d6529b7-1f41-433e-92e4-8dafaec5495d"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("27a24b2f-0d94-48fa-934a-0bccfdb694cb"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("7660647d-298c-4365-9749-08a8ebc1c47f"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("7aaaa492-05fd-46d4-a7da-b28a8688e1e7"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("a23c804d-ac66-469a-9279-dc478d2517ea"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("ac129ea5-f1d2-4a91-8e82-057199d3f762"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("d04abd95-ed32-47e6-978d-37a7af87ae0b"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("ec902854-928f-4d66-95f9-c1550142d813"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("f45ea9e8-1a27-4a6f-a708-ae54599da45b"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("b2b6b546-9bd0-4da1-9e5a-8042bc66da1b"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    AcademyDegree = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6c4a427-9666-4ba8-87f5-589cd7976be6", null, "CLIENT", "CLIENT" },
                    { "c2cfd1ac-303c-4c63-8c72-65ec6ab53309", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "Release", "Title" },
                values: new object[,]
                {
                    { new Guid("3ac79e7d-c98e-4554-a329-07e29653bc16"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(4011), "Licensed Soft Pizza" },
                    { new Guid("3d673e03-9c2e-4071-901f-3ab0a3f755fe"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(3893), "Generic Granite Gloves" },
                    { new Guid("3fa352aa-4ea4-44e8-9b87-4c82fa682ab1"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(3922), "Practical Frozen Shirt" },
                    { new Guid("4bc923ef-ddc2-4480-b142-b3f168e37e30"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(3946), "Gorgeous Concrete Computer" },
                    { new Guid("67ac3027-3f15-421f-b4f5-83e66b059430"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(4082), "Handcrafted Soft Tuna" },
                    { new Guid("909c227c-f10c-4b11-a5d1-e3430c0e20c2"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(3984), "Tasty Granite Chair" },
                    { new Guid("ae9d2638-510e-4165-b5b5-29003cd100b0"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(4034), "Small Fresh Keyboard" },
                    { new Guid("b36ca498-6f9e-4c45-b199-0b4861d644f3"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(3832), "Licensed Granite Fish" },
                    { new Guid("f608362b-170f-43ec-b70d-531e711c77ec"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(4058), "Fantastic Frozen Shoes" },
                    { new Guid("f903a914-5f6b-4834-a91c-af99a4f6f688"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 9, 26, 2, 59, 30, 717, DateTimeKind.Utc).AddTicks(4110), "Gorgeous Rubber Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademyDegree", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("00db67f0-d931-4f61-b360-344b7b1f4b5f"), "Lead Data Manager", "Deckow", "Emerald" },
                    { new Guid("07db1c01-61a9-4612-a4e8-cca889e20a54"), "Principal Accounts Strategist", "McCullough", "Clementine" },
                    { new Guid("33a40870-ba60-489e-b035-df16ec328fee"), "Investor Data Director", "Boehm", "Guiseppe" },
                    { new Guid("42908052-472c-4dd1-84a7-e5ee5f42772e"), "Central Applications Supervisor", "Bechtelar", "Carmel" },
                    { new Guid("548a9a5b-ac6a-472a-a916-3c88e3630fa2"), "Lead Data Executive", "Emard", "Electa" },
                    { new Guid("7a032443-16d1-4b03-9490-384369de6eeb"), "Legacy Brand Representative", "Vandervort", "Ivory" },
                    { new Guid("b36dcc9e-6e1d-49ef-a389-dc7fe6787af4"), "Forward Division Consultant", "Pacocha", "Jay" },
                    { new Guid("b5ca31db-1ce9-423b-a0a1-60a94d0659a2"), "Customer Marketing Facilitator", "Kuhn", "Jaron" },
                    { new Guid("d54ceb0e-b4a4-4426-88ba-3ee267f9fa1d"), "Corporate Intranet Executive", "Pagac", "Lemuel" },
                    { new Guid("de8c5dcb-48b1-4039-853d-4ed972601054"), "Central Research Producer", "Schuster", "Emma" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "CurrentPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("0e30c3e1-b6ee-4d58-8d91-0cfa12208821"), 11.99m, "Precio Regular", 75.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "SUPER_ADMIN", "c2cfd1ac-303c-4c63-8c72-65ec6ab53309" },
                    { 2, "POLICIES", "COURSE_READ", "b6c4a427-9666-4ba8-87f5-589cd7976be6" },
                    { 3, "POLICIES", "RATING_READ", "b6c4a427-9666-4ba8-87f5-589cd7976be6" },
                    { 4, "POLICIES", "INSTRUCTOR_READ", "b6c4a427-9666-4ba8-87f5-589cd7976be6" },
                    { 5, "POLICIES", "RATING_CREATE", "b6c4a427-9666-4ba8-87f5-589cd7976be6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("3ac79e7d-c98e-4554-a329-07e29653bc16"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("3d673e03-9c2e-4071-901f-3ab0a3f755fe"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("3fa352aa-4ea4-44e8-9b87-4c82fa682ab1"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("4bc923ef-ddc2-4480-b142-b3f168e37e30"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("67ac3027-3f15-421f-b4f5-83e66b059430"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("909c227c-f10c-4b11-a5d1-e3430c0e20c2"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("ae9d2638-510e-4165-b5b5-29003cd100b0"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("b36ca498-6f9e-4c45-b199-0b4861d644f3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("f608362b-170f-43ec-b70d-531e711c77ec"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("f903a914-5f6b-4834-a91c-af99a4f6f688"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("00db67f0-d931-4f61-b360-344b7b1f4b5f"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("07db1c01-61a9-4612-a4e8-cca889e20a54"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("33a40870-ba60-489e-b035-df16ec328fee"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("42908052-472c-4dd1-84a7-e5ee5f42772e"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("548a9a5b-ac6a-472a-a916-3c88e3630fa2"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("7a032443-16d1-4b03-9490-384369de6eeb"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("b36dcc9e-6e1d-49ef-a389-dc7fe6787af4"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("b5ca31db-1ce9-423b-a0a1-60a94d0659a2"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("d54ceb0e-b4a4-4426-88ba-3ee267f9fa1d"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("de8c5dcb-48b1-4039-853d-4ed972601054"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("0e30c3e1-b6ee-4d58-8d91-0cfa12208821"));

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
        }
    }
}
