using Microsoft.EntityFrameworkCore.Migrations;

namespace Bio.Migrations
{
    public partial class oliverBioTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rowID",
                table: "SeatRows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "seatID",
                table: "SeatRows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hallID",
                table: "MovieScreenings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movieID",
                table: "MovieScreenings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "genreID",
                table: "MovieGenres",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movieID",
                table: "MovieGenres",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatRows_rowID",
                table: "SeatRows",
                column: "rowID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatRows_seatID",
                table: "SeatRows",
                column: "seatID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_userID",
                table: "Reservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieScreenings_hallID",
                table: "MovieScreenings",
                column: "hallID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieScreenings_movieID",
                table: "MovieScreenings",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_genreID",
                table: "MovieGenres",
                column: "genreID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_movieID",
                table: "MovieGenres",
                column: "movieID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_genreID",
                table: "MovieGenres",
                column: "genreID",
                principalTable: "Genres",
                principalColumn: "genreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_movieID",
                table: "MovieGenres",
                column: "movieID",
                principalTable: "Movies",
                principalColumn: "movieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieScreenings_Halls_hallID",
                table: "MovieScreenings",
                column: "hallID",
                principalTable: "Halls",
                principalColumn: "hallID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieScreenings_Movies_movieID",
                table: "MovieScreenings",
                column: "movieID",
                principalTable: "Movies",
                principalColumn: "movieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_userID",
                table: "Reservations",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatRows_Rows_rowID",
                table: "SeatRows",
                column: "rowID",
                principalTable: "Rows",
                principalColumn: "rowID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatRows_Seats_seatID",
                table: "SeatRows",
                column: "seatID",
                principalTable: "Seats",
                principalColumn: "seatID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_genreID",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_movieID",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieScreenings_Halls_hallID",
                table: "MovieScreenings");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieScreenings_Movies_movieID",
                table: "MovieScreenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_userID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatRows_Rows_rowID",
                table: "SeatRows");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatRows_Seats_seatID",
                table: "SeatRows");

            migrationBuilder.DropIndex(
                name: "IX_SeatRows_rowID",
                table: "SeatRows");

            migrationBuilder.DropIndex(
                name: "IX_SeatRows_seatID",
                table: "SeatRows");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_userID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_MovieScreenings_hallID",
                table: "MovieScreenings");

            migrationBuilder.DropIndex(
                name: "IX_MovieScreenings_movieID",
                table: "MovieScreenings");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_genreID",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_movieID",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "rowID",
                table: "SeatRows");

            migrationBuilder.DropColumn(
                name: "seatID",
                table: "SeatRows");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "hallID",
                table: "MovieScreenings");

            migrationBuilder.DropColumn(
                name: "movieID",
                table: "MovieScreenings");

            migrationBuilder.DropColumn(
                name: "genreID",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "movieID",
                table: "MovieGenres");
        }
    }
}
