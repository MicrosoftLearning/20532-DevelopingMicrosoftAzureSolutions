using Contoso.Events.Models;
using System.Collections.Generic;

namespace Contoso.Events.ViewModels
{
    public class UpcomingEventsViewModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}