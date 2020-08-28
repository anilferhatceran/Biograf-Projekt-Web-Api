using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class DatabaseContext : DbContext
    {
        // each "table / class" should be defined here if you want the c# to respond to your tables
        public DbSet<Company> Companies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCompany> MovieCompanies { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieScreening> MovieScreenings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatRow> SeatRows { get; set; }
        public DbSet<TicketPrice> TicketPrices { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //Database.
            //Version 2.1 and 2.2
            //Database.EnsureCreated()

            //Version 3.0 ++
            Database.Migrate();
        }
    }
}