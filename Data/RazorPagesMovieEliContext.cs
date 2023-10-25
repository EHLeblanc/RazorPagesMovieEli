using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieEli.Models;

namespace RazorPagesMovieEli.Data
{
    public class RazorPagesMovieEliContext : DbContext
    {
        public RazorPagesMovieEliContext (DbContextOptions<RazorPagesMovieEliContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieEli.Models.Movie> Movie { get; set; } = default!;
    }
}
