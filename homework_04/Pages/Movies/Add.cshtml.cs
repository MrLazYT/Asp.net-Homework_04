using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Movies
{
    public class AddModel : PageModel
    {
        public Movie Movie { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(Movie movie)
        {
            Movie = movie;

            if (String.IsNullOrEmpty(Movie.Title) ||
                String.IsNullOrEmpty(Movie.Poster) ||
                String.IsNullOrEmpty(Movie.Director) ||
                String.IsNullOrEmpty(Movie.Style) ||
                String.IsNullOrEmpty(Movie.ShortDescription))
            {
                return Page();
            }

            MovieService.AddMovie(Movie);
                
            return RedirectToPage("Index");
        }
    }
}
