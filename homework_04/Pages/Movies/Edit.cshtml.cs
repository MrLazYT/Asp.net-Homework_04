using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Movies
{
	public class EditModel : PageModel
	{
		public Movie Movie { get; set; }

		public void OnGet(int id)
		{
			Movie = MovieService.GetMovieById(id);
		}

		public IActionResult OnPost(int id, Movie movie)
		{
			Movie = movie;
			Movie.Id = id;

			if (String.IsNullOrEmpty(Movie.Title) ||
				String.IsNullOrEmpty(Movie.Poster) ||
				String.IsNullOrEmpty(Movie.Director) ||
				String.IsNullOrEmpty(Movie.Style) ||
				String.IsNullOrEmpty(Movie.ShortDescription))
			{
				return Page();
			}

			MovieService.UpdateMovie(Movie);

			return RedirectToPage("Index");
		}
	}
}
