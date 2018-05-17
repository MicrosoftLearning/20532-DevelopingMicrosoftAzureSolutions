using Contoso.Events.Models;
using System.Collections.Generic;

namespace Contoso.Events.ViewModels
{
    public class EventsListViewModel
    {
        public IList<Event> Events { get; set; }

        public int LatestEventCount { get; set; }
    }
}