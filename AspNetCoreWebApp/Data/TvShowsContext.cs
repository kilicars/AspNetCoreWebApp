using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApp.Models
{
    public class TvShowsContext : DbContext
    {
        public TvShowsContext (DbContextOptions<TvShowsContext> options)
            : base(options)
        {
        }

        public DbSet<TvShow> TvShow { get; set; }
    }
}
