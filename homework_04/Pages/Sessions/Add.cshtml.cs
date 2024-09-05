using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace homework_04.Pages.Sessions
{
    public class AddModel : PageModel
    {
        public Movie Movie { get; set; }
        public Session Session { get; set; }

        public void OnGet(int id)
        {
            Movie = MovieService.GetMovieById(id);
        }

        public IActionResult OnPost(int movieId, Session session)
        {
            Movie = MovieService.GetMovieById(movieId);

            List<Session> sessions = Movie.Sessions; 
            int sessionsCount = sessions.Count;
            int lastSessionIndex = sessionsCount - 1;
            Session lastSession = sessions[lastSessionIndex];
            int lastSessionId = lastSession.Id;
            int id = sessionsCount + 1;

            if (id == lastSessionId)
            {
                id = lastSessionId + 1;
            }

            Session = session;
            Session.Id = id;

            MovieService.AddSession(Movie.Id, Session);

            return RedirectToPage("../Movies/Info", new { id = Movie.Id });
        }
    }
}