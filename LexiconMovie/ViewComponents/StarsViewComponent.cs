using LexiconMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovie.ViewComponents
{
    public class StarsViewComponent : ViewComponent
    {
        private readonly LexiconMovieContext context;

        public StarsViewComponent(LexiconMovieContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            var movie = await context.Movie.FindAsync(movieId);

            var doubleRating = (int)Math.Round(movie.Rating * 2);

            var model = new StarsViewModel
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };

            return View(model);

        }
    }
}
