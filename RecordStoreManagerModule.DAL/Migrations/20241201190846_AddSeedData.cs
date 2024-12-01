using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordStoreManagerModule.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "CreatedDate", "Discount", "IsOnSale", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "The Beatles", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "Abbey Road", 19.99m, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Michael Jackson", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, true, "Thriller", 24.99m, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "AC/DC", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "Back in Black", 18.99m, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Pink Floyd", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, true, "Dark Side of the Moon", 22.99m, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Eagles", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "Hotel California", 21.99m, new DateTime(1976, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Bruce Springsteen", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "Born in the USA", 17.99m, new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Fleetwood Mac", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, true, "Rumours", 20.99m, new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Nirvana", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5, true, "Nevermind", 19.99m, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Led Zeppelin", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "Led Zeppelin IV", 25.99m, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Pink Floyd", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5, true, "The Wall", 24.99m, new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Adele", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, true, "21", 20.99m, new DateTime(2011, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Taylor Swift", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "1989", 22.99m, new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Queen", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, true, "A Night at the Opera", 21.99m, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Prince", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, true, "Purple Rain", 19.99m, new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "The Beatles", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "The Beatles (White Album)", 23.99m, new DateTime(1968, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Green Day", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "American Idiot", 18.99m, new DateTime(2004, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Radiohead", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, true, "OK Computer", 20.99m, new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Eminem", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, true, "The Eminem Show", 19.99m, new DateTime(2002, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Linkin Park", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, true, "Hybrid Theory", 20.99m, new DateTime(2000, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Michael Jackson", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "Bad", 22.99m, new DateTime(1987, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Black Sabbath", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5, true, "Paranoid", 20.99m, new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Green Day", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "Dookie", 19.99m, new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Guns N' Roses", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, true, "Appetite for Destruction", 21.99m, new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Sam Smith", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "In the Lonely Hour", 18.99m, new DateTime(2014, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Kendrick Lamar", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, true, "DAMN.", 21.99m, new DateTime(2017, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Drake", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, true, "Take Care", 19.99m, new DateTime(2011, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Lauryn Hill", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5, true, "The Miseducation of Lauryn Hill", 20.99m, new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "U2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, true, "The Joshua Tree", 22.99m, new DateTime(1987, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Taylor Swift", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, "Folklore", 19.99m, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Lorde", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true, "Melodrama", 20.99m, new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
