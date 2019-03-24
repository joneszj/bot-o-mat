using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedVentures.Bot_O_Mat.API.Data.Migrations
{
    public partial class killedbySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.RenameColumn(
                name: "KilledBy",
                table: "ErrandActor",
                newName: "KilledById");

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3411), false, 0, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3414), "Winona Hudson", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6707), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6707), "Jayde Kuhn", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8599), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8603), "Briana Considine", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1626), false, 0, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1630), "Ernest Rogahn", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1564), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1564), "Johnathan Luettgen", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3434), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3434), "Cierra Corkery", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(114), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(118), "Anna Baumbach", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8739), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8739), "Ms. Doris Klein", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(836), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(839), "Marc Legros" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(8975), false, 3, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(8975), "Randi Stiedemann", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4758), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4762), "Russ Witting DDS", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6578), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6582), "Dolores Schowalter", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3715), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3719), "Everette Towne", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(4349), false, 4, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(4353), "Cristina Johns", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1384), false, 4, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1387), "Arnaldo Bernier", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8418), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8418), "Osvaldo Goldner IV", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(1897), false, 5, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(1901), "Abby Bernier", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7997), false, 6, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(8000), "Yasmeen Hintz" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9671), false, 6, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9674), "Breanne Bruen", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(1512), false, 6, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(1512), "Gene Anderson", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(626), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(630), "Wilburn Barrows" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(27), false, 7, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(30), "Myrtle Steuber Sr.", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1678), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1682), "Marietta Howe", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7414), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7418), "Alfonso Blick", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9497), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9497), "Mariah Fisher" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5230), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5230), "Donny Pfeffer MD", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8413), false, 8, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8413), "Alfredo Sauer", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4330), "Shany Abbott", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7755), false, 10, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7758), "Ramona Mraz", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4653), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4653), "Elmo Bartell DDS" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1883), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1887), "Dr. Shana Koss", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4166), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4169), "Dr. Branson Wunsch", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2837), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2837), "Arne Goyette", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5505), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5509), "Brain Wilkinson" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7890), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7894), "Taryn Jones" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6635), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6635), "Morgan Armstrong", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(154), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(158), "Malinda Trantow", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(843), false, 5, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(843), "Loraine Littel", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4456), false, 6, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4456), "Ernie Ortiz", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(6184), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(6184), "Jammie Prosacco" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IsActive", "KilledById", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6356), false, 6, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6356), "Declan Parisian", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3921), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3925), "Wilburn Treutel" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(5862), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(5865), "Anabelle Morar", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7820), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7823), "Adan Boehm", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9698), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9702), "Beth Hirthe" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4858), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4862), "Colin Koch", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(5021), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(5025), "Xander Gleichner", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(112), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(116), "Madisen Stokes", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3912), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3912), "Conor Pagac", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5979), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5982), "Toy Stroman", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 59, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2658), false, 5, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2658), "Torrey Tillman", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 6, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4705), false, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4708), "Jadon Rolfson", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 93, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5637), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5637), "Marques Block", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 11, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6425), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6429), "Magali Stoltenberg", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 13, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9872), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9875), "Marcos Armstrong", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 21, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8353), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8353), "Forest Connelly", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 88, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6728), false, 8, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6732), "Omari Hauck", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 85, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(1615), false, 8, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(1615), "Sonia Doyle", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 25, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6853), false, 2, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6853), "Ms. Vernie McGlynn", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 28, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3486), false, 2, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3490), "Candice Harris", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 31, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(783), false, 3, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(783), "Clinton Lang", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 84, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9920), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9920), "Demetris Haley PhD", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 36, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(174), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(174), "Ms. Payton Robel", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 37, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1902), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1906), "Dana Morar IV", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 83, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8155), false, 8, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8158), "Thora Heathcote", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 40, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7325), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7329), "Cordelia Zemlak", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 42, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(903), false, 4, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(903), "Alysa Labadie", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 70, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(6770), false, 7, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(6774), "Mrs. Vicente Block", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 67, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8894), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8894), "Titus Nicolas", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 2, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(6730), false, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(6737), "Brain Wiegand", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 46, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(9593), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(9597), "Abner Von", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 48, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3083), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3087), "Lempi McCullough", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 54, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3677), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3680), "Priscilla Ritchie", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 1, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 561, DateTimeKind.Local).AddTicks(8273), false, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 563, DateTimeKind.Local).AddTicks(5769), "Davion Kris Sr.", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 101, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9505), false, 10, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9509), "Erika Ondricka", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 86, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3380), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3380), "Westley Breitenberg", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 5, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(821), false, 0, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(825), "Wilfred Effertz", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 81, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3272), false, 8, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3275), "Camylle Thiel", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 80, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1218), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1218), "Jan Schuppe", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 69, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2518), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2522), "Fermin Ullrich", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 65, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3821), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3821), "Robert Streich", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 57, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(9016), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(9019), "Mr. Colt Cassin", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 56, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7247), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7251), "Jalyn Upton", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 55, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5409), false, 5, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5409), "Percy Kshlerin", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 49, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4801), false, 4, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4804), "Mr. Myrna Huel", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 44, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6125), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6129), "Torrance Pagac", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 41, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9119), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9123), "Camron Swaniawski", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 35, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(8285), false, 3, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(8289), "Kaleb Stracke", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 29, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6349), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6353), "Thomas Towne", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 20, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6511), false, 2, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6511), "Colton Kulas", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 19, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4750), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4754), "Virgil Boyer", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 18, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8889), false, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8889), "Dr. Melyna Mohr", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 17, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7113), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7117), "Eden Bernier", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 91, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1801), false, 9, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1804), "Peter Bahringer", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 16, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5337), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5341), "Eddie Stark", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 94, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7358), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7358), "Ms. Ezekiel Ankunding", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 96, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(866), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(866), "Janiya Price", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 4, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6784), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6791), "Shane Reilly", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 95, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9119), false, 9, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9119), "Asha Daugherty IV", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 12, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8132), true, null, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8132), "Cydney Towne", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledById", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 97, 1, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2616), false, 9, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2620), "Foster Kohler", "Other" });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6660), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6671), 10368, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6704), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6707), "Not_Started", 12904, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 3, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6733), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6737), "In_Progress", 11193 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6755), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(6759), "Not_Started", 9182, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8545), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8548), 18280, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8566), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8566), "Not_Started", 14636, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8581), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(8581), "In_Progress", 16943, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1280), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1294), 21736, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1404), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1407), 14937, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1608), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(1611), "Not_Started", 15206, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4591), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4598), "Not_Started", 13633, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4613), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4617), "Failed", 1524, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4631), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(4631), "Failed", 11134, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6367), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6371), 18911, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6385), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6389), "Failed", 5880, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6400), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6400), "Completed", 23153, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6411), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(6414), 16627, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3375), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3379), "Not_Started", 23073, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3390), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3394), 24488, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3405), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3408), "Not_Started", 19020, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3419), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(3419), "Not_Started", 10406, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5253), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5261), "Failed", 2746 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5272), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5275), "In_Progress", 18926, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5283), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5286), "Not_Started", 19724, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5297), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5301), "Not_Started", 4457, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5308), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5312), "Not_Started", 16962, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5323), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(5326), "Completed", 6456, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1814), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1817), 19169, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1832), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1832), "In_Progress", 2504, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1843), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1846), "Failed", 15676, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 22, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1857), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1857), "Completed", 5161 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1868), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(1872), "Completed", 15404, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4082), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4089), "Completed", 17278, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4107), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4107), "Failed", 18609, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4122), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4122), 4064, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4133), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4136), "Not_Started", 16416, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4147), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(4147), "Failed", 7357, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6806), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6813), "Completed", 11666, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6831), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(6835), "Not_Started", 23679, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(788), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(792), "In_Progress", 8157, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(806), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(810), "Completed", 4797, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(821), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(821), "In_Progress", 3994, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 27, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3410), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3413), "Completed", 4845 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3428), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3432), "In_Progress", 11003, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3442), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3442), "Not_Started", 16782, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3453), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3457), "Not_Started", 3841, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3468), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(3472), "Not_Started", 22248, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 30, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(758), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(765), "Completed", 3240, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4722), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4729), "Completed", 15355, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4740), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(4744), 23497, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6534), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6538), "Not_Started", 7957, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6549), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6553), "Failed", 2007, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6564), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(6564), "Failed", 19740, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(8267), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(8270), "Not_Started", 19208, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 38, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5462), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5465), "Failed", 23860, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 38, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5476), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5480), 19703, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 38, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5491), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(5491), "Failed", 10003, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 39, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7296), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7300), "Failed", 8386, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 39, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7311), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(7314), 13037, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 43, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6081), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6085), 2581, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 43, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6099), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6099), 13173, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 43, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6110), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(6114), 21711, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(9575), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(9578), "Failed", 13861, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3050), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3054), "Failed", 8905, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3069), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(3069), "Failed", 9519, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 50, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8345), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8353), 7412 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8364), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8364), "Failed", 12071, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8375), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8378), "Completed", 14077, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8389), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8393), "Failed", 15554, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 50, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8400), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(8404), "Not_Started", 7843 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(136), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(140), "Completed", 2960, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 52, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(1879), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(1883), "Completed", 14714, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3546), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3549), 13979, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3560), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3564), 13123, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3575), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3578), "Completed", 23863, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3586), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3589), "Failed", 14022, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3600), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3604), 8691, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3611), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(3615), "In_Progress", 12600, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2560), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2564), 3161, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2589), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2592), "Failed", 18098, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2603), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2607), "In_Progress", 17783, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2618), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2618), "In_Progress", 19078, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2629), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2632), "Failed", 21617, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2643), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(2643), "Failed", 23302, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 60, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(6166), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(6170), "Not_Started", 16164, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7949), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7953), "Not_Started", 21472, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7968), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7971), "In_Progress", 8864, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7982), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(7986), "Completed", 3059, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 62, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9638), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9645), "Completed", 22880 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 62, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9656), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(9660), 3885, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(1494), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(1498), "Completed", 7577, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3774), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3778), 24770, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3792), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3796), "Not_Started", 15900, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3807), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(3807), "Completed", 2433, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 66, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8817), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8825), 11640, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 66, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8876), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(8876), "Failed", 24091 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2412), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2416), "Not_Started", 11650 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2438), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2441), "Completed", 8274, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2460), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2463), "Not_Started", 20362, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2489), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(2493), "Not_Started", 15559, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3663), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3677), "Not_Started", 15385, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3699), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3703), "In_Progress", 23184, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3714), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(3717), "Failed", 7135, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(5836), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(5840), "In_Progress", 21965, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7699), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7703), "Not_Started", 19992, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7761), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7761), "Completed", 12308, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7772), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7776), "Failed", 18157 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7787), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(7791), "Failed", 24742, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 74, new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9607), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9614), "Completed", 11839, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9629), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9632), "Completed", 17457, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9643), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9643), "In_Progress", 8523, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9658), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9658), 14805, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9669), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9672), "In_Progress", 3528, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9683), new DateTime(2019, 3, 24, 0, 17, 46, 593, DateTimeKind.Local).AddTicks(9687), "In_Progress", 22114, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1609), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1616), "Failed", 9974, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 75, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1627), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1631), "In_Progress", 14091, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 75, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1642), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1645), "Completed", 16434, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 75, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1653), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(1656), "Completed", 20735 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4759), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4770), "In_Progress", 19783, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4789), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4792), "Failed", 1576 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4803), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4807), 20360, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4818), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4818), "Not_Started", 21239 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4829), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4832), "Completed", 20646, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4843), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(4843), "Failed", 7683, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 77, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7378), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7381), "Failed", 7087, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 77, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7396), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(7400), "Not_Started", 16263, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9391), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9394), 12280, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9405), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9409), "Not_Started", 22456, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9420), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9420), "Not_Started", 6220, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9467), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9467), "In_Progress", 22716, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9478), new DateTime(2019, 3, 24, 0, 17, 46, 594, DateTimeKind.Local).AddTicks(9482), 6197, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1159), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1163), "Failed", 11341, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1174), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1178), "Not_Started", 20543, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1189), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1189), "Completed", 11827, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1200), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(1203), "Not_Started", 4672, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8093), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8096), 9880, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8111), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8111), "Completed", 16028, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8122), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8126), "Not_Started", 1036, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8136), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(8136), "In_Progress", 17783, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6659), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6662), 7861, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6673), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6677), 19703, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6688), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6688), "Not_Started", 6415, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 87, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6699), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6703), "Failed", 24599 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6713), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(6713), 3198, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(94), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(98), "Not_Started", 7712, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1724), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1728), "In_Progress", 22264, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1771), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1771), "In_Progress", 10824, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 90, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1786), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(1786), "Completed", 16598 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 92, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5600), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5607), "In_Progress", 19727, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 92, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5618), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(5622), "Failed", 15013, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 98, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5946), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5949), "Completed", 16563, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 98, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5964), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(5964), "Failed", 12227 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 346, 99, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7740), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7740), "Not_Started", 20774, 7000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 349, 100, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9490), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9494), "Completed", 24839, 1000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 348, 100, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9479), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9479), "Completed", 15367, 14500 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 345, 99, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7703), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(7707), "Completed", 16421, 18000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 347, 100, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9461), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(9465), "In_Progress", 15612, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(2602), new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(2653), 5382, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5530), new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5727), "Completed", 24089, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5771), new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5771), "Failed", 23806, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5785), new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5785), 15497 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5869), new DateTime(2019, 3, 24, 0, 17, 46, 577, DateTimeKind.Local).AddTicks(5873), "In_Progress", 13919, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(2959), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(2988), "Failed", 1577, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3032), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3035), "Completed", 10634, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3057), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3061), "In_Progress", 6751, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3079), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3079), "Completed", 3287 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3101), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3105), "Failed", 14747, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3207), new DateTime(2019, 3, 24, 0, 17, 46, 578, DateTimeKind.Local).AddTicks(3342), "Completed", 2843, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 4, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(620), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(628), 18973, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 4, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(785), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(788), "Completed", 3404, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4307), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4318), "Completed", 6778 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4340), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4347), "Completed", 8710, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4591), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4595), 24751, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4621), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4621), "Completed", 15787, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4632), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4635), "Completed", 16819, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4646), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(4650), "In_Progress", 23330, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6656), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6663), "In_Progress", 17604, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6681), new DateTime(2019, 3, 24, 0, 17, 46, 579, DateTimeKind.Local).AddTicks(6685), "Not_Started", 23972, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8085), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8088), "Failed", 21095, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8103), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8103), 10684, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 11, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8114), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(8118), "Failed", 23676, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9788), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9791), 17780, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9806), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9806), "Completed", 16106, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9817), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9821), "In_Progress", 21652, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9831), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9835), 24780, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 12, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9842), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9846), 7274, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 12, new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9857), new DateTime(2019, 3, 24, 0, 17, 46, 580, DateTimeKind.Local).AddTicks(9861), "Failed", 1618 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 13, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1505), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1509), 4072, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 13, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1520), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1524), 2867, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 13, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1534), "Completed", 19323, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 13, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1545), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(1549), "Failed", 19326, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7026), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7033), "Not_Started", 5069 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7044), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7048), 10261 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7059), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7062), "Completed", 22839, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7073), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7073), "Completed", 24607, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7088), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7088), "Not_Started", 11362, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 16, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7099), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(7102), "Completed", 8886, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8816), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8820), "Completed", 4639, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8834), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8834), "Not_Started", 14086, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8845), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8849), "Not_Started", 22422, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8860), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8860), "Not_Started", 12684, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 17, new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8871), new DateTime(2019, 3, 24, 0, 17, 46, 581, DateTimeKind.Local).AddTicks(8875), "In_Progress", 5850 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4652), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4662), "In_Progress", 3445 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4681), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4681), 7874, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4692), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4695), 13092, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4706), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4710), 5829 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4721), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4721), 10875, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4732), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(4735), "Completed", 15384, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6449), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6457), "In_Progress", 9302, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6468), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6471), "Failed", 15473, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6482), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6482), "In_Progress", 6463, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6493), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(6497), "In_Progress", 4198, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8200), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8203), 22168, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8214), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8218), 14936, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8229), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8229), 18897, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8240), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8244), "Failed", 6108, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8331), new DateTime(2019, 3, 24, 0, 17, 46, 582, DateTimeKind.Local).AddTicks(8335), "Not_Started", 6962, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(41), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(49), "Not_Started", 17861, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(63), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(63), "Failed", 2393, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 21, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(74), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(78), "Completed", 5155 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(89), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(89), "Not_Started", 24520, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 21, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(100), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(103), "Completed", 19813, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8651), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8655), "In_Progress", 17995, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8669), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8669), 4281, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8680), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8684), "Completed", 23565, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8695), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8695), "Failed", 15715, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8706), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8709), "In_Progress", 23536, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8720), new DateTime(2019, 3, 24, 0, 17, 46, 583, DateTimeKind.Local).AddTicks(8724), "In_Progress", 16231, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6276), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6280), 21489, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6294), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6298), "Failed", 9523, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6309), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6309), "Failed", 17619, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6320), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6323), 24312, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 28, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6334), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(6334), "Not_Started", 15874 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(8789), new DateTime(2019, 3, 24, 0, 17, 46, 584, DateTimeKind.Local).AddTicks(8792), 9869, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 31, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2767), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2771), "In_Progress", 22332, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 31, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2786), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2786), "Completed", 24431 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 31, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2797), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2800), 18446 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 31, new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2811), new DateTime(2019, 3, 24, 0, 17, 46, 585, DateTimeKind.Local).AddTicks(2815), "In_Progress", 3956, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 35, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(79), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(83), "Failed", 14848 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 35, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(141), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(141), "Not_Started", 12229, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 35, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(156), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(159), 2173, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 36, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1859), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1862), "In_Progress", 10158, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 36, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1873), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1877), 8127, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 36, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1888), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(1888), "Not_Started", 8607 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3668), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3675), "In_Progress", 14794, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3686), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3689), "Not_Started", 11229, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3700), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(3700), 24215, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9072), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9079), "Not_Started", 23414, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9090), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9090), 13753, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9101), new DateTime(2019, 3, 24, 0, 17, 46, 586, DateTimeKind.Local).AddTicks(9105), "In_Progress", 10801, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 41, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(826), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(830), "In_Progress", 1385, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 41, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(844), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(844), 11222, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 41, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(884), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(888), "Completed", 13968, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 42, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(4320), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(4327), "Not_Started", 21739, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7835), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7839), "In_Progress", 23160, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7850), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7854), "In_Progress", 10754, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7864), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7864), 21764, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7875), new DateTime(2019, 3, 24, 0, 17, 46, 587, DateTimeKind.Local).AddTicks(7879), 19365, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1281), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1285), 12129, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1300), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1300), "In_Progress", 24950, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1340), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1343), "In_Progress", 11070, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1354), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1358), 18215, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1369), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(1369), "Not_Started", 10817, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 48, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4768), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4775), "Not_Started", 22378 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 48, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4786), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(4790), "In_Progress", 14984, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6551), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6555), 19385, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6566), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6569), 10320, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6580), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6580), "In_Progress", 3015, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6591), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6595), 2681, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6606), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6606), "Completed", 10567, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6617), new DateTime(2019, 3, 24, 0, 17, 46, 588, DateTimeKind.Local).AddTicks(6621), "Failed", 23346, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5351), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5354), "Completed", 5435, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5365), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5369), "Failed", 15495, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5380), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5383), "In_Progress", 15685, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 54, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5391), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(5394), 15581, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7178), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7181), "Completed", 23714, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7196), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7196), "Failed", 11571, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7207), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7210), 24925, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7221), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7221), 5810, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7232), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(7236), "Failed", 11468, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 56, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8957), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8961), "In_Progress", 1985 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 56, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8976), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8979), 22652, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 56, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8986), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(8990), 14677, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 56, new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(9001), new DateTime(2019, 3, 24, 0, 17, 46, 589, DateTimeKind.Local).AddTicks(9005), 1975, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(770), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(773), "Failed", 17819, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(788), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(788), "Failed", 9028, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(799), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(803), "Failed", 13138, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 57, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(813), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(813), "Not_Started", 24692 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(824), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(828), "Not_Started", 2675, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4372), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4379), "Failed", 8259, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4390), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4390), "Failed", 21808 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4401), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4405), 14471 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4416), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4416), "Completed", 5795, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4427), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4430), "Completed", 16486, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4441), new DateTime(2019, 3, 24, 0, 17, 46, 590, DateTimeKind.Local).AddTicks(4441), "Failed", 24531, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6294), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6305), "Failed", 4830, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6323), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6323), "Not_Started", 21547, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6334), new DateTime(2019, 3, 24, 0, 17, 46, 591, DateTimeKind.Local).AddTicks(6338), "In_Progress", 21435, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(593), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(597), "Completed", 10207, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 67, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(612), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(615), "Completed", 15434 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 69, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(6719), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(6734), 14168, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9888), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9903), 5201, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 70, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9932), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9935), "Completed", 12496 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9954), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9957), "Failed", 12373, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9972), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9976), 22812, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9994), new DateTime(2019, 3, 24, 0, 17, 46, 592, DateTimeKind.Local).AddTicks(9997), 16254, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3089), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3097), "Failed", 16562, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3239), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3239), "Not_Started", 5312, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3250), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(3254), "Failed", 2953, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(4978), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(4986), "Completed", 16697, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 81, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(4997), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5000), "Failed", 1347 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 81, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5201), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5201), "In_Progress", 5170 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5212), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(5215), 9100, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9872), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9876), "Not_Started", 13607, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9891), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9894), 14617, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9901), new DateTime(2019, 3, 24, 0, 17, 46, 595, DateTimeKind.Local).AddTicks(9905), "Not_Started", 18040, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 84, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(1597), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(1601), "Completed", 13767, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3267), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3271), "In_Progress", 5765, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3282), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3286), "In_Progress", 8693, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3297), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3297), 14679, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3307), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3311), 2553, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3351), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3351), "In_Progress", 8000, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3362), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(3366), 17002, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 86, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(5003), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(5007), "Not_Started", 6029, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8380), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8384), "Failed", 10830, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8395), new DateTime(2019, 3, 24, 0, 17, 46, 596, DateTimeKind.Local).AddTicks(8398), "In_Progress", 4775, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3839), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3846), "Failed", 19921, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 91, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3857), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3861), 15489, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 91, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3872), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3872), "Failed", 5723 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 91, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3883), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3886), 8115, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 91, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3893), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(3897), "In_Progress", 4253, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 93, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7314), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7318), "In_Progress", 7677, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 93, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7329), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7332), "Failed", 15645, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 93, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7340), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(7343), "Not_Started", 7897, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9035), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9043), 10938, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9054), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9057), "Not_Started", 17811, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9068), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9068), 13131, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9079), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9083), "Not_Started", 15551, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9090), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9094), 8133 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9105), new DateTime(2019, 3, 24, 0, 17, 46, 597, DateTimeKind.Local).AddTicks(9105), 3958, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(833), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(837), "Failed", 18110, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(848), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(851), "Failed", 22676, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2562), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2565), "Not_Started", 13191, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2576), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2580), "Completed", 10977, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2591), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2591), "In_Progress", 19041, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2602), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(2605), 7488, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 97, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4250), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4254), "Completed", 22097, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 97, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4268), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4268), "Completed", 4945, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 97, new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4312), new DateTime(2019, 3, 24, 0, 17, 46, 598, DateTimeKind.Local).AddTicks(4316), 1519, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 354, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1237), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1241), "Not_Started", 23224, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 350, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1182), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1190), "Not_Started", 11993, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 351, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1201), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1201), "In_Progress", 18367, 10000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 352, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1212), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1215), "Failed", 9158, 8000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 353, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1226), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1226), "Failed", 22273, 20000 });

            migrationBuilder.InsertData(
                table: "Errands",
                columns: new[] { "Id", "ActorId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 355, 101, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1252), true, "Anonymous", new DateTime(2019, 3, 24, 0, 17, 46, 599, DateTimeKind.Local).AddTicks(1252), "Not_Started", 16318, 14500 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.RenameColumn(
                name: "KilledById",
                table: "ErrandActor",
                newName: "KilledBy");

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(362), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(362), "Mrs. Bennett Rosenbaum", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(358), "Darien Daniel", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2058), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2058), "Dr. Hilario Douglas", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3779), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3783), "Aric Ledner", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(5386), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(5390), "Mr. Dion Metz", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7133), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7133), "Gillian Sipes", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9353), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9353), "Roel Parisian", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(8076), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(8079), "Kyle Frami", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1570), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1573), "Lilla Erdman" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(308), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(308), "Myah Marquardt", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6755), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6755), "Camylle Fritsch", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9118), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9122), "Newell Durgan", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6984), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6987), "Nichole Balistreri", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(6242), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(6246), "Jedidiah Breitenberg", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4463), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4463), "Dejon Kerluke Sr.", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4305), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4305), "Jayne Feil", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7832), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7835), "Adrain Dickinson", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4125), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4125), "Lincoln Considine" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5938), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5941), "Dario Flatley MD", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7724), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7724), "Alexandro McCullough", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6950), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6950), "Deondre Harber" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2850), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2854), "Garnet Gulgowski", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(4367), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(4367), "Dr. Emory Hills", "Female" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8134), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8138), "Augustus Koepp", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(322), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(326), "Elda Hermann" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6252), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6255), "Blanche Witting", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9712), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9715), "Christine Pfannerstill", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5549), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5549), "Wilfredo Zboncak", "Other" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8984), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8984), "Alfonzo Mann", "Male" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5438), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5442), "Wilbert Ondricka" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1584), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1588), "Esperanza Abshire", "Bipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3845), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3849), "Colt Windler", "Bipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(4527), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(4527), "Everardo Johns", "Bipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(8822), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(8825), "Kathleen Cronin" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9890), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9890), "Mckenna Swaniawski" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2573), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2577), "Michele Wintheiser", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6078), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6078), "Dr. Harmony Crooks", "Arachnid" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6916), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6919), "Paige McClure", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(526), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(526), "Lucius Hodkiewicz III", "Bipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2269), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2273), "Winston Kohler DDS" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IsActive", "KilledBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2793), true, null, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2796), "Kyla Senger", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5082), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5086), "Lyric Dickinson" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7485), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7485), "Winnifred Wiegand", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(177), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(181), "Ms. Claud Lakin", "Arachnid" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2274), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2274), "Jesus Friesen" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6231), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6234), "Karina Moen", "Aeronautical" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(6087), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(6091), "Heber Rolfson", "Arachnid" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1458), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1462), "Logan Prosacco III", "Quadrupedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4901), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4905), "Eino Jones", "Unipedal" });

            migrationBuilder.UpdateData(
                table: "ErrandActor",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(7208), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(7208), "Ryder Hermiston", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 65, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(149), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(153), "Dr. Liliana Volkman", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 4, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(5030), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(5030), "Leann Kulas", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 5, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6879), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6883), "Mrs. Pierre Zboncak", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 96, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2143), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2143), "Jakob Schultz", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 12, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1926), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1929), "Aric Lynch", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 16, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(8778), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(8778), "Rogers Roob", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 17, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(474), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(477), "Eden Bins", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 18, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2188), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2191), "Seamus Treutel", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 19, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4237), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4241), "Retha Becker", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 20, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5958), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5962), "Kory Grimes", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 95, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(320), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(451), "Dixie Veum MD", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 94, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(8307), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(8311), "Claudie Osinski", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 57, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(5129), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(5132), "Bryce Hayes PhD", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 29, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8258), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8262), "Dedrick Jacobson", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 35, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1510), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1514), "Mr. Lue Wehner", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 86, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4322), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4326), "Talia Rogahn", "Bipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 41, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2607), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2610), "Waldo Yost", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 44, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(8011), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(8011), "Mr. Estella Bruen", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 81, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(4355), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(4359), "Myrtie Durgan", "Quadrupedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 49, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(848), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(852), "Alvera Strosin", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 80, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2251), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2255), "Magnolia Grant PhD", "Radial" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 69, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8876), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8876), "Turner Marks", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 55, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(1697), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(1697), "Ed Hand", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 56, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(3324), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(3327), "Velva Cartwright", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 1, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 358, DateTimeKind.Local).AddTicks(3010), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 359, DateTimeKind.Local).AddTicks(6655), "Sarai West", "Arachnid" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 91, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3227), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3231), "Eloy Sanford", "Unipedal" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Type" },
                values: new object[] { 97, 0, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3894), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3894), "Tara O'Keefe", "Aeronautical" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 2, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5954), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5965), "Noelia Balistreri", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 101, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1165), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1169), "Cayla Barrows", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 93, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(6648), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(6648), "Roy Miller", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 88, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7808), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7808), "Ocie Wintheiser", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 85, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2444), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2444), "Price Purdy PhD", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 84, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(555), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(559), "Jarred Bergstrom", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 83, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8082), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8086), "Olin Miller", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 70, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(965), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(969), "Pattie Littel", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 67, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(5006), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(5006), "Mackenzie Hilpert", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 59, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8692), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8692), "Mrs. Adelbert Kessler", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 11, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7156), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7159), "Orlo Hirthe Sr.", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 54, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9677), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9677), "Therese Olson", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 46, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1731), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1735), "Alfredo Gutmann", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 42, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(4339), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(4342), "Daphney Sanford", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 40, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(838), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(842), "Eden McDermott", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 37, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(5149), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(5149), "Agustin Ziemann", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 36, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3366), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3370), "Jewel Gulgowski", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 31, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2197), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2200), "Martin Senger Sr.", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 28, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(5020), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(5023), "Verla Purdy", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 25, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6074), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6077), "Dr. Lou Simonis", "Other" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 48, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7945), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7945), "Matilde Corkery III", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 21, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7647), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7650), "Trevor Funk", "Female" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 13, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3705), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3709), "Jay Gleichner", "Male" });

            migrationBuilder.InsertData(
                table: "ErrandActor",
                columns: new[] { "Id", "ActorType", "CreatedBy", "CreatedDate", "IsActive", "KilledBy", "ModifiedBy", "ModifiedDate", "Name", "Gender" },
                values: new object[] { 6, 1, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(8582), true, null, "Anonymous", new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(8586), "Kendrick Dach", "Other" });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4943), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4950), "Not_Started", 6944, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4968), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4972), "Not_Started", 2214 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4983), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4987), "In_Progress", 19695, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(4997), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(5001), "Not_Started", 23579, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2010), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2014), 21976, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2028), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2032), "Not_Started", 2312, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 7, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2043), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(2043), "Not_Started", 21263, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3691), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3695), "Failed", 3182, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3706), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3710), "Not_Started", 1288, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3721), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3724), "Failed", 10739, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 8, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3735), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(3735), 2358, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5391), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5398), "In_Progress", 19407, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5409), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5413), "Failed", 10364, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 9, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5424), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(5424), 19832, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7086), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7090), 17027, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7101), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7105), "Completed", 22834, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7116), "Completed", 23150, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7127), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7130), "In_Progress", 9697, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 10, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7141), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(7145), "Not_Started", 16771, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 14, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7060), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7064), "Not_Started", 10802 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7078), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7082), 16139, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7093), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7093), 12292, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7104), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7108), "Not_Started", 12980, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 14, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7118), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(7118), "Completed", 15001, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 15, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(8756), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(8760), "Completed", 18565, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1486), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1497), 24606, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1515), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1515), 18468 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1526), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1530), 1271, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1541), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1544), "Not_Started", 7486, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1555), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1559), "Failed", 5757, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 22, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1570), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(1570), "Completed", 11143, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3798), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3802), "Not_Started", 19149, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3816), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3820), "Not_Started", 24835, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 23, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3831), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(3834), 13369, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(5971), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(5975), 14691, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(5986), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(5990), 6039, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6001), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6001), "Completed", 21591, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 24, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6012), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(6015), "In_Progress", 5759, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1307), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1318), "In_Progress", 4679, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 26, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1351), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1355), "Not_Started", 11570 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1501), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1504), "Failed", 21232, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1522), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1526), "In_Progress", 18781, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 26, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1544), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(1548), 2599, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4903), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4918), "Not_Started", 6058, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4947), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4950), "In_Progress", 20867, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 27, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4969), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4972), "Failed", 16527 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 27, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4990), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(4994), "Not_Started", 10764, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 30, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2062), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2065), "Completed", 22842, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 30, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2076), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(2080), 19183, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6697), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6700), "Not_Started", 4724, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6711), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6715), "Completed", 4421, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6726), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6729), "Failed", 15182, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 32, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6740), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(6740), "Not_Started", 8095, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9045), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9049), "Not_Started", 13171, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9063), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9063), "Failed", 12861, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 33, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9074), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9078), "Not_Started", 12016 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9089), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9092), "Not_Started", 15941, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 33, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9103), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(9103), "In_Progress", 2669, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1419), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1423), "Failed", 14920, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1437), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1441), "In_Progress", 14656, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1452), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1452), 15497, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1463), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1466), "In_Progress", 16405, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1477), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1481), "In_Progress", 14153, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 34, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1492), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(1492), 3852, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 38, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(8804), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(8807), "Completed", 7260, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 39, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(820), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(823), "In_Progress", 3456 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 43, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(7953), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(7956), 21606, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1644), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1647), 2850, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1662), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1666), "Completed", 1680, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1677), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1677), 13528, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1688), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1691), "Completed", 1761, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1702), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1706), "Failed", 16244, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 45, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1717), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(1717), 3935, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7883), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7891), 19553, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7902), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7905), "Failed", 10923, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7916), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7916), "Not_Started", 17673, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 47, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7927), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(7931), 11521, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4258), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4262), "In_Progress", 10841, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 50, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4276), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4280), "Not_Started", 6806, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 50, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4287), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(4291), "In_Progress", 17123 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5954), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5957), "Completed", 13122, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5972), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5972), 15318, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5983), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(5987), 10737, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6041), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6048), "Failed", 9296, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 51, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6059), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(6063), 23611, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 52, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7788), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7792), "Failed", 1713, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 52, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7806), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7806), "Completed", 11677, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 52, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7817), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(7821), 13078 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9589), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9597), "In_Progress", 16081, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9618), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9622), "Failed", 21773, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9633), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9637), "Not_Started", 14287, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 53, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9648), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9648), "In_Progress", 22331 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 53, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9659), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(9662), "Failed", 6560, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8608), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8611), "Failed", 19682, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8622), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8626), 24162, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8637), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8640), "Failed", 9987, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8648), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8651), "Not_Started", 7764, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8662), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8666), 12137, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 58, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8677), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(8677), 17504, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 60, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2225), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2229), 7101, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 60, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2243), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2243), "Not_Started", 19705, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 60, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2254), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(2258), "Not_Started", 14795, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4056), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4059), "Completed", 6887, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 61, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4070), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4074), "Completed", 8102 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4085), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4085), "Completed", 23247, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4096), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4100), 6437, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 61, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4110), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(4110), "Completed", 15092, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 62, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5905), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5908), "Not_Started", 7746, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 62, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5923), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(5927), "Not_Started", 22418, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7677), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7681), "Not_Started", 9908, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7695), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7699), "Not_Started", 13549, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 63, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7710), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(7710), "In_Progress", 22031, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(61), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(65), "Completed", 21206 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(80), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(83), 18338 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(94), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(94), "Not_Started", 13551, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(109), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(109), "Not_Started", 1843, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(120), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(123), "Completed", 21101, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 64, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(134), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(134), "In_Progress", 8519, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 66, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4879), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4882), "Not_Started", 24951 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 66, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4897), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4897), 21098, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 66, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4959), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4963), "Not_Started", 6280, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 66, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4977), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4977), 7833, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 66, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4988), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(4992), "In_Progress", 22796, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 68, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8814), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8821), "Completed", 17596 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 68, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8832), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8835), "In_Progress", 23198, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 68, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8846), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8846), "Failed", 15706 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8857), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(8861), "Failed", 23613 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(4998), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5009), 24502, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 71, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5031), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5031), "In_Progress", 10248 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5046), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5046), "Not_Started", 4871, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 71, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5057), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(5060), 13365, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 72, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7427), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7431), 9002, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7445), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7445), "Completed", 19251, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7456), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7460), "Completed", 10912, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 72, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7471), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(7471), "In_Progress", 14538, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 73, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(9973), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(9984), "Not_Started", 12663, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(60), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(64), "In_Progress", 5142, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(82), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(82), "Failed", 2457, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(101), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(104), "In_Progress", 13395 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(122), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(126), "Not_Started", 10278, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 73, new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(152), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(155), "Failed", 8936, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2186), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2194), "Not_Started", 10676, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2212), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2216), "Failed", 5386, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2227), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2230), 22568, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2241), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2241), "Completed", 10961, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2252), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(2256), "Not_Started", 3390, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(4334), "Not_Started", 8709, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6194), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6202), "Not_Started", 17678, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 76, new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6216), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(6216), "Not_Started", 13213, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 77, new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8098), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8101), "Failed", 11576 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 77, new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8116), new DateTime(2019, 3, 23, 23, 12, 51, 388, DateTimeKind.Local).AddTicks(8120), "Not_Started", 15649, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(231), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(238), "Not_Started", 16411 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(253), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(256), 20177, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(267), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(267), "In_Progress", 14148 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(278), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(282), "Failed", 14466, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(293), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(296), "In_Progress", 1327, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 78, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(307), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(307), "Not_Started", 7864, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2204), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2211), "In_Progress", 8828, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2222), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2226), 9856, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 79, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2237), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(2237), "Failed", 9669, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8049), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8057), "Failed", 23177, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 82, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8068), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(8071), "In_Progress", 19353, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7739), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7743), "Completed", 3213, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7754), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7757), "Failed", 3822, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7768), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7768), 4027, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7779), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7783), 16702, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 87, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7794), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(7794), "Failed", 22514, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1389), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1393), "Failed", 19023, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 89, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1404), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1407), "In_Progress", 20820 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 89, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1418), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1422), 8598, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1433), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1433), "Completed", 24418, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 89, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1444), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(1447), "Failed", 11446, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 90, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3183), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3187), "Failed", 2713, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3202), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3202), "Not_Started", 2582, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3213), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(3216), "Not_Started", 13288, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 92, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(6626), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(6629), 19632, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 98, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(7190), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(7194), 18227 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 99, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8912), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8915), 21673, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 99, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8941), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8944), "Not_Started", 5855, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 99, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8955), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8955), "Not_Started", 5602, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 99, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8966), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(8970), "Completed", 10578, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1092), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1096), "Failed", 22903, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1111), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1114), "Not_Started", 6523, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 100, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1125), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1125), 18487, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1136), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1140), "Not_Started", 7152, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 100, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1151), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(1154), "In_Progress", 9456, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(1716), new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(1756), 18177, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(4863), new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(4878), "In_Progress", 12114, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(4947), new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(4951), "Not_Started", 19173, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5075), new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5078), 16692 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5100), new DateTime(2019, 3, 23, 23, 12, 51, 372, DateTimeKind.Local).AddTicks(5104), "Failed", 19806, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(297), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(304), "In_Progress", 13408, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(330), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(333), "In_Progress", 7309, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 4, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6817), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6821), 2923, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 4, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6839), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6839), "In_Progress", 22593, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 4, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6850), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6854), "Not_Started", 16402 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 4, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6865), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(6868), "Failed", 10025, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 5, new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(8564), new DateTime(2019, 3, 23, 23, 12, 51, 373, DateTimeKind.Local).AddTicks(8568), 9896, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(307), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(311), "Failed", 18729, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 6, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(329), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(333), "Failed", 11063 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 6, new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(344), new DateTime(2019, 3, 23, 23, 12, 51, 374, DateTimeKind.Local).AddTicks(344), "Not_Started", 2017, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 11, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1827), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1838), 13866, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 11, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1856), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1856), "Completed", 5412, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 11, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1871), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1871), "Not_Started", 6797, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 11, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1882), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1885), 22384, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1896), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1900), "In_Progress", 12370, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1911), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(1911), 3006, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 12, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3632), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3636), "Not_Started", 19249, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3650), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3650), 4822, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3661), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3665), "In_Progress", 9745, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3676), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3680), "Failed", 18633, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3691), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(3691), 11288, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 13, new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(5368), new DateTime(2019, 3, 23, 23, 12, 51, 375, DateTimeKind.Local).AddTicks(5372), 22529, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 16, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(455), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(459), 19592, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2118), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2122), "Failed", 17613, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2133), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2137), "Failed", 4119, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 17, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2148), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2148), "Completed", 22416 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2158), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2162), "Failed", 18049, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 17, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2173), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(2173), "In_Progress", 6998, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4153), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4157), "Completed", 4628, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4168), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4171), "In_Progress", 1807, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4182), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4186), "In_Progress", 18025, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4197), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4197), "Completed", 11683 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4208), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4212), 1173 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 18, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4223), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(4226), "Not_Started", 5606, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5889), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5893), "In_Progress", 4764, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5907), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5907), "Failed", 11963, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5918), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5922), "Not_Started", 13448, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5933), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5933), "In_Progress", 22240, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 19, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5944), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(5947), "Completed", 20071, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7614), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7618), "Failed", 10303, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 20, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7632), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(7632), "In_Progress", 17138, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 21, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9310), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9313), "Failed", 7932 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 21, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9324), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9328), "Not_Started", 3546 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 21, new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9339), new DateTime(2019, 3, 23, 23, 12, 51, 376, DateTimeKind.Local).AddTicks(9339), 5456, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 25, new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(8057), new DateTime(2019, 3, 23, 23, 12, 51, 377, DateTimeKind.Local).AddTicks(8061), "Completed", 8837, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8210), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8218), "Failed", 17519, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 28, new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8236), new DateTime(2019, 3, 23, 23, 12, 51, 378, DateTimeKind.Local).AddTicks(8236), "In_Progress", 7455, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(227), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(235), 22286, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(249), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(249), "In_Progress", 3145, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(260), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(264), "Completed", 7798, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(275), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(278), "Failed", 24280, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 29, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(289), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(289), "Failed", 12331, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 31, new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(4498), new DateTime(2019, 3, 23, 23, 12, 51, 379, DateTimeKind.Local).AddTicks(4501), "In_Progress", 8434, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 35, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3293), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3297), "Completed", 20545 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 35, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3312), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3315), 17734, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 35, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3326), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3330), "Failed", 14978, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 35, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3341), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3341), "Failed", 17211, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 35, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3352), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(3355), "Not_Started", 10530 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete" },
                values: new object[] { 36, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(5128), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(5131), 18764 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6831), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6834), "Completed", 2576, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6915), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6918), "Not_Started", 9807, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6929), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6933), 24402, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6944), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6947), "Failed", 15207, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6958), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6958), "Completed", 14754, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 37, new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6969), new DateTime(2019, 3, 23, 23, 12, 51, 380, DateTimeKind.Local).AddTicks(6973), "Completed", 24092, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2537), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2541), "Failed", 4461, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2552), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2556), 3636, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2567), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2567), "Not_Started", 24501, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 40, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2577), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2581), 7538, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 40, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2592), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(2592), "Completed", 7682 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 41, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(4321), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(4324), "Completed", 2895, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 42, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(6224), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(6228), "Completed", 4582, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9824), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9831), "In_Progress", 16398, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9846), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9846), 6450, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9857), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9861), "Not_Started", 18404, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 44, new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9871), new DateTime(2019, 3, 23, 23, 12, 51, 381, DateTimeKind.Local).AddTicks(9875), "Completed", 17193, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4215), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4404), "Not_Started", 2497, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4419), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4423), "Completed", 15032, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4434), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4437), 14862, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 46, new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4448), new DateTime(2019, 3, 23, 23, 12, 51, 382, DateTimeKind.Local).AddTicks(4448), 7266, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 48, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(830), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(834), 14746, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2493), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2497), "Not_Started", 13575, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2508), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2511), 1245, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2522), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2522), "Completed", 24803, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2533), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2537), "Completed", 6570, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2548), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2548), 16333, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 49, new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2559), new DateTime(2019, 3, 23, 23, 12, 51, 383, DateTimeKind.Local).AddTicks(2562), "In_Progress", 1638, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 54, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(1675), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(1679), "In_Progress", 18256, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 55, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(3305), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(3309), 3874, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 56, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(5110), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(5114), 17988, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6803), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6806), "Failed", 17536, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6821), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6821), "Not_Started", 3470, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6832), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6835), 14194, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6846), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6846), "Not_Started", 24574, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6857), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6861), "Not_Started", 9576, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 57, new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6901), new DateTime(2019, 3, 23, 23, 12, 51, 384, DateTimeKind.Local).AddTicks(6901), "In_Progress", 11843, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(467), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(471), "In_Progress", 15169, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 59, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(486), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(486), "Not_Started", 3052 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(497), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(500), 4995, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 59, new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(511), new DateTime(2019, 3, 23, 23, 12, 51, 385, DateTimeKind.Local).AddTicks(511), 3647, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2731), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2745), "Completed", 24328, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2764), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2764), "Failed", 5110, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 65, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2775), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(2778), "Failed", 6873, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6826), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6830), "Failed", 4870, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6844), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6844), "Not_Started", 20712, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6855), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6859), "Completed", 14201, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6870), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6870), "Failed", 19278, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 67, new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6881), new DateTime(2019, 3, 23, 23, 12, 51, 386, DateTimeKind.Local).AddTicks(6884), 17331, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 69, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(925), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(932), "Not_Started", 18245, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 69, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(947), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(951), "In_Progress", 9434, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2818), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2821), "In_Progress", 2962, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 70, new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2836), new DateTime(2019, 3, 23, 23, 12, 51, 387, DateTimeKind.Local).AddTicks(2840), 14755, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 80, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(4337), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(4341), "In_Progress", 3801, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6193), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6197), "Completed", 3155, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6211), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6211), 11172, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6222), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6226), "In_Progress", 20990, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 81, new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6237), new DateTime(2019, 3, 23, 23, 12, 51, 389, DateTimeKind.Local).AddTicks(6237), "In_Progress", 8411, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(464), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(475), "Not_Started", 12998, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(489), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(493), "Completed", 21550, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 83, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(504), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(504), "Completed", 8659, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2356), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2364), "Not_Started", 23168, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2375), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2378), "Completed", 3366 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2389), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2389), "Failed", 24317 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2400), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2404), 16389, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2415), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2418), 9122, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 84, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2426), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(2429), "Not_Started", 15781, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4216), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4223), "In_Progress", 6907, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4234), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4238), "Completed", 13328, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4245), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4249), "Completed", 13483, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4289), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4293), 22840, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 85, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4304), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(4307), "Failed", 9244, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 86, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(6069), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(6072), "Failed", 10508, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9653), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9657), 9289, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9672), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9675), "Failed", 2103, 10000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9686), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9686), 23164, 3000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 88, new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9697), new DateTime(2019, 3, 23, 23, 12, 51, 390, DateTimeKind.Local).AddTicks(9701), 14725, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 91, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4872), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4875), "Failed", 3252 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4886), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(4890), "Not_Started", 22915, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 93, new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(8289), new DateTime(2019, 3, 23, 23, 12, 51, 391, DateTimeKind.Local).AddTicks(8292), "Not_Started", 21864 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(276), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(280), 8099, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(294), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(294), "Failed", 23507, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 94, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(305), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(309), "Failed", 23460, 7000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2110), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2114), "Not_Started", 24667, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 95, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2125), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(2129), "Completed", 8205, 14500 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3777), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3781), "Not_Started", 7182, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3850), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3850), "In_Progress", 5321, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3864), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3864), 6215, 20000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 96, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3875), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(3879), "Failed", 7426, 18000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 97, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5516), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5520), 15729, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 97, new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5531), new DateTime(2019, 3, 23, 23, 12, 51, 392, DateTimeKind.Local).AddTicks(5535), "Completed", 19919, 8000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "TimeToComplete", "Type" },
                values: new object[] { 101, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2828), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2832), 18753, 1000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete", "Type" },
                values: new object[] { 101, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2847), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2847), "In_Progress", 8523, 4000 });

            migrationBuilder.UpdateData(
                table: "Errands",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ActorId", "CreatedDate", "ModifiedDate", "Status", "TimeToComplete" },
                values: new object[] { 101, new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2857), new DateTime(2019, 3, 23, 23, 12, 51, 393, DateTimeKind.Local).AddTicks(2861), "Completed", 5109 });
        }
    }
}
