using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedVentures.Bot_O_Mat.API.Migrations
{
    public partial class InitWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrandActors",
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
                    KilledById = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrandActors", x => x.Id);
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
                        name: "FK_Errands_ErrandActors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "ErrandActors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 1, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 63, DateTimeKind.Local).AddTicks(5824), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 65, DateTimeKind.Local).AddTicks(4072), "Rylee Hickle", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 43, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(440), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(443), "Teagan Lesch", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 42, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8667), false, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8671), "Lisa Runte", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 41, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6417), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6417), "Rose Reichert", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 40, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(4470), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(4474), "Peggie West", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 33, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1433), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1433), "Hallie Leannon", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 32, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7663), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7663), "Ciara Barrows", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 30, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3570), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3570), "Brendon Wolf", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 29, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(262), false, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(266), "Avery Langworth", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 26, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2922), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2926), "Felicita Boyer", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 25, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1099), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1102), "Ms. Rolando Brakus", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 24, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9436), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9440), "Raina White", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 23, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(7664), false, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(7664), "Randy Macejkovic", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 21, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3659), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3663), "Octavia Parker", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 17, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(1107), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(1111), "Dessie Beatty", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 15, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7679), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7683), "Santino Kuhn IV", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 14, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5364), false, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5368), "Paris Kirlin", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 13, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2461), false, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2465), "Mable Moore", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 11, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(9044), false, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(9048), "Martina Hauck", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 6, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6769), false, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6777), "Clementina Kovacek", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 100, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1738), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1742), "Florine Fay", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 99, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9959), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9959), "Dr. Verlie Crooks", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 47, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7901), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7905), "Wilma Fadel", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 49, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1497), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1500), "Leslie Flatley V", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 54, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(380), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(384), "Levi Roberts", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 55, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2200), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2203), "Pasquale Dicki", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 95, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2314), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2318), "Joanny Veum", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 92, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6512), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6512), "Brannon Schroeder", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 90, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(2968), false, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(2971), "Martine Mills", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 89, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1276), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1279), "Ophelia Franecki", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 88, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9536), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9536), "Wilfredo Jerde", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 87, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(7844), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(7848), "Jennie O'Kon", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 86, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6108), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6112), "Lizeth Ritchie", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 85, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4340), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4340), "Demarco Labadie", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 84, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(2600), false, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(2600), "Brody Anderson DDS", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 79, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3994), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3997), "Carley Ebert", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 98, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8168), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8168), "Antonietta Bartoletti", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 77, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(566), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(566), "Hallie Kub", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 74, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4297), false, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4297), "Miss Rahsaan Ullrich", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 72, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9388), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9388), "Torey Blanda", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 71, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7620), false, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7620), "Annetta Frami", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 70, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5254), false, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5257), "Jaquan Stroman", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 69, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2770), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2774), "Magdalena Wiza", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 68, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(929), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(932), "Adolf Ziemann", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 67, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(9222), false, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(9226), "Shaun White", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 65, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3960), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3963), "Dr. Cole Jacobson", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 63, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(481), false, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(481), "Nicolette Bins", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 56, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4049), false, 5, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4049), "Alvera Graham", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 75, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6671), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6675), "Howell Crooks Sr.", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 97, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6290), false, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6290), "Rylan Brekke", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 96, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4043), false, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4046), "Susanna Prohaska III", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 93, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8171), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8175), "Peter Bergstrom", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 37, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9124), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9128), "Ephraim Kautzer", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 36, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(7345), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(7348), "Juvenal Nitzsche", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 35, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(5616), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(5616), "Barrett Raynor", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 34, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3873), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3873), "Mae Kirlin", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 31, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5372), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5375), "Mr. Hester Rippin", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 28, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6692), false, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6692), "Alphonso Nikolaus", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 27, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4654), false, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4658), "Bradly McKenzie", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 22, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5552), false, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5552), "Sarah Pagac", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 20, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1460), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1460), "Cynthia Herzog", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 19, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9389), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9393), "Jessyca Padberg", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 18, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4914), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4918), "Stephon Hilpert", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 16, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(9415), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(9419), "Dr. Jenifer Erdman", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 12, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(762), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(762), "Sherwood Monahan", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 10, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7319), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7323), "Ramon Tromp", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 9, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2732), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2732), "Dr. Christopher Larkin", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 8, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(974), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(978), "Zakary Witting", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 7, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9198), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9202), "Dillan Spencer", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 5, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1959), false, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1959), "Cordia Pagac I", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 4, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(259), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(263), "Marcella Wyman", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 3, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8447), false, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8451), "Mya Wolf", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 2, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4972), false, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4975), "Kayli Lesch", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 38, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(926), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(926), "Darryl Casper", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 39, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2822), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2822), "Luciano Senger II", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 44, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2216), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2216), "Marlin Cruickshank", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 45, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(4010), false, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(4010), "Torey D'Amore", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 91, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4652), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4656), "Sandy Bode MD", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 83, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(912), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(915), "Erica VonRueden", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 82, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9176), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9179), "Mrs. Ernest Weber", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 81, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7440), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7444), "Mr. Monte Schamberger", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 80, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5715), false, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5715), "Axel Miller", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 78, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2251), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2254), "Josefina Prohaska", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 76, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8815), false, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8819), "Mr. Moshe Wehner", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 73, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1511), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1511), "Gudrun Dare", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 66, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6090), false, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6090), "Dorian Kuphal", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 64, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(2235), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(2235), "Jessica Schmeler", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 94, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9893), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9893), "Jennyfer Gutkowski", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 62, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(8380), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(8384), "Kennith Stroman", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 60, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(4004), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(4004), "Frida Harber III", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 59, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1608), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1612), "Mrs. Horacio Crist", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 58, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(9074), false, 5, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(9077), "Darrel Dietrich", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 57, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5909), false, 5, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5912), "Shaniya Schroeder", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 53, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8549), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8549), "Arianna Reinger", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 52, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(6857), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(6857), "Deondre Bosco", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 51, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5059), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5063), "Dannie Moen", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 50, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3276), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3280), "Eula Simonis DDS", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 48, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9666), false, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9666), "Mac O'Kon V", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 46, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5800), false, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5800), "Kaley Stanton", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 61, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(5743), false, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(5747), "Howard Ratke", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActors",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 101, 0, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3904), true, null, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3908), "Tomas Considine", "Arachnid" });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 1, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(2941), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(2970), "Completed", 11281, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 133, 40, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6341), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6348), "Failed", 17637, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 132, 40, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6286), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6293), "In_Progress", 16573, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 116, 33, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3855), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3858), "Not_Started", 17729, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 115, 33, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3844), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3844), "Not_Started", 1481, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 114, 33, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3829), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3833), "Not_Started", 15942, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 113, 33, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3815), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3818), "Not_Started", 11315, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 112, 33, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3796), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(3804), "Failed", 18146, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 111, 32, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1415), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1419), "Not_Started", 2207, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 110, 32, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1400), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1404), "Not_Started", 17474, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 109, 32, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1390), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1390), "In_Progress", 13917, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 108, 32, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1375), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1379), "In_Progress", 2609, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 107, 32, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1225), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(1357), "Not_Started", 17580, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 104, 30, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5353), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5357), "Not_Started", 10583, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 103, 30, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5335), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(5342), "Not_Started", 16329, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 102, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3548), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3552), "Failed", 19013, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 101, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3508), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3515), "Completed", 5104, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3446), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3453), "Completed", 8806, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 134, 40, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6396), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(6399), "Completed", 10604, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 99, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3413), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3421), "Completed", 6763, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 135, 41, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8609), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8613), "In_Progress", 15010, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 137, 41, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8638), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8642), "Completed", 15551, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 166, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3222), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3225), "Failed", 18018, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 165, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3207), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3211), "In_Progress", 2436, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 164, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3192), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3196), "Completed", 13109, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 160, 47, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9648), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9651), "Not_Started", 13107, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 159, 47, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9637), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9637), "Not_Started", 8748, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 158, 47, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9622), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9626), "Not_Started", 4421, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 157, 47, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9611), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9611), "Failed", 20754, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 156, 47, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9593), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(9597), "Completed", 24378, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 146, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2197), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2201), "In_Progress", 9267, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 145, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2183), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2187), "Not_Started", 16925, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 144, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2172), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2176), "Not_Started", 14040, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 143, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2157), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2161), "Failed", 4501, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 142, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2146), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2146), "Not_Started", 20798, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 141, 43, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2125), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(2132), "In_Progress", 17552, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 140, 42, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(425), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(425), "In_Progress", 6807, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 139, 42, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(407), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(411), "Not_Started", 10078, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 138, 41, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8653), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8656), "Completed", 22948, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 136, 41, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8627), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(8631), "Failed", 4417, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 167, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3236), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3236), "Completed", 16012, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 98, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3388), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3391), "Failed", 6321, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 86, 26, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4640), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4640), "Completed", 17313, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 52, 14, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7661), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7665), "In_Progress", 12336, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 51, 14, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7650), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7650), "Completed", 11652, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, 14, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7624), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(7632), "In_Progress", 1998, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, 13, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5346), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5346), "Completed", 10215, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 48, 13, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5331), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5335), "Failed", 2175, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, 13, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5316), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5320), "Not_Started", 15290, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, 13, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5298), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(5302), "Not_Started", 18462, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, 11, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(736), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(743), "Not_Started", 9170, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9180), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9183), "In_Progress", 17099, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9169), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9169), "Not_Started", 2226, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9154), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9158), "Failed", 22426, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9140), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9143), "Completed", 11706, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, 6, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9111), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(9118), "Failed", 19007, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 332, 100, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3882), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3886), "Not_Started", 17569, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 331, 100, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3839), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(3846), "Not_Started", 13743, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 330, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1724), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1727), "Failed", 11603, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 329, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1680), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1683), "Not_Started", 23301, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, 15, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(9393), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(9397), "Not_Started", 23637, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 97, 29, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3348), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(3355), "Completed", 23748, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 55, 17, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4382), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4393), "Completed", 20472, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, 17, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4856), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4859), "Not_Started", 3522, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, 26, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4622), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(4625), "Failed", 9948, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 84, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2908), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2911), "Failed", 17996, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2893), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2897), "Not_Started", 24698, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2882), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2886), "In_Progress", 15184, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2867), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2871), "Completed", 9734, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2857), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2857), "In_Progress", 24711, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, 25, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2838), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(2842), "Not_Started", 14775, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, 24, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1084), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1088), "Completed", 5076, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 77, 24, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1066), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(1073), "Not_Started", 9508, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, 23, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9370), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9374), "Not_Started", 2564, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 75, 23, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9356), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9359), "In_Progress", 17330, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 74, 23, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9341), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(9345), "Not_Started", 14614, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, 21, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5534), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5537), "Failed", 14413, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, 21, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5523), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5523), "Completed", 21055, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 70, 21, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5508), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5512), "In_Progress", 10096, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 69, 21, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5490), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(5494), "Not_Started", 17003, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, 17, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4878), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4878), "In_Progress", 4283, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 56, 17, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4823), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(4827), "Failed", 16034, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 328, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1665), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1669), "Completed", 15876, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 168, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3247), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3251), "Not_Started", 16263, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 184, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2116), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2120), "Completed", 8503, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 283, 85, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6094), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6097), "Completed", 10264, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 282, 85, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6083), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6083), "In_Progress", 2516, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 281, 85, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6068), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6072), "In_Progress", 5987, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 280, 85, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6053), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6057), "Failed", 18274, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 279, 85, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6035), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(6042), "Completed", 10351, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 278, 84, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4325), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4325), "In_Progress", 8895, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 277, 84, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4310), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4314), "Completed", 3509, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 276, 84, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4296), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4299), "Failed", 8968, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 275, 84, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4281), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(4285), "Completed", 14803, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 261, 79, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5697), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5700), "Completed", 6544, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 260, 79, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5653), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5657), "In_Progress", 15191, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 259, 79, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5635), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(5642), "In_Progress", 10077, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 256, 77, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2236), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2240), "Failed", 15237, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 255, 77, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2221), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2225), "Completed", 8326, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 254, 77, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2203), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(2210), "In_Progress", 20167, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 250, 75, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8797), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8801), "In_Progress", 4797, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 249, 75, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8786), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8786), "Not_Started", 4596, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 284, 86, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(7793), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(7800), "In_Progress", 18889, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 248, 75, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8772), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8775), "Failed", 16642, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 285, 87, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9489), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9492), "Failed", 8238, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 287, 87, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9521), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9521), "Not_Started", 24459, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 333, 101, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5913), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5920), "Not_Started", 4765, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 320, 97, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8150), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8153), "Completed", 11597, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 319, 97, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8132), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(8135), "Failed", 3868, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 312, 95, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4028), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4028), "Completed", 8246, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 311, 95, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4013), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(4017), "Completed", 1698, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 310, 95, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(3995), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(3999), "Not_Started", 20758, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 300, 92, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8153), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8157), "Not_Started", 4771, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 299, 92, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8139), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(8142), "Completed", 7095, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 296, 90, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4638), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4638), "Completed", 17848, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 295, 90, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4623), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4627), "Completed", 2654, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 294, 90, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4605), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(4612), "Not_Started", 22060, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 293, 89, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(2949), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(2953), "Not_Started", 5979, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 292, 88, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1261), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1265), "In_Progress", 5860, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 291, 88, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1246), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1250), "Not_Started", 5104, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 290, 88, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1235), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1235), "Failed", 7382, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 289, 88, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1221), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1224), "In_Progress", 18882, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 288, 88, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1206), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(1210), "Not_Started", 23141, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 286, 87, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9507), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(9511), "In_Progress", 11033, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 169, 49, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3262), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(3262), "Failed", 10022, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 247, 75, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8753), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(8761), "Failed", 10508, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 245, 74, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6638), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6642), "In_Progress", 3020, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 216, 65, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6064), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6068), "Not_Started", 13184, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 215, 65, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6031), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(6039), "Failed", 18674, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 210, 63, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(2213), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(2217), "In_Progress", 17041, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 198, 56, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5894), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5894), "Failed", 18493, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 197, 56, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5879), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5883), "Not_Started", 5932, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 196, 56, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5868), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5868), "Failed", 4780, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 195, 56, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5854), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5857), "Failed", 22249, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 194, 56, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5836), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(5843), "Failed", 17853, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 193, 55, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4030), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4034), "Completed", 23197, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 192, 55, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4016), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4020), "In_Progress", 15830, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 191, 55, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4005), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(4005), "Not_Started", 9693, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 190, 55, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(3987), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(3990), "Completed", 24786, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 189, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2185), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2189), "Not_Started", 24955, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 188, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2174), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2174), "In_Progress", 2097, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 187, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2160), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2163), "Completed", 8820, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 186, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2149), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2149), "Not_Started", 24972, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 185, 54, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2134), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(2138), "Failed", 2203, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 218, 67, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(892), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(896), "Completed", 9194, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 246, 74, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6656), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(6660), "In_Progress", 16181, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 219, 67, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(911), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(914), "In_Progress", 3574, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 221, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2701), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2705), "Failed", 1705, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 238, 72, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1493), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1493), "Not_Started", 11567, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 237, 72, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1478), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1482), "Completed", 16745, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 236, 72, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1467), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1467), "Not_Started", 8343, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 235, 72, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1449), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(1452), "In_Progress", 6098, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 234, 71, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9374), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9374), "Completed", 2524, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 233, 71, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9356), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(9359), "Failed", 10385, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 232, 70, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7602), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7605), "In_Progress", 1037, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 231, 70, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7591), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7591), "Not_Started", 23256, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 230, 70, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7565), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(7572), "Completed", 14087, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 229, 69, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5239), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5243), "Failed", 23137, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 228, 69, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5225), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5228), "Completed", 20123, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 227, 69, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5181), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5185), "Failed", 17638, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 226, 69, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5163), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(5166), "Failed", 11062, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 225, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2756), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2756), "Completed", 6290, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 224, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2741), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2745), "Completed", 23931, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 223, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2727), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2730), "Completed", 15220, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 222, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2716), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2716), "Not_Started", 10184, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 220, 68, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2683), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 92, DateTimeKind.Local).AddTicks(2686), "Failed", 24366, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 334, 101, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5957), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5960), "Not_Started", 2554, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 327, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1654), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1654), "Not_Started", 21014, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 325, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1621), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1629), "In_Progress", 9929, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(186), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(193), "Completed", 13875, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(157), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(160), "In_Progress", 14359, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 93, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(124), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(131), "In_Progress", 23139, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 92, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(95), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(98), "Not_Started", 23655, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 91, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(36), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(55), "Completed", 18892, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 90, 27, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6674), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6678), "Not_Started", 23250, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, 27, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6663), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6663), "Completed", 6372, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 88, 27, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6649), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6649), "Completed", 6453, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, 27, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6630), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 83, DateTimeKind.Local).AddTicks(6634), "Failed", 13582, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 73, 22, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(7634), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(7642), "Completed", 12528, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, 20, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3451), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3455), "Not_Started", 5168, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, 20, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3433), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(3440), "In_Progress", 9027, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 66, 19, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1442), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1446), "In_Progress", 15102, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, 19, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1424), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1424), "Failed", 12420, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, 19, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1409), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1413), "Completed", 13124, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, 19, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1391), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 82, DateTimeKind.Local).AddTicks(1398), "In_Progress", 10285, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 62, 18, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9374), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9374), "Failed", 18060, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, 28, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(215), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(219), "In_Progress", 11002, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, 18, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9360), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9363), "Completed", 12171, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 105, 31, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7626), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7630), "Completed", 7849, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 117, 34, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(5594), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(5598), "Completed", 3950, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 149, 44, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3992), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3995), "In_Progress", 12861, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 148, 44, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3948), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3948), "Failed", 19236, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 147, 44, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3930), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(3933), "Not_Started", 5402, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 131, 39, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(4452), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(4456), "Failed", 7386, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 130, 38, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2775), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2778), "Failed", 12260, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 129, 38, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2753), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2756), "Completed", 3863, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 128, 38, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2738), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2742), "In_Progress", 18096, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 127, 38, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2727), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2727), "Completed", 14517, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 126, 38, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2709), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(2713), "In_Progress", 17508, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 125, 37, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(907), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(911), "In_Progress", 18446, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 124, 37, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(896), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(896), "Completed", 5809, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 123, 37, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(882), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(882), "In_Progress", 6555, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 122, 37, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(864), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 86, DateTimeKind.Local).AddTicks(867), "Completed", 8553, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 121, 36, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9051), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9051), "Not_Started", 22193, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 120, 36, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9037), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9040), "In_Progress", 11169, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 119, 36, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9018), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(9026), "Failed", 24186, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 118, 35, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(7326), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 85, DateTimeKind.Local).AddTicks(7330), "Not_Started", 17828, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 106, 31, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7644), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 84, DateTimeKind.Local).AddTicks(7648), "Failed", 13369, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 150, 45, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5738), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5742), "Failed", 10898, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 60, 18, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9345), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9349), "In_Progress", 16839, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, 16, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(1081), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(1089), "Failed", 18557, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, 5, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6259), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6262), "Completed", 19214, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, 5, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6230), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(6241), "Not_Started", 12298, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1941), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1944), "Failed", 8175, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1930), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1930), "Completed", 16493, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, 4, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1911), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(1915), "Failed", 4607, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 13, 3, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(212), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(212), "Not_Started", 13707, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 12, 3, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(197), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(201), "In_Progress", 12112, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 11, 3, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(183), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(186), "Not_Started", 15998, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, 3, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(168), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(172), "Not_Started", 12935, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, 3, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(150), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 78, DateTimeKind.Local).AddTicks(154), "In_Progress", 8761, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8429), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8432), "Not_Started", 19054, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8411), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8414), "In_Progress", 20905, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8305), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8308), "Not_Started", 9137, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, 2, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8268), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(8279), "Failed", 14759, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 4, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4939), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4939), "Completed", 24251, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4924), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4924), "In_Progress", 11510, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 2, 1, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4877), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 77, DateTimeKind.Local).AddTicks(4884), "Completed", 6666, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(887), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(894), "Failed", 1324, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, 18, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9320), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 81, DateTimeKind.Local).AddTicks(9331), "In_Progress", 8531, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(908), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(908), "Failed", 6926, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(934), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(934), "In_Progress", 22655, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, 12, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2443), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2446), "In_Progress", 1595, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, 12, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2432), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2432), "Not_Started", 22744, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 43, 12, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2417), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2421), "Failed", 11797, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 42, 12, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2406), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2406), "Not_Started", 10719, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 41, 12, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2388), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 80, DateTimeKind.Local).AddTicks(2392), "In_Progress", 6583, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 39, 10, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(9004), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(9008), "In_Progress", 17024, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 38, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7305), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7305), "Completed", 17566, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7290), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7294), "Not_Started", 19332, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 36, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7275), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7279), "Completed", 2822, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 35, 9, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7250), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(7261), "Failed", 5001, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2714), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2717), "Not_Started", 14268, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2699), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2703), "In_Progress", 15655, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2684), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2688), "Not_Started", 6721, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 31, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2673), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2673), "In_Progress", 17831, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 30, 8, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2655), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(2659), "Failed", 17953, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(959), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(963), "Failed", 17313, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(945), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(949), "In_Progress", 15042, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, 7, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(919), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 79, DateTimeKind.Local).AddTicks(923), "Completed", 14024, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 326, 99, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1640), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(1643), "In_Progress", 15103, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 151, 45, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5757), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5757), "Not_Started", 8911, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 153, 45, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5782), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5786), "Not_Started", 19791, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 274, 83, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(2578), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(2582), "Failed", 22648, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 273, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(897), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(901), "Completed", 11899, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 272, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(882), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(886), "Not_Started", 5081, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 271, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(872), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(875), "Completed", 10708, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 270, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(857), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(861), "Not_Started", 17473, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 269, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(846), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(846), "Failed", 13669, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 268, 82, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(828), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 95, DateTimeKind.Local).AddTicks(831), "Not_Started", 15956, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 267, 81, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9161), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9161), "Completed", 9078, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 266, 81, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9143), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(9147), "In_Progress", 4746, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 265, 80, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7425), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7429), "In_Progress", 11966, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 264, 80, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7411), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7414), "In_Progress", 21284, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 263, 80, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7400), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7400), "Failed", 14930, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 262, 80, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7382), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(7385), "Not_Started", 8288, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 258, 78, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3975), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3979), "Not_Started", 3201, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 257, 78, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3910), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(3913), "Completed", 22001, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 253, 76, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(548), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(551), "Failed", 15900, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 252, 76, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(537), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(537), "Not_Started", 9218, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 297, 91, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6476), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6479), "Failed", 16728, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 251, 76, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(515), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 94, DateTimeKind.Local).AddTicks(522), "Not_Started", 20604, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 298, 91, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6494), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(6497), "Not_Started", 16141, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 302, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9823), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9827), "Completed", 9935, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 324, 98, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9940), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9944), "Not_Started", 9583, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 323, 98, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9926), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9929), "Not_Started", 6300, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 322, 98, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9813), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9816), "Not_Started", 20522, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 321, 98, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9798), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(9802), "Not_Started", 5220, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 318, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6272), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6272), "In_Progress", 14978, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 317, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6257), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6261), "Completed", 17082, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 316, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6243), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6246), "Failed", 9208, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 315, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6232), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6232), "In_Progress", 10992, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 314, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6217), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6221), "Completed", 21437, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 313, 96, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6188), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(6199), "Completed", 3349, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 309, 94, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2168), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2299), "Failed", 19652, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 308, 94, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2154), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2157), "Not_Started", 24747, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 307, 94, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2135), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 97, DateTimeKind.Local).AddTicks(2139), "Not_Started", 23760, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 306, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9878), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9878), "Failed", 24066, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 305, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9863), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9867), "Completed", 7379, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 304, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9852), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9852), "Failed", 11144, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 303, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9838), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9842), "Failed", 19147, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 301, 93, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9809), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 96, DateTimeKind.Local).AddTicks(9812), "Failed", 18331, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 152, 45, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5771), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(5771), "Failed", 16280, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 244, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4279), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4279), "Not_Started", 18436, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 242, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4250), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4253), "Completed", 23198, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 181, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(340), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(340), "In_Progress", 2856, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 180, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(325), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(329), "Not_Started", 20558, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 179, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(311), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(314), "Not_Started", 7131, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 178, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(296), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(300), "Failed", 9974, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 177, 52, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8535), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8535), "In_Progress", 18170, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 176, 52, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8517), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(8520), "Not_Started", 20639, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 175, 51, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(6835), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(6843), "Failed", 22282, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 174, 50, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5045), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5049), "In_Progress", 24066, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 173, 50, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5030), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5034), "Completed", 22611, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 172, 50, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5019), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5019), "In_Progress", 14136, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 171, 50, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5005), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(5008), "In_Progress", 13471, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 170, 50, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(4987), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(4994), "In_Progress", 17419, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 163, 48, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1482), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1486), "Completed", 15885, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 162, 48, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1467), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1471), "Failed", 22381, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 161, 48, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1453), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 88, DateTimeKind.Local).AddTicks(1457), "Completed", 23937, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 155, 46, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7886), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7886), "In_Progress", 5299, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 154, 46, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7868), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 87, DateTimeKind.Local).AddTicks(7872), "Failed", 5972, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 182, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(351), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(355), "Completed", 23304, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 243, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4264), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4268), "Completed", 5020, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 183, 53, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(366), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(369), "In_Progress", 21176, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 200, 58, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1561), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1564), "In_Progress", 7378, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 241, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4239), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4239), "Not_Started", 2861, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 240, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4224), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4228), "Failed", 7482, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 239, 73, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4202), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 93, DateTimeKind.Local).AddTicks(4209), "Failed", 6454, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 217, 66, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(9182), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(9193), "In_Progress", 15210, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 214, 64, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3942), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3945), "In_Progress", 9072, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 213, 64, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3931), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3931), "Not_Started", 20807, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 212, 64, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3916), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3920), "Failed", 16928, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 211, 64, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3898), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(3901), "In_Progress", 22913, 4000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 209, 62, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(455), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(455), "In_Progress", 5867, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 208, 62, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(437), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 91, DateTimeKind.Local).AddTicks(441), "Completed", 15443, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 207, 61, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(8358), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(8366), "In_Progress", 5854, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 206, 60, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(5725), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(5729), "Not_Started", 11900, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 205, 59, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3986), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3986), "Not_Started", 16315, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 204, 59, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3935), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3938), "Not_Started", 4071, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 203, 59, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3916), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(3924), "Completed", 13877, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 202, 58, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1594), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1594), "In_Progress", 10071, 3000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 201, 58, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1579), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 90, DateTimeKind.Local).AddTicks(1579), "Failed", 18933, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 199, 57, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(9052), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 89, DateTimeKind.Local).AddTicks(9059), "Not_Started", 12136, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 335, 101, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5979), true, "Anonymous", new DateTime(2019, 3, 24, 1, 30, 16, 98, DateTimeKind.Local).AddTicks(5982), "In_Progress", 5355, 10000 });

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
                name: "ErrandActors");
        }
    }
}
