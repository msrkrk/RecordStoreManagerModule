using Microsoft.EntityFrameworkCore;
using RecordStoreManagerModule.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.211.55.2;database=RecordStoreManagerModuleDb;user id=sa;password=Qwq1234.;trustservercertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                 new Album { Id = 1, Name = "Abbey Road", Artist = "The Beatles", ReleaseDate = new DateTime(1969, 9, 26), IsOnSale = true, Discount = 10.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 2, Name = "Thriller", Artist = "Michael Jackson", ReleaseDate = new DateTime(1982, 11, 30), IsOnSale = true, Discount = 15.0, Price = 24.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 3, Name = "Back in Black", Artist = "AC/DC", ReleaseDate = new DateTime(1980, 7, 25), IsOnSale = false, Discount = 0.0, Price = 18.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 4, Name = "Dark Side of the Moon", Artist = "Pink Floyd", ReleaseDate = new DateTime(1973, 3, 1), IsOnSale = true, Discount = 20.0, Price = 22.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 5, Name = "Hotel California", Artist = "Eagles", ReleaseDate = new DateTime(1976, 12, 8), IsOnSale = true, Discount = 10.0, Price = 21.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 6, Name = "Born in the USA", Artist = "Bruce Springsteen", ReleaseDate = new DateTime(1984, 6, 4), IsOnSale = false, Discount = 0.0, Price = 17.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 7, Name = "Rumours", Artist = "Fleetwood Mac", ReleaseDate = new DateTime(1977, 2, 4), IsOnSale = true, Discount = 5.0, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 8, Name = "Nevermind", Artist = "Nirvana", ReleaseDate = new DateTime(1991, 9, 24), IsOnSale = true, Discount = 12.5, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 9, Name = "Led Zeppelin IV", Artist = "Led Zeppelin", ReleaseDate = new DateTime(1971, 11, 8), IsOnSale = false, Discount = 0.0, Price = 25.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 10, Name = "The Wall", Artist = "Pink Floyd", ReleaseDate = new DateTime(1979, 11, 30), IsOnSale = true, Discount = 7.5, Price = 24.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 11, Name = "21", Artist = "Adele", ReleaseDate = new DateTime(2011, 1, 24), IsOnSale = true, Discount = 5.0, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 12, Name = "1989", Artist = "Taylor Swift", ReleaseDate = new DateTime(2014, 10, 27), IsOnSale = true, Discount = 10.0, Price = 22.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 13, Name = "A Night at the Opera", Artist = "Queen", ReleaseDate = new DateTime(1975, 11, 21), IsOnSale = true, Discount = 15.0, Price = 21.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 14, Name = "Purple Rain", Artist = "Prince", ReleaseDate = new DateTime(1984, 6, 25), IsOnSale = true, Discount = 5.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 15, Name = "The Beatles (White Album)", Artist = "The Beatles", ReleaseDate = new DateTime(1968, 11, 22), IsOnSale = true, Discount = 10.0, Price = 23.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 16, Name = "American Idiot", Artist = "Green Day", ReleaseDate = new DateTime(2004, 9, 21), IsOnSale = false, Discount = 0.0, Price = 18.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 17, Name = "OK Computer", Artist = "Radiohead", ReleaseDate = new DateTime(1997, 5, 21), IsOnSale = true, Discount = 8.0, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 18, Name = "The Eminem Show", Artist = "Eminem", ReleaseDate = new DateTime(2002, 5, 26), IsOnSale = true, Discount = 12.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 19, Name = "Hybrid Theory", Artist = "Linkin Park", ReleaseDate = new DateTime(2000, 10, 24), IsOnSale = true, Discount = 5.0, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 20, Name = "Bad", Artist = "Michael Jackson", ReleaseDate = new DateTime(1987, 8, 31), IsOnSale = true, Discount = 10.0, Price = 22.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 21, Name = "Paranoid", Artist = "Black Sabbath", ReleaseDate = new DateTime(1970, 9, 18), IsOnSale = true, Discount = 7.5, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 22, Name = "Dookie", Artist = "Green Day", ReleaseDate = new DateTime(1994, 2, 1), IsOnSale = false, Discount = 0.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 23, Name = "Appetite for Destruction", Artist = "Guns N' Roses", ReleaseDate = new DateTime(1987, 7, 21), IsOnSale = true, Discount = 15.0, Price = 21.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 24, Name = "In the Lonely Hour", Artist = "Sam Smith", ReleaseDate = new DateTime(2014, 5, 26), IsOnSale = true, Discount = 10.0, Price = 18.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 25, Name = "DAMN.", Artist = "Kendrick Lamar", ReleaseDate = new DateTime(2017, 4, 14), IsOnSale = true, Discount = 5.0, Price = 21.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 26, Name = "Take Care", Artist = "Drake", ReleaseDate = new DateTime(2011, 11, 15), IsOnSale = true, Discount = 8.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 27, Name = "The Miseducation of Lauryn Hill", Artist = "Lauryn Hill", ReleaseDate = new DateTime(1998, 8, 25), IsOnSale = true, Discount = 12.5, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 28, Name = "The Joshua Tree", Artist = "U2", ReleaseDate = new DateTime(1987, 3, 9), IsOnSale = true, Discount = 7.0, Price = 22.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 29, Name = "Folklore", Artist = "Taylor Swift", ReleaseDate = new DateTime(2020, 7, 24), IsOnSale = false, Discount = 0.0, Price = 19.99M, CreatedDate = new DateTime(2024, 12, 01) },
                 new Album { Id = 30, Name = "Melodrama", Artist = "Lorde", ReleaseDate = new DateTime(2017, 6, 16), IsOnSale = true, Discount = 10.0, Price = 20.99M, CreatedDate = new DateTime(2024, 12, 01) }
             );
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();

            ChangeTracker.Clear();

            return result;
        }
    }
}
