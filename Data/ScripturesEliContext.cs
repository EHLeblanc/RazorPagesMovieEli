using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScripturesEli.Models;
 
namespace RazorPagesMovieEli.Data
{
    public class ScripturesEliContext : DbContext
    {
        public ScripturesEliContext (DbContextOptions<ScripturesEliContext> options)
            : base(options)
        {
        }

        public DbSet<ScripturesEli.Models.Movie> Movie { get; set; } = default!;
    }
}
