using homework_04.Models;
using homework_04.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_04.Pages.Movies
{
    public class InfoModel : PageModel
    {
        public Movie Movie { get; set; }
        public int SessionId { get; set; }

        public void SessionOnClick(int id)
        {
            SessionId = id;
        }

        public void OnGet(int id)
        {
            Movie = MovieService.GetById(id);
        }
    }
}
