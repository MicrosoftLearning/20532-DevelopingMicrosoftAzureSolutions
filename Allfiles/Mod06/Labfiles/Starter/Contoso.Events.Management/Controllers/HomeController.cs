using Contoso.Events.Data;
using Contoso.Events.Models;
using Contoso.Events.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Events.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("", Name = "Home")]
        public async Task<IActionResult> Index([FromServices] EventsContext eventsContext, [FromServices] IOptions<ApplicationSettings> settings)
        {
            var events = await eventsContext.Events.OrderBy(e => e.StartTime).Take(settings.Value.LatestEventCount).ToListAsync<Event>();

            EventsListViewModel viewModel = new EventsListViewModel
            {
                Events = events,
                LatestEventCount = settings.Value.LatestEventCount
            };

            return View(viewModel);
        }
    }
}