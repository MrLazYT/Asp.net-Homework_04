using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Movies
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = MovieService.GetAllMovies();
        }

        public IActionResult OnPostSearch(string searchValue)
        {
            if (searchValue == null)
            {
                Movies = MovieService.GetAllMovies();

                return Page();
            }

            Movies = MovieService.FindMovieByTitle(searchValue);

            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            Movies = MovieService.GetAllMovies();

            MovieService.DeleteMovieById(id);

            return Page();
        }
    }
}
