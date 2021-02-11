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
    public class IndexModel : PageModel
    {
        private readonly RazorPageMovieDataManager.Data.RazorPageMovieDataManagerContext _context;

        public IndexModel(RazorPageMovieDataManager.Data.RazorPageMovieDataManagerContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
