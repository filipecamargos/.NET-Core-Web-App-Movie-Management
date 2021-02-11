using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMovieDataManager.Models;

namespace RazorPageMovieDataManager.Data
{
    public class RazorPageMovieDataManagerContext : DbContext
    {
        public RazorPageMovieDataManagerContext (DbContextOptions<RazorPageMovieDataManagerContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMovieDataManager.Models.Movie> Movie { get; set; }
    }
}
