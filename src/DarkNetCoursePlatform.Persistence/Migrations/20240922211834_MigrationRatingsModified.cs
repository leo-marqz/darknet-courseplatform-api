using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DarkNetCoursePlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationRatingsModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "027431e8-3aea-44ad-9f30-83ca8f2c0e20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("1066680f-99c7-4988-a0ff-a17128d18a92"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("23daaa64-b76f-4c9d-b5e8-658c6e46ad6d"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("2c89ed45-f742-4fd7-9cc2-f9288b92b4ae"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("5a04f53e-77e9-4826-8f92-01e40bd83b1b"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("73780eba-9f24-499e-a66a-56f8696ddc9f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("90f4dc62-c9f3-4ad2-869c-3c6ab51d1b50"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("a1dbe855-d7df-41e6-a5bb-fb4990ffc2b3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("d7a194ef-fb86-445f-b94a-41249bb62c4f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("e6638bb1-dce0-4297-bbef-6e4fed4e58c3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("f603ac96-197e-42e7-80f7-8b1e990ff450"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("36160d71-5253-451d-bcf9-8e2a44ecd711"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("3d845bb4-77d1-45c3-9c0d-3742ec262c1d"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("4a8592d0-95a7-46c2-8760-59a999d14692"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("4e42fb1d-cfa2-42da-ace3-c35d187d8399"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("51fe6090-d53b-4643-888d-83b72b0d1820"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("58ec8fdb-3513-417e-bf27-273bca65d030"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("6715ee7a-1cdc-48a7-af16-1418e9e6907d"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("849d4670-e3df-42ed-929f-d484d8447032"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("8ef351bd-c6ef-402d-9fb4-31386bddfc3c"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("bdc3fbf8-3308-46f4-be97-853797da9809"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("5d45c1b0-9bc8-41cb-9d6d-1225bc78dd07"));

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ratings");

            migrationBuilder.AddColumn<string>(
                name: "Student",
                table: "ratings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "933566c6-8acc-4313-a448-97dd5588411f");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "ae8bcfb4-de80-424c-abab-e7ce023855ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "ae8bcfb4-de80-424c-abab-e7ce023855ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "ae8bcfb4-de80-424c-abab-e7ce023855ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "ae8bcfb4-de80-424c-abab-e7ce023855ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "933566c6-8acc-4313-a448-97dd5588411f", null, "ADMIN", "ADMIN" },
                    { "ae8bcfb4-de80-424c-abab-e7ce023855ed", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "Release", "Title" },
                values: new object[,]
                {
                    { new Guid("05be3055-6652-424b-87be-bf088d54d678"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7589), "Unbranded Frozen Shoes" },
                    { new Guid("0d635835-1909-4882-b407-3db2268fe0bc"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7485), "Fantastic Soft Bacon" },
                    { new Guid("3207c590-dae3-434c-83f5-b3b3d04f8680"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7397), "Small Fresh Computer" },
                    { new Guid("6e9cd534-0ca9-4172-ac6e-fee60a664b23"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7672), "Rustic Frozen Bacon" },
                    { new Guid("887b91cb-2eb0-403d-b812-495da5506b4c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7354), "Refined Steel Chips" },
                    { new Guid("ac61c30a-400c-4fa9-aecf-b037895514b6"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7197), "Refined Steel Keyboard" },
                    { new Guid("ae8f0452-a691-4f82-ae12-eb03fc7648f3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7259), "Small Metal Bike" },
                    { new Guid("cbaf3045-afe3-478f-b0b6-e0e5bb3308ce"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7548), "Unbranded Soft Bike" },
                    { new Guid("d5b3478d-f8cb-4604-820e-66391220ca6f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7439), "Tasty Cotton Towels" },
                    { new Guid("fb73629e-4abd-4057-a671-929b5ef6ed5e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 2, 21, 18, 33, 727, DateTimeKind.Utc).AddTicks(7629), "Rustic Granite Shoes" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademyDegree", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("0e971ae8-237e-4125-9c17-2799308017f6"), "Product Directives Designer", "Hilpert", "Marisa" },
                    { new Guid("140b6062-1a4e-45c2-aaac-a0e3ec34b9f5"), "Principal Security Representative", "Nikolaus", "Ebony" },
                    { new Guid("37279049-453d-4751-a655-2902af3943d5"), "Investor Web Developer", "Stehr", "Elmore" },
                    { new Guid("5587a8ba-6c6c-464e-bb1b-ecba9070102e"), "Future Creative Assistant", "Osinski", "Filiberto" },
                    { new Guid("64f235f1-257d-4979-978e-045f227c1007"), "National Operations Architect", "Hagenes", "Abel" },
                    { new Guid("65d155d4-fba5-4021-be70-6524409e1829"), "Lead Marketing Analyst", "Boyle", "Bert" },
                    { new Guid("860d8c39-ac38-43fa-8600-05be9a011bcd"), "National Assurance Administrator", "Berge", "Elmira" },
                    { new Guid("a87feff9-90aa-4d5b-9ea3-9f2cee353f48"), "Customer Research Assistant", "Orn", "Burnice" },
                    { new Guid("f808316b-0c41-4375-9a41-f2447949b15d"), "Chief Brand Supervisor", "Hauck", "Keeley" },
                    { new Guid("fe5869ba-495c-4d44-9624-2eff1a8dc42e"), "Regional Usability Developer", "Bradtke", "Jada" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "CurrentPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("addd3973-7ad5-43dd-8cb9-d44cc2b2bbaa"), 11.99m, "Precio Regular", 75.0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "933566c6-8acc-4313-a448-97dd5588411f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae8bcfb4-de80-424c-abab-e7ce023855ed");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("05be3055-6652-424b-87be-bf088d54d678"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("0d635835-1909-4882-b407-3db2268fe0bc"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("3207c590-dae3-434c-83f5-b3b3d04f8680"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("6e9cd534-0ca9-4172-ac6e-fee60a664b23"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("887b91cb-2eb0-403d-b812-495da5506b4c"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("ac61c30a-400c-4fa9-aecf-b037895514b6"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("ae8f0452-a691-4f82-ae12-eb03fc7648f3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("cbaf3045-afe3-478f-b0b6-e0e5bb3308ce"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("d5b3478d-f8cb-4604-820e-66391220ca6f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("fb73629e-4abd-4057-a671-929b5ef6ed5e"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("0e971ae8-237e-4125-9c17-2799308017f6"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("140b6062-1a4e-45c2-aaac-a0e3ec34b9f5"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("37279049-453d-4751-a655-2902af3943d5"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("5587a8ba-6c6c-464e-bb1b-ecba9070102e"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("64f235f1-257d-4979-978e-045f227c1007"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("65d155d4-fba5-4021-be70-6524409e1829"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("860d8c39-ac38-43fa-8600-05be9a011bcd"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("a87feff9-90aa-4d5b-9ea3-9f2cee353f48"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("f808316b-0c41-4375-9a41-f2447949b15d"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("fe5869ba-495c-4d44-9624-2eff1a8dc42e"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("addd3973-7ad5-43dd-8cb9-d44cc2b2bbaa"));

            migrationBuilder.DropColumn(
                name: "Student",
                table: "ratings");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "ratings",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "027431e8-3aea-44ad-9f30-83ca8f2c0e20");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "027431e8-3aea-44ad-9f30-83ca8f2c0e20", null, "ADMIN", "ADMIN" },
                    { "b02848d3-fcf0-4fdf-87bf-fd6cc77e7238", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "Release", "Title" },
                values: new object[,]
                {
                    { new Guid("1066680f-99c7-4988-a0ff-a17128d18a92"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3638), "Practical Rubber Chicken" },
                    { new Guid("23daaa64-b76f-4c9d-b5e8-658c6e46ad6d"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3722), "Intelligent Wooden Keyboard" },
                    { new Guid("2c89ed45-f742-4fd7-9cc2-f9288b92b4ae"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3740), "Sleek Steel Chips" },
                    { new Guid("5a04f53e-77e9-4826-8f92-01e40bd83b1b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3674), "Handmade Metal Computer" },
                    { new Guid("73780eba-9f24-499e-a66a-56f8696ddc9f"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3688), "Licensed Fresh Hat" },
                    { new Guid("90f4dc62-c9f3-4ad2-869c-3c6ab51d1b50"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3773), "Sleek Frozen Shoes" },
                    { new Guid("a1dbe855-d7df-41e6-a5bb-fb4990ffc2b3"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3755), "Small Granite Computer" },
                    { new Guid("d7a194ef-fb86-445f-b94a-41249bb62c4f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3705), "Fantastic Soft Bacon" },
                    { new Guid("e6638bb1-dce0-4297-bbef-6e4fed4e58c3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3550), "Incredible Frozen Keyboard" },
                    { new Guid("f603ac96-197e-42e7-80f7-8b1e990ff450"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 10, 2, 20, 13, 31, 511, DateTimeKind.Utc).AddTicks(3657), "Small Frozen Salad" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademyDegree", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("36160d71-5253-451d-bcf9-8e2a44ecd711"), "Legacy Functionality Agent", "Schulist", "Telly" },
                    { new Guid("3d845bb4-77d1-45c3-9c0d-3742ec262c1d"), "Central Tactics Associate", "Lakin", "Elouise" },
                    { new Guid("4a8592d0-95a7-46c2-8760-59a999d14692"), "Customer Research Agent", "Effertz", "Florine" },
                    { new Guid("4e42fb1d-cfa2-42da-ace3-c35d187d8399"), "Future Identity Orchestrator", "Brown", "Gabe" },
                    { new Guid("51fe6090-d53b-4643-888d-83b72b0d1820"), "Forward Markets Executive", "Ledner", "Chester" },
                    { new Guid("58ec8fdb-3513-417e-bf27-273bca65d030"), "District Markets Executive", "Nader", "Jamir" },
                    { new Guid("6715ee7a-1cdc-48a7-af16-1418e9e6907d"), "Direct Configuration Associate", "Hickle", "Kenton" },
                    { new Guid("849d4670-e3df-42ed-929f-d484d8447032"), "District Data Technician", "Hermann", "Isabelle" },
                    { new Guid("8ef351bd-c6ef-402d-9fb4-31386bddfc3c"), "Direct Brand Planner", "Heaney", "Cheyenne" },
                    { new Guid("bdc3fbf8-3308-46f4-be97-853797da9809"), "Product Operations Administrator", "Osinski", "Frances" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "CurrentPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("5d45c1b0-9bc8-41cb-9d6d-1225bc78dd07"), 11.99m, "Precio Regular", 75.0m });
        }
    }
}
