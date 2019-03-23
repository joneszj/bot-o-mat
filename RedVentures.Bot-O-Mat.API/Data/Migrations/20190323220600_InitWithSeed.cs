using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedVentures.Bot_O_Mat.API.Data.Migrations
{
    public partial class InitWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrandActor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ActorType = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrandActor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Errands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ActorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    TimeToComplete = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Errands_ErrandActor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "ErrandActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 1, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 627, DateTimeKind.Local).AddTicks(6848), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 629, DateTimeKind.Local).AddTicks(4652), "Albertha Schimmel", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 46, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(9098), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(9102), "Juston Hoeger", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 43, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(2672), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(2676), "Madie Runte", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 40, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7301), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7305), "Rodolfo Goodwin", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 38, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3727), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3731), "Mr. Jeffrey Hartmann", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 34, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6051), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6054), "Ms. Unique Cartwright", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 33, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4322), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4326), "Olin O'Connell", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 32, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(2612), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(2612), "Henry Emmerich", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 24, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7890), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7894), "Mrs. Ole Little", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 22, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4444), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4444), "Audreanne Hickle V", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 21, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2635), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2639), "Sabrina Mayer", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 20, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(757), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(757), "Brent Parisian", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 18, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(7034), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(7034), "Mariana Corkery", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 16, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1148), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1151), "Gage Willms", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 15, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9295), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9299), "Kory Hackett", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 14, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7472), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7476), "Polly Wilkinson", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 13, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(5652), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(5656), "Angelita Flatley III", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 10, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8910), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8913), "Alden Doyle", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 9, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6258), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6262), "Ola Mann", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 8, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(4603), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(4603), "Jerrell Gottlieb", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 7, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(3020), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(3020), "Jazlyn Hegmann", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 6, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(1073), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(1073), "Aisha Heaney", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 49, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4320), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4320), "Tara Hand", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 50, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6041), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6041), "Kody Pacocha", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 51, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7810), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7814), "Dr. Jamar Stokes", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 52, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(826), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(826), "Jaylen Klein", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 98, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6038), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6042), "Mortimer Howe", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 97, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4310), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4313), "Mathias Cremin", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 95, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(9219), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(9223), "Mrs. Eda Stokes", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 94, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6950), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6954), "Josie Rodriguez", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 93, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5229), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5232), "Winnifred Jacobi", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 91, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(1232), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(1236), "Lavonne Brakus III", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 90, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9584), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9584), "Finn Zboncak", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 85, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(985), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(989), "Dawn Schmitt DDS", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 84, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9271), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9271), "Deangelo Romaguera", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 78, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7737), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7740), "Mrs. Candelario Kozey", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 5, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9424), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9428), "Jeff Bernhard", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 76, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4290), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4294), "Malinda Gleichner", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 72, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7209), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7209), "Hope Flatley", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 71, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(5236), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(5240), "Cecilia Satterfield", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 70, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3340), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3343), "Columbus Bernier Jr.", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 69, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1425), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1429), "Eric Wolff", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 66, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4722), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4726), "Kaya Harvey", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 65, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2782), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2786), "Paxton Zemlak", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 62, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7067), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7067), "Mr. Hermina Stiedemann", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 60, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9034), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9037), "Esteban Corwin", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 59, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6452), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6452), "Demario Senger", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 57, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2433), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2437), "Skyla Schaefer", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 75, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2657), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2657), "Aryanna Daniel", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 99, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7822), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7825), "Rene Conn", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 3, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(654), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(658), "Maximus West DVM", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 100, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(86), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(90), "Giovanna Pfeffer", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 45, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6534), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6538), "Ms. Eda Schmidt", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 44, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4430), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4433), "Keyshawn Littel", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 42, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(933), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(936), "Dorris Collier V", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 41, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9237), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9237), "Miss Malika Metz", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 39, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5540), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5540), "Ryleigh Hane", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 37, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1886), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1889), "Garry Bosco", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 36, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(9833), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(9836), "Nikki McKenzie III", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 35, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7783), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7787), "Braulio Kling", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 31, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(880), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(880), "Alexane Tillman Sr.", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 30, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9191), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9191), "Blanche Senger", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 29, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7068), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7072), "Nakia Yundt", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 28, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5296), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5300), "Manuel Rosenbaum", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 27, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(3476), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(3480), "Reyes Simonis", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 26, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1792), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1795), "Whitney Dietrich", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 25, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(12), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(12), "Kristin Price", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 23, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6198), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6202), "Brycen Will", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 19, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8850), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8853), "Jackson Weissnat", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 17, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4233), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4240), "Garland Bayer III", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 12, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3767), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3771), "Shyann Roob", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 11, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1550), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1554), "Bernard Friesen", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 4, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(5059), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(5059), "Mr. Diego Heaney", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 47, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(881), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(885), "Madisen Schiller", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 48, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2664), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2668), "Mrs. Travon Torp", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 53, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(2792), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(2792), "Jose Reichel", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 54, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4498), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4502), "Lew Kub", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 96, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2063), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2067), "Ms. Ethan Morar", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 92, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2942), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2946), "Pat Hammes", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 89, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7618), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7622), "Amaya Schaden", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 88, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(5941), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(5944), "Celestino Bosco", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 87, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(4362), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(4365), "Buster Emard", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 86, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2735), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2735), "Price Skiles", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 83, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6974), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6974), "Brennon Boyle Jr.", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 82, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5223), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5227), "Eveline King", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 81, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3604), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3608), "Manuela Douglas", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 80, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1937), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1937), "Omari Little", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 2, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(7590), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(7598), "Murray Mitchell", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 79, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(172), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(176), "Dr. Emmy Swift", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 74, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(961), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(965), "Guy Adams Sr.", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 73, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9236), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9240), "Mr. Manley Barrows", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 68, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8522), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8526), "Delores Tromp", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 67, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6593), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6597), "Brandi Goldner", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 64, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(733), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(733), "Tre Koss", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 63, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8895), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8899), "Ari Kub", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 61, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4507), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4507), "Stacy Lakin", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 58, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4585), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4588), "Dr. Kacie Wintheiser", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 56, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8407), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8411), "Judge Kuhn", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 55, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6252), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6256), "Eli D'Amore", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 77, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(6008), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(6012), "Kaci Bailey V", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 101, 0, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1818), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1822), "Adelbert Crist", "Unipedal" });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 1, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(5191), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(5220), "In_Progress", 14979, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 120, 40, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9219), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9222), "Completed", 14334, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 119, 40, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9208), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9208), "Not_Started", 12127, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 118, 40, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9193), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9197), "Failed", 15831, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 117, 40, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9178), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9182), "Failed", 22933, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 116, 40, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9160), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(9168), "In_Progress", 19887, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 113, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5522), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5525), "Completed", 18742, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 112, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5511), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5511), "Failed", 16780, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 111, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5496), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5496), "In_Progress", 24665, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 123, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4309), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4313), "Completed", 13734, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 110, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5481), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5485), "Not_Started", 10838, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 108, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5449), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5452), "Failed", 10355, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, 34, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7768), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7772), "In_Progress", 9148, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, 34, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7750), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(7754), "Completed", 10523, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 93, 33, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6036), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6040), "Failed", 24740, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 92, 33, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6018), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(6022), "In_Progress", 2266, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 91, 32, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4304), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4308), "In_Progress", 4890, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 90, 32, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4286), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(4289), "Not_Started", 20728, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 66, 24, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9990), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9994), "Failed", 20504, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 109, 38, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5467), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(5470), "In_Progress", 13920, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, 24, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9921), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9924), "Failed", 20484, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 124, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4324), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4328), "Not_Started", 23090, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 126, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4386), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4390), "Failed", 16508, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 173, 57, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4545), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4545), "Completed", 2806, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 172, 57, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4406), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4410), "Completed", 18683, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 171, 57, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4381), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4388), "Completed", 9868, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 159, 52, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(2737), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(2741), "In_Progress", 6144, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 158, 51, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(622), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(629), "Not_Started", 13940, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 157, 50, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7795), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7799), "Not_Started", 2992, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 156, 50, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7785), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7785), "Not_Started", 22825, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 155, 50, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7770), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7770), "Not_Started", 3317, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 125, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4371), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4375), "Not_Started", 1178, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 154, 50, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7752), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(7755), "Not_Started", 3704, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 152, 49, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6012), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6012), "Failed", 18757, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 151, 49, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(5998), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6001), "Not_Started", 17942, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 150, 49, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(5979), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(5983), "Completed", 3937, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 141, 46, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(863), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(863), "Completed", 20600, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 140, 46, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(819), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(823), "Failed", 3136, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 139, 46, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(801), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(805), "Failed", 13534, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 128, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4415), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4415), "In_Progress", 17629, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 127, 43, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4401), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(4404), "Not_Started", 9013, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 153, 49, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6027), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(6027), "Failed", 6836, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 174, 57, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4563), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(4567), "Failed", 5140, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, 24, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9903), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(9906), "Failed", 9674, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 60, 22, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6165), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6169), "Not_Started", 24914, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 35, 14, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9281), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9281), "Completed", 18861, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, 14, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9266), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9266), "In_Progress", 6067, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, 14, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9244), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(9248), "Failed", 20174, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, 13, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7458), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7458), "Failed", 7803, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 31, 13, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7439), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(7443), "Not_Started", 4418, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, 10, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1524), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1524), "In_Progress", 21494, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, 10, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1510), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1510), "Not_Started", 23813, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, 10, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1495), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1495), "Not_Started", 7714, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 36, 15, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1100), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1104), "Completed", 15234, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, 10, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1477), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1481), "Completed", 13019, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, 9, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8880), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8888), "Completed", 15029, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, 9, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8829), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(8837), "Not_Started", 15470, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, 8, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6244), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6247), "Completed", 15280, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, 8, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6229), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6233), "In_Progress", 19559, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, 8, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6215), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(6218), "Not_Started", 7122, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 13, 7, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(4585), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(4588), "Failed", 16288, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 12, 6, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(3002), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(3006), "Not_Started", 22318, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 11, 6, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(2987), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(2991), "In_Progress", 3730, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, 10, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1389), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(1397), "Not_Started", 4840, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, 22, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6180), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6183), "Not_Started", 19937, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, 15, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1119), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1122), "Failed", 4645, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 39, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(3952), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(3963), "Not_Started", 1381, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, 22, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6151), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(6154), "Completed", 3990, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, 21, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4426), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4429), "Failed", 6962, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, 21, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4415), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4415), "Completed", 6192, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 56, 21, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4400), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4400), "Failed", 10894, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 55, 21, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4386), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4389), "In_Progress", 15832, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, 21, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4367), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(4371), "In_Progress", 5599, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, 20, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2620), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2620), "Not_Started", 7673, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 52, 20, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2606), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2606), "Not_Started", 6821, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 38, 15, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1133), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(1137), "Not_Started", 12884, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 51, 20, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2584), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(2591), "Failed", 20616, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 48, 18, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8780), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8784), "Completed", 14703, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, 18, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8766), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8770), "In_Progress", 13090, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, 18, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8748), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8751), "Not_Started", 24252, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4178), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4186), "Completed", 7735, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 43, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4138), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4142), "In_Progress", 14669, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 42, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4094), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4102), "Not_Started", 4059, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 41, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4051), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4058), "Failed", 9998, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, 16, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4010), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(4014), "Failed", 15099, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, 18, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8795), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(8799), "Not_Started", 18345, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, 5, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(1051), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 643, DateTimeKind.Local).AddTicks(1055), "In_Progress", 4174, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 177, 59, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(8786), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(8789), "Not_Started", 18781, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 179, 59, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9004), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9004), "Failed", 4286, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 316, 93, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6921), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6925), "Not_Started", 20588, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 315, 93, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6906), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6910), "Failed", 11672, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 314, 93, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6888), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6892), "Not_Started", 13376, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 307, 91, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2928), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2931), "In_Progress", 16577, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 306, 91, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2913), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2917), "Completed", 16505, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 305, 91, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2899), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(2902), "In_Progress", 12913, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 304, 90, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(1214), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(1217), "In_Progress", 22472, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 293, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2717), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2721), "Not_Started", 3200, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 317, 93, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6935), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(6935), "Not_Started", 22101, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 292, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2702), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2706), "Completed", 16884, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 290, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2677), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2677), "In_Progress", 22444, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 289, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2662), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2666), "In_Progress", 1953, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 288, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2644), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2648), "Failed", 1776, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 287, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(970), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(970), "Not_Started", 2639, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 286, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(956), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(959), "In_Progress", 3370, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 285, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(941), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(945), "Completed", 16748, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 284, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(930), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(930), "In_Progress", 18678, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 283, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(916), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(919), "In_Progress", 18039, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 291, 85, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2692), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(2692), "Not_Started", 3996, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 282, 84, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(897), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(901), "Not_Started", 23966, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 318, 94, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(9142), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(9146), "Completed", 13554, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 320, 95, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(1991), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(1994), "Completed", 22835, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 349, 101, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3459), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3463), "Failed", 17288, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 342, 99, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(72), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(72), "In_Progress", 22574, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 341, 99, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(53), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(57), "Not_Started", 16335, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 340, 99, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(10), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(13), "In_Progress", 16038, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 339, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7807), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7811), "In_Progress", 1063, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 338, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7792), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7796), "In_Progress", 17827, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 337, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7778), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7782), "Completed", 18085, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 336, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7763), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7767), "In_Progress", 11124, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 319, 95, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(1965), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(1976), "Failed", 2881, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 335, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7752), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7752), "Failed", 7905, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 333, 97, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6024), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6027), "Failed", 11523, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 332, 97, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6009), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(6013), "Failed", 1308, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 331, 97, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5995), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5998), "Failed", 9033, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 330, 97, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5980), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5984), "Failed", 15385, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 329, 97, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5965), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(5969), "In_Progress", 5663, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 323, 95, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2038), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2038), "Not_Started", 19302, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 322, 95, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2023), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2023), "In_Progress", 8599, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 321, 95, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2009), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(2009), "Failed", 2655, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 334, 98, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7734), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(7738), "In_Progress", 9423, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 178, 59, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(8986), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(8990), "Failed", 19296, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 262, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(158), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(162), "Not_Started", 1639, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 260, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(129), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(132), "In_Progress", 1240, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 212, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6542), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6546), "Not_Started", 13979, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 211, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6527), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6531), "Completed", 2971, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 210, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6513), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6517), "Completed", 11932, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 209, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6498), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6502), "Completed", 14074, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 208, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6484), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6487), "Not_Started", 18216, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 207, 66, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6465), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(6469), "Not_Started", 22143, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 206, 65, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4704), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4708), "Not_Started", 1800, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 205, 65, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4631), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(4638), "Completed", 7570, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 222, 69, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3285), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3289), "Not_Started", 17278, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 195, 62, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8877), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8877), "Failed", 11416, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 193, 62, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8840), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8844), "Not_Started", 23329, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 186, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4332), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4332), "Completed", 22731, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 185, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4318), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4318), "Failed", 12412, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 184, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4303), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4303), "Failed", 13786, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 183, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4289), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4289), "Completed", 14844, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 182, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4274), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4274), "Completed", 22884, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 181, 60, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4252), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(4259), "Completed", 12675, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 180, 59, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9019), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(9019), "In_Progress", 7436, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 194, 62, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8858), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(8862), "Not_Started", 7206, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 261, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(143), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(147), "Not_Started", 10448, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 223, 69, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3307), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3307), "In_Progress", 9651, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 225, 70, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(5214), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(5222), "Not_Started", 4948, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 259, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(118), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(118), "Not_Started", 7285, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 258, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(103), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(103), "Not_Started", 7564, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 257, 78, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(45), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(48), "Not_Started", 4219, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 251, 76, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5990), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5994), "In_Progress", 14223, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 250, 76, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5975), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5979), "Failed", 17871, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 249, 76, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5964), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5964), "In_Progress", 24554, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 248, 76, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5946), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(5950), "In_Progress", 15321, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 247, 75, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4276), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4276), "Completed", 18857, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 224, 69, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3322), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(3322), "Completed", 17375, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 246, 75, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4261), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4265), "In_Progress", 1677, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 244, 75, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4236), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4236), "In_Progress", 24639, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 243, 75, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4218), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4221), "Failed", 5960, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 231, 72, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9214), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9218), "Completed", 1642, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 230, 72, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9196), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(9200), "Failed", 6074, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 229, 71, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7191), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7191), "Not_Started", 5686, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 228, 71, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7176), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7176), "Not_Started", 14751, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 227, 71, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7162), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7162), "Not_Started", 3321, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 226, 71, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7143), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(7147), "In_Progress", 7746, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 245, 75, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4247), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(4250), "Completed", 17099, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 350, 101, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3478), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3481), "Failed", 5881, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, 3, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(5027), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(5030), "In_Progress", 4414, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 4, 2, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(625), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(629), "In_Progress", 1180, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 136, 45, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8846), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8850), "Completed", 16864, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 135, 45, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8671), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8679), "Not_Started", 20571, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 134, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6519), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6523), "Completed", 11735, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 133, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6505), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6508), "In_Progress", 19067, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 132, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6494), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6494), "Failed", 19344, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 131, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6479), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6483), "Not_Started", 6525, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 130, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6465), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6468), "Completed", 5892, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 129, 44, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6395), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(6399), "Completed", 23930, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 137, 45, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8879), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(8883), "In_Progress", 2658, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 122, 42, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(2654), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(2657), "Failed", 7989, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 115, 39, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7287), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7287), "Completed", 19488, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 114, 39, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7268), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(7272), "Not_Started", 12169, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 107, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3654), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3658), "Not_Started", 20371, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 106, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3643), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3643), "In_Progress", 10827, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 105, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3629), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3633), "Failed", 2862, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 104, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3614), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3618), "In_Progress", 9110, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 103, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3603), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3603), "Failed", 18553, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 102, 37, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3585), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(3589), "Not_Started", 23038, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 121, 41, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(914), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(918), "Completed", 10974, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 101, 36, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1868), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1871), "In_Progress", 6550, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 138, 45, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(9072), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 650, DateTimeKind.Local).AddTicks(9076), "Failed", 14064, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 143, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2599), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2603), "Not_Started", 24315, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 175, 58, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6415), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6419), "Failed", 24686, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 170, 56, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2411), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2415), "Not_Started", 13194, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 169, 56, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2400), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2400), "Not_Started", 19736, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 168, 56, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2386), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2386), "In_Progress", 1350, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 167, 56, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2368), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2371), "Completed", 1296, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 166, 56, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2269), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(2302), "Not_Started", 16523, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 165, 55, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8382), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8385), "In_Progress", 13875, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 164, 55, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8356), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(8360), "Failed", 1772, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 142, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2584), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2588), "Failed", 13282, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 163, 54, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6238), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6241), "Completed", 6420, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 161, 53, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4484), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4484), "Not_Started", 23141, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 160, 53, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4466), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(4469), "Completed", 19342, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 149, 48, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4306), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4306), "Completed", 21957, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 148, 48, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4287), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(4291), "Not_Started", 12589, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 147, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2650), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2654), "Not_Started", 15146, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 146, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2639), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2639), "Failed", 22099, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 145, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2624), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2628), "Not_Started", 10830, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 144, 47, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2613), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 651, DateTimeKind.Local).AddTicks(2613), "Not_Started", 23794, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 162, 54, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6220), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 652, DateTimeKind.Local).AddTicks(6223), "Completed", 15566, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 176, 58, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6434), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 653, DateTimeKind.Local).AddTicks(6437), "Not_Started", 9907, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, 36, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1827), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1827), "Not_Started", 3870, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 98, 36, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1798), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1802), "Not_Started", 14421, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 69, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1708), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1708), "Not_Started", 17962, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1693), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1697), "Failed", 24063, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1675), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1679), "Completed", 23091, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, 23, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7875), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7879), "Not_Started", 5852, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 62, 23, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7857), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(7861), "In_Progress", 6931, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, 19, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(728), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 646, DateTimeKind.Local).AddTicks(735), "Failed", 9381, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, 17, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(7004), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 645, DateTimeKind.Local).AddTicks(7012), "Failed", 7620, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 30, 12, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(5631), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(5634), "In_Progress", 22632, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 70, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1719), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1722), "Completed", 1207, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3753), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3756), "Completed", 8059, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3694), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3698), "Failed", 23209, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3680), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3683), "Failed", 17703, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3669), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3669), "Failed", 19095, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3647), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3654), "Failed", 21917, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, 4, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9406), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9406), "Not_Started", 20397, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, 4, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9392), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9395), "Not_Started", 8303, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, 4, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9366), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(9373), "Not_Started", 17695, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 2, 1, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(7087), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 641, DateTimeKind.Local).AddTicks(7095), "Failed", 10610, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, 11, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3738), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 644, DateTimeKind.Local).AddTicks(3742), "Not_Started", 24310, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 99, 36, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1813), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1816), "Failed", 1793, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1733), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1737), "Failed", 3497, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 73, 26, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(3458), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(3462), "In_Progress", 6801, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 97, 36, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1784), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 649, DateTimeKind.Local).AddTicks(1787), "In_Progress", 24871, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, 35, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(9814), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(9818), "Completed", 14591, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, 31, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(2594), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(2597), "In_Progress", 8659, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 88, 30, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(861), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(865), "Completed", 11314, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, 30, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(847), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(851), "Not_Started", 8037, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 86, 30, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(832), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 648, DateTimeKind.Local).AddTicks(836), "In_Progress", 20418, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, 29, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9173), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9177), "Not_Started", 7921, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 84, 29, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9162), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9162), "Not_Started", 3290, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, 25, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1777), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(1781), "Completed", 3943, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, 29, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9148), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9151), "Completed", 17895, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, 29, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9118), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9122), "In_Progress", 15830, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, 28, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7054), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7054), "Failed", 5406, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, 28, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7036), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(7039), "In_Progress", 22072, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, 27, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5282), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5285), "Not_Started", 22607, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 77, 27, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5271), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5271), "In_Progress", 20539, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, 27, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5256), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5260), "Failed", 16403, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 75, 27, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5245), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5245), "Completed", 23720, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 74, 27, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5227), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(5230), "Not_Started", 11964, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, 29, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9133), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 647, DateTimeKind.Local).AddTicks(9137), "Failed", 13696, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, 3, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(4997), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(5005), "Not_Started", 3399, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 187, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(6969), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(6976), "Completed", 3106, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 189, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7009), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7009), "Not_Started", 17816, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 299, 88, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7589), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7593), "Completed", 10885, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 298, 88, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7578), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7578), "Failed", 2599, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 297, 88, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7564), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7567), "Completed", 7837, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 296, 88, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7549), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7553), "In_Progress", 8372, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 295, 87, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(5923), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(5926), "In_Progress", 11885, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 294, 86, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(4344), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(4347), "In_Progress", 9308, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 281, 83, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9253), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9256), "Not_Started", 21571, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 280, 83, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9234), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(9242), "In_Progress", 10134, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 300, 88, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7604), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(7607), "Failed", 20270, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 279, 82, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6959), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6959), "Not_Started", 2242, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 277, 82, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6934), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6934), "In_Progress", 5759, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 276, 82, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6919), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6923), "Failed", 19500, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 275, 82, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6901), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6904), "Failed", 24549, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 274, 81, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5209), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5212), "In_Progress", 2682, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 273, 81, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5194), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(5198), "Failed", 16726, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 272, 80, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3589), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3593), "In_Progress", 7530, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 271, 80, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3546), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3549), "Completed", 5006, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 270, 80, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3535), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3535), "Completed", 20406, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 278, 82, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6944), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(6948), "Failed", 20186, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 269, 80, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3520), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3524), "In_Progress", 8582, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 301, 89, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9540), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9544), "Completed", 17955, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 303, 89, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9569), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9569), "Failed", 11887, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, 2, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(596), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 642, DateTimeKind.Local).AddTicks(603), "Not_Started", 7241, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 348, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1804), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1808), "In_Progress", 18956, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 347, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1793), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1793), "Failed", 19291, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 346, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1778), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1782), "Not_Started", 10286, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 345, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1767), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1767), "Completed", 5013, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 344, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1753), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1753), "Completed", 10111, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 343, 100, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1735), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(1738), "Failed", 3137, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 328, 96, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4292), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4295), "Completed", 22067, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 302, 89, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9555), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 659, DateTimeKind.Local).AddTicks(9558), "In_Progress", 19078, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 327, 96, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4281), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4281), "Failed", 7785, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 325, 96, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4251), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4255), "In_Progress", 12677, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 324, 96, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4233), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4237), "Failed", 24968, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 313, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5214), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5218), "Completed", 9831, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 312, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5200), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5203), "Completed", 22681, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 311, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5189), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5189), "Failed", 13912, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 310, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5174), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5178), "Not_Started", 5001, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 309, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5160), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5163), "In_Progress", 2984, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 308, 92, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5145), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 660, DateTimeKind.Local).AddTicks(5149), "Not_Started", 8253, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 326, 96, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4266), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 661, DateTimeKind.Local).AddTicks(4270), "Failed", 11183, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 188, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(6994), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(6994), "In_Progress", 17646, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 268, 80, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3502), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(3506), "Failed", 9878, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 266, 79, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1908), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1912), "In_Progress", 12534, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 218, 68, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1360), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1363), "In_Progress", 8738, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 217, 68, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1330), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1341), "Failed", 6220, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 216, 67, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8504), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8508), "Failed", 6513, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 215, 67, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8490), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8493), "Not_Started", 12146, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 214, 67, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8479), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8479), "Not_Started", 20079, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 213, 67, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8457), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(8464), "Failed", 13019, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 204, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2764), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2768), "In_Progress", 10656, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 203, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2749), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2753), "Not_Started", 3698, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 219, 68, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1374), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1378), "Completed", 10386, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 202, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2735), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2739), "Completed", 14437, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 200, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2706), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2709), "Failed", 17324, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 199, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2582), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2585), "In_Progress", 8818, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 198, 63, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(715), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(718), "Not_Started", 1474, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 197, 63, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(700), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(704), "In_Progress", 17083, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 196, 63, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(682), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(689), "Failed", 16019, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 192, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7049), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7053), "Completed", 14930, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 191, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7035), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7038), "Not_Started", 21781, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 190, 61, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7024), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 654, DateTimeKind.Local).AddTicks(7024), "Completed", 5056, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 201, 64, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2724), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 655, DateTimeKind.Local).AddTicks(2724), "In_Progress", 10230, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 267, 79, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1923), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1923), "Not_Started", 16662, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 220, 68, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1389), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1392), "In_Progress", 15428, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 232, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(844), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(848), "Failed", 10738, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 265, 79, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1897), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1897), "Failed", 13305, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 264, 79, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1875), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1879), "Failed", 24719, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 263, 79, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1755), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 658, DateTimeKind.Local).AddTicks(1759), "Not_Started", 13456, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 256, 77, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7722), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7726), "Not_Started", 10522, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 255, 77, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7711), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7711), "Failed", 10309, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 254, 77, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7697), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7700), "Completed", 23247, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 253, 77, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7686), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7686), "Completed", 17784, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 252, 77, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7667), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(7671), "Failed", 24316, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 221, 68, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1403), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 656, DateTimeKind.Local).AddTicks(1407), "Not_Started", 6871, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 242, 74, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2639), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2642), "Failed", 24579, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 240, 74, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2584), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2584), "Completed", 3118, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 239, 74, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2569), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2573), "Failed", 10903, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 238, 74, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2555), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2558), "In_Progress", 23866, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 237, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(946), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(950), "Failed", 7097, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 236, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(932), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(936), "Not_Started", 19087, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 235, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(888), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(892), "Not_Started", 5556, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 234, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(877), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(877), "In_Progress", 19893, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 233, 73, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(863), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(866), "Completed", 20878, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 241, 74, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2595), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 657, DateTimeKind.Local).AddTicks(2598), "Not_Started", 17559, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 351, 101, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3492), true, "Anonymous", new DateTime(2019, 3, 23, 18, 6, 0, 662, DateTimeKind.Local).AddTicks(3492), "Failed", 3565, 1000 });

            migrationBuilder.CreateIndex(
                name: "IX_Errands_ActorId",
                table: "Errands",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Errands");

            migrationBuilder.DropTable(
                name: "ErrandActor");
        }
    }
}
