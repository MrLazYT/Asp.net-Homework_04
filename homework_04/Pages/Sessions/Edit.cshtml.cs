using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Sessions
{
    public class EditModel : PageModel
    {
		public int MovieId { get; set; }
		public Session Session { get; set; }

		public void OnGet(int movieId, int sessionId)
		{
			Session = MovieService.GetSessionById(movieId, sessionId);
			MovieId = movieId;
		}

		public IActionResult OnPost(int movieId, int sessionId, Session session)
		{
			Session = session;
			Session.Id = sessionId;

			MovieService.UpdateSession(movieId, Session);

			return RedirectToPage("../Movies/Info", new { id = movieId });
		}
	}
}
