using Contoso.Events.Data;
using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.ViewModels
{
    public class UpcomingEventsViewModel
    {
        public UpcomingEventsViewModel()
        {
            using (EventsContext context = new EventsContext())
            {
                this.Events = context.Events
                    .Where(e => e.StartTime >= DateTime.Today)
                    .OrderBy(e => e.StartTime)
                    .Take(CloudSettings.LatestEventsCount)
                    .ToList<Event>();
            }
        }

        public IList<Event> Events { get; set; }
    }
}