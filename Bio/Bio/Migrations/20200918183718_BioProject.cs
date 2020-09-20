using Microsoft.EntityFrameworkCore.Migrations;

namespace Bio.Migrations
{
    public partial class BioProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    companyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.companyID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    directorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    directorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.directorID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    genreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.genreID);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    hallID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hallNumOfSeats = table.Column<int>(nullable: false),
                    numOfRows = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.hallID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    languageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(nullable: true),
                    languageCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.languageID);
                });

            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    rowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.rowID);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatTaken = table.Column<bool>(nullable: false),
                    seatNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.seatID);
                });

            migrationBuilder.CreateTable(
                name: "TicketPrices",
                columns: table => new
                {
                    ticketPriceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticketName = table.Column<string>(nullable: true),
                    ticketPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPrices", x => x.ticketPriceID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userEmail = table.Column<string>(nullable: true),
                    passwordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieTitle = table.Column<string>(nullable: true),
                    releaseDate = table.Column<string>(nullable: true),
                    movieDesc = table.Column<string>(nullable: true),
                    movieRunTime = table.Column<string>(nullable: true),
                    languageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieID);
                    table.ForeignKey(
                        name: "FK_Movies_Languages_languageID",
                        column: x => x.languageID,
                        principalTable: "Languages",
                        principalColumn: "languageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieCompanies",
                columns: table => new
                {
                    movieCompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieID = table.Column<int>(nullable: true),
                    companyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCompanies", x => x.movieCompanyID);
                    table.ForeignKey(
                        name: "FK_MovieCompanies_Companies_companyID",
                        column: x => x.companyID,
                        principalTable: "Companies",
                        principalColumn: "companyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieCompanies_Movies_movieID",
                        column: x => x.movieID,
                        principalTable: "Movies",
                        principalColumn: "movieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieDirectors",
                columns: table => new
                {
                    movieDirectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieID = table.Column<int>(nullable: true),
                    directorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDirectors", x => x.movieDirectorID);
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Directors_directorID",
                        column: x => x.directorID,
                        principalTable: "Directors",
                        principalColumn: "directorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Movies_movieID",
                        column: x => x.movieID,
                        principalTable: "Movies",
                        principalColumn: "movieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    movieGenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieID = table.Column<int>(nullable: true),
                    genreID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.movieGenreID);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_genreID",
                        column: x => x.genreID,
                        principalTable: "Genres",
                        principalColumn: "genreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_movieID",
                        column: x => x.movieID,
                        principalTable: "Movies",
                        principalColumn: "movieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieScreenings",
                columns: table => new
                {
                    movieScreeningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieID = table.Column<int>(nullable: true),
                    hallID = table.Column<int>(nullable: true),
                    screeningDate = table.Column<string>(nullable: true),
                    screeningStartTime = table.Column<string>(nullable: true),
                    screeningEndTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieScreenings", x => x.movieScreeningID);
                    table.ForeignKey(
                        name: "FK_MovieScreenings_Halls_hallID",
                        column: x => x.hallID,
                        principalTable: "Halls",
                        principalColumn: "hallID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieScreenings_Movies_movieID",
                        column: x => x.movieID,
                        principalTable: "Movies",
                        principalColumn: "movieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatRows",
                columns: table => new
                {
                    seatRowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowID = table.Column<int>(nullable: true),
                    seatID = table.Column<int>(nullable: true),
                    movieScreeningID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatRows", x => x.seatRowID);
                    table.ForeignKey(
                        name: "FK_SeatRows_MovieScreenings_movieScreeningID",
                        column: x => x.movieScreeningID,
                        principalTable: "MovieScreenings",
                        principalColumn: "movieScreeningID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatRows_Rows_rowID",
                        column: x => x.rowID,
                        principalTable: "Rows",
                        principalColumn: "rowID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatRows_Seats_seatID",
                        column: x => x.seatID,
                        principalTable: "Seats",
                        principalColumn: "seatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(nullable: true),
                    seatRowID = table.Column<int>(nullable: true),
                    movieScreeningID = table.Column<int>(nullable: true),
                    priceticketPriceID = table.Column<int>(nullable: true),
                    hallID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservationID);
                    table.ForeignKey(
                        name: "FK_Reservations_Halls_hallID",
                        column: x => x.hallID,
                        principalTable: "Halls",
                        principalColumn: "hallID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_MovieScreenings_movieScreeningID",
                        column: x => x.movieScreeningID,
                        principalTable: "MovieScreenings",
                        principalColumn: "movieScreeningID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_TicketPrices_priceticketPriceID",
                        column: x => x.priceticketPriceID,
                        principalTable: "TicketPrices",
                        principalColumn: "ticketPriceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_SeatRows_seatRowID",
                        column: x => x.seatRowID,
                        principalTable: "SeatRows",
                        principalColumn: "seatRowID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCompanies_companyID",
                table: "MovieCompanies",
                column: "companyID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCompanies_movieID",
                table: "MovieCompanies",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirectors_directorID",
                table: "MovieDirectors",
                column: "directorID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirectors_movieID",
                table: "MovieDirectors",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_genreID",
                table: "MovieGenres",
                column: "genreID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_movieID",
                table: "MovieGenres",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_languageID",
                table: "Movies",
                column: "languageID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieScreenings_hallID",
                table: "MovieScreenings",
                column: "hallID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieScreenings_movieID",
                table: "MovieScreenings",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_hallID",
                table: "Reservations",
                column: "hallID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_movieScreeningID",
                table: "Reservations",
                column: "movieScreeningID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_priceticketPriceID",
                table: "Reservations",
                column: "priceticketPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_seatRowID",
                table: "Reservations",
                column: "seatRowID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_userID",
                table: "Reservations",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatRows_movieScreeningID",
                table: "SeatRows",
                column: "movieScreeningID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatRows_rowID",
                table: "SeatRows",
                column: "rowID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatRows_seatID",
                table: "SeatRows",
                column: "seatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCompanies");

            migrationBuilder.DropTable(
                name: "MovieDirectors");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "TicketPrices");

            migrationBuilder.DropTable(
                name: "SeatRows");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MovieScreenings");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
