using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovieDataManager.Data;
using RazorPageMovieDataManager.Models;

namespace RazorPageMovieDataManager.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageMovieDataManager.Data.RazorPageMovieDataManagerContext _context;

        public DetailsModel(RazorPageMovieDataManager.Data.RazorPageMovieDataManagerContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
