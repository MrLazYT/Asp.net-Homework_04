using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Movies
{
    public class InfoModel : PageModel
    {
        public Movie Movie { get; set; }
        
        public void OnGet(int id)
        {
            Movie = MovieService.GetMovieById(id);
        }

        public IActionResult OnPostDeleteSession(int movieId, int sessionId)
        {
            MovieService.DeleteSessionById(movieId, sessionId);
            Movie = MovieService.GetMovieById(movieId);

            return Page();
        }
    }
}
