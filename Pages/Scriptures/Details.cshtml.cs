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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieEli.Data.ScripturesEliContext _context;

        public DetailsModel(RazorPagesMovieEli.Data.ScripturesEliContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
