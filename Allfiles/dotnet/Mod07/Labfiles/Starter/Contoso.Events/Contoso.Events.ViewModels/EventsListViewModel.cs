using Contoso.Events.Data;
using Contoso.Events.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Events.ViewModels
{
    public class EventsListViewModel
    {
        public EventsListViewModel()
        {
            using (EventsContext context = new EventsContext())
            {
                this.Events = context.Events.OrderBy(e => e.StartTime).ToList();
            }
        }

        public List<Event> Events { get; set; }
    }
}