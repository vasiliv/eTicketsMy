using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicketsMy.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first actor", "Actor 1", "http://dotnethow.net/images/actors/actor-1.jpeg" },
                    { 2, "This is the Bio of the second actor", "Actor 2", "http://dotnethow.net/images/actors/actor-2.jpeg" },
                    { 3, "This is the Bio of the third actor", "Actor 3", "http://dotnethow.net/images/actors/actor-3.jpeg" },
                    { 4, "This is the Bio of the fourth actor", "Actor 4", "http://dotnethow.net/images/actors/actor-4.jpeg" },
                    { 5, "This is the Bio of the fifth actor", "Actor 5", "http://dotnethow.net/images/actors/actor-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Cinema 1" },
                    { 2, "This is the description of the second cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Cinema 2" },
                    { 3, "This is the description of the third cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Cinema 3" },
                    { 4, "This is the description of the fourth cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Cinema 4" },
                    { 5, "This is the description of the fifth cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Cinema 5" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first producer", "Producer 1", "http://dotnethow.net/images/producers/producer-1.jpeg" },
                    { 2, "This is the Bio of the second producer", "Producer 2", "http://dotnethow.net/images/producers/producer-2.jpeg" },
                    { 3, "This is the Bio of the third producer", "Producer 3", "http://dotnethow.net/images/producers/producer-3.jpeg" },
                    { 4, "This is the Bio of the fourth producer", "Producer 4", "http://dotnethow.net/images/producers/producer-4.jpeg" },
                    { 5, "This is the Bio of the fifth producer", "Producer 5", "http://dotnethow.net/images/producers/producer-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 2, 1, "This is the Shawshank Redemption description", new DateTime(2023, 1, 14, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7843), "http://dotnethow.net/images/movies/movie-1.jpeg", 1, "The Shawshank Redemption", 29.5, 1, new DateTime(2023, 1, 11, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7837) },
                    { 3, 1, "This is the Race movie description", new DateTime(2023, 1, 6, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7873), "http://dotnethow.net/images/movies/movie-6.jpeg", 4, "Race", 39.5, 2, new DateTime(2023, 1, 1, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7871) },
                    { 1, 3, "This is the Life movie description", new DateTime(2023, 1, 21, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(6447), "http://dotnethow.net/images/movies/movie-3.jpeg", 4, "Life", 39.5, 3, new DateTime(2023, 1, 1, 19, 9, 48, 375, DateTimeKind.Local).AddTicks(3410) },
                    { 5, 1, "This is the Scoob movie description", new DateTime(2023, 1, 9, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7925), "http://dotnethow.net/images/movies/movie-7.jpeg", 5, "Scoob", 39.5, 3, new DateTime(2023, 1, 1, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7923) },
                    { 4, 4, "This is the Ghost movie description", new DateTime(2023, 1, 18, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7900), "http://dotnethow.net/images/movies/movie-4.jpeg", 6, "Ghost", 39.5, 4, new DateTime(2023, 1, 11, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7899) },
                    { 6, 1, "This is the Cold Soles movie description", new DateTime(2023, 1, 31, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7953), "http://dotnethow.net/images/movies/movie-8.jpeg", 3, "Cold Soles", 39.5, 5, new DateTime(2023, 1, 14, 19, 9, 48, 376, DateTimeKind.Local).AddTicks(7951) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 3, 6 },
                    { 4, 4 },
                    { 3, 4 },
                    { 2, 4 },
                    { 5, 5 },
                    { 4, 5 },
                    { 4, 6 },
                    { 3, 5 },
                    { 3, 1 },
                    { 1, 1 },
                    { 5, 3 },
                    { 2, 3 },
                    { 1, 3 },
                    { 4, 2 },
                    { 2, 5 },
                    { 5, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
