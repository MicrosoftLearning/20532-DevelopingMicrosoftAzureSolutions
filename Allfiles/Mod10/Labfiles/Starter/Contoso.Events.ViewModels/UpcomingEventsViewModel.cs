using Contoso.Events.Models;
using System.Collections.Generic;

namespace Contoso.Events.ViewModels
{
    public class UpcomingEventsViewModel
    {
        public IList<Event> Events { get; set; }
    }
}