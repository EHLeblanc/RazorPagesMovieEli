using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieEli.Data;
using RazorPagesMovieEli.Models;

namespace RazorPagesMovieEli.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieEli.Data.RazorPagesMovieEliContext _context;

        public IndexModel(RazorPagesMovieEli.Data.RazorPagesMovieEliContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
