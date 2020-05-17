using data.settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.repositories
{
    public class MoviesContext : DbContext
    {
        public MoviesDbSettings MoviesDbSettings { get; set; }
        public MoviesContext(MoviesDbSettings moviesDbSettings)
        {
            MoviesDbSettings = moviesDbSettings;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseCosmos(
                    MoviesDbSettings.Url,
                    MoviesDbSettings.AccountKey,
                    databaseName: MoviesDbSettings.Database);
    }
}
