﻿// <auto-generated />
using System;
using Bio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bio.Migrations
{
    [DbContext(typeof(DatabaseContext))]
<<<<<<< HEAD:Bio/Bio/Migrations/20200918183718_BioProject.Designer.cs
    [Migration("20200918183718_BioProject")]
    partial class BioProject
=======
    [Migration("20200920212406_bio")]
    partial class bio
>>>>>>> 48dc7b452f9d7d50e872ce58fce785dbd24ae739:Bio/Bio/Migrations/20200920212406_bio.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bio.Models.Company", b =>
                {
                    b.Property<int>("companyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("companyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Bio.Models.Director", b =>
                {
                    b.Property<int>("directorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("directorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("directorID");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Bio.Models.Genre", b =>
                {
                    b.Property<int>("genreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("genreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Bio.Models.Hall", b =>
                {
                    b.Property<int>("hallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("hallNumOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("numOfRows")
                        .HasColumnType("int");

                    b.HasKey("hallID");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("Bio.Models.Language", b =>
                {
                    b.Property<int>("languageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("languageCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("languageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("languageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Bio.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("languageID")
                        .HasColumnType("int");

                    b.Property<string>("movieDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movieRunTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movieTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("releaseDate")
<<<<<<< HEAD:Bio/Bio/Migrations/20200918183718_BioProject.Designer.cs
=======
                        .IsRequired()
>>>>>>> 48dc7b452f9d7d50e872ce58fce785dbd24ae739:Bio/Bio/Migrations/20200920212406_bio.Designer.cs
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("movieID");

                    b.HasIndex("languageID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Bio.Models.MovieCompany", b =>
                {
                    b.Property<int>("movieCompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("companyID")
                        .HasColumnType("int");

                    b.Property<int?>("movieID")
                        .HasColumnType("int");

                    b.HasKey("movieCompanyID");

                    b.HasIndex("companyID");

                    b.HasIndex("movieID");

                    b.ToTable("MovieCompanies");
                });

            modelBuilder.Entity("Bio.Models.MovieDirector", b =>
                {
                    b.Property<int>("movieDirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("directorID")
                        .HasColumnType("int");

                    b.Property<int?>("movieID")
                        .HasColumnType("int");

                    b.HasKey("movieDirectorID");

                    b.HasIndex("directorID");

                    b.HasIndex("movieID");

                    b.ToTable("MovieDirectors");
                });

            modelBuilder.Entity("Bio.Models.MovieGenre", b =>
                {
                    b.Property<int>("movieGenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("genreID")
                        .HasColumnType("int");

                    b.Property<int?>("movieID")
                        .HasColumnType("int");

                    b.HasKey("movieGenreID");

                    b.HasIndex("genreID");

                    b.HasIndex("movieID");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("Bio.Models.MovieScreening", b =>
                {
                    b.Property<int>("movieScreeningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("hallID")
                        .HasColumnType("int");

                    b.Property<int?>("movieID")
                        .HasColumnType("int");

                    b.Property<string>("screeningDate")
<<<<<<< HEAD:Bio/Bio/Migrations/20200918183718_BioProject.Designer.cs
=======
                        .IsRequired()
>>>>>>> 48dc7b452f9d7d50e872ce58fce785dbd24ae739:Bio/Bio/Migrations/20200920212406_bio.Designer.cs
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("screeningEndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("screeningStartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("movieScreeningID");

                    b.HasIndex("hallID");

                    b.HasIndex("movieID");

                    b.ToTable("MovieScreenings");
                });

            modelBuilder.Entity("Bio.Models.Reservation", b =>
                {
                    b.Property<int>("reservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("hallID")
                        .HasColumnType("int");

                    b.Property<int?>("movieScreeningID")
                        .HasColumnType("int");

                    b.Property<int?>("priceticketPriceID")
                        .HasColumnType("int");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("reservationID");

                    b.HasIndex("hallID");

                    b.HasIndex("movieScreeningID");

                    b.HasIndex("priceticketPriceID");

                    b.HasIndex("userID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Bio.Models.Row", b =>
                {
                    b.Property<int>("rowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("rowNumber")
                        .HasColumnType("int");

                    b.HasKey("rowID");

                    b.ToTable("Rows");
                });

            modelBuilder.Entity("Bio.Models.Seat", b =>
                {
                    b.Property<int>("seatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("seatNumber")
                        .HasColumnType("int");

                    b.Property<bool>("seatTaken")
                        .HasColumnType("bit");

                    b.HasKey("seatID");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Bio.Models.SeatRow", b =>
                {
                    b.Property<int>("seatRowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("movieScreeningID")
                        .HasColumnType("int");

                    b.Property<int?>("rowID")
                        .HasColumnType("int");

                    b.Property<int?>("seatID")
                        .HasColumnType("int");

                    b.HasKey("seatRowID");

                    b.HasIndex("movieScreeningID");

                    b.HasIndex("rowID");

                    b.HasIndex("seatID");

                    b.ToTable("SeatRows");
                });

            modelBuilder.Entity("Bio.Models.TicketPrice", b =>
                {
                    b.Property<int>("ticketPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ticketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ticketPrice")
                        .HasColumnType("real");

                    b.HasKey("ticketPriceID");

                    b.ToTable("TicketPrices");
                });

            modelBuilder.Entity("Bio.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

<<<<<<< HEAD:Bio/Bio/Migrations/20200918183718_BioProject.Designer.cs
                    b.Property<string>("passwordHash")
=======
                    b.Property<string>("password")
                        .IsRequired()
>>>>>>> 48dc7b452f9d7d50e872ce58fce785dbd24ae739:Bio/Bio/Migrations/20200920212406_bio.Designer.cs
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bio.Models.Movie", b =>
                {
                    b.HasOne("Bio.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageID");
                });

            modelBuilder.Entity("Bio.Models.MovieCompany", b =>
                {
                    b.HasOne("Bio.Models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyID");

                    b.HasOne("Bio.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieID");
                });

            modelBuilder.Entity("Bio.Models.MovieDirector", b =>
                {
                    b.HasOne("Bio.Models.Director", "director")
                        .WithMany()
                        .HasForeignKey("directorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bio.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieID");
                });

            modelBuilder.Entity("Bio.Models.MovieGenre", b =>
                {
                    b.HasOne("Bio.Models.Genre", "genre")
                        .WithMany()
                        .HasForeignKey("genreID");

                    b.HasOne("Bio.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieID");
                });

            modelBuilder.Entity("Bio.Models.MovieScreening", b =>
                {
                    b.HasOne("Bio.Models.Hall", "hall")
                        .WithMany()
                        .HasForeignKey("hallID");

                    b.HasOne("Bio.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieID");
                });

            modelBuilder.Entity("Bio.Models.Reservation", b =>
                {
                    b.HasOne("Bio.Models.Hall", "hall")
                        .WithMany()
                        .HasForeignKey("hallID");

                    b.HasOne("Bio.Models.MovieScreening", "movieScreening")
                        .WithMany()
                        .HasForeignKey("movieScreeningID");

                    b.HasOne("Bio.Models.TicketPrice", "price")
                        .WithMany()
                        .HasForeignKey("priceticketPriceID");

                    b.HasOne("Bio.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("Bio.Models.SeatRow", b =>
                {
                    b.HasOne("Bio.Models.MovieScreening", "movieScreening")
                        .WithMany()
                        .HasForeignKey("movieScreeningID");

                    b.HasOne("Bio.Models.Row", "row")
                        .WithMany()
                        .HasForeignKey("rowID");

                    b.HasOne("Bio.Models.Seat", "seat")
                        .WithMany()
                        .HasForeignKey("seatID");
                });
#pragma warning restore 612, 618
        }
    }
}
