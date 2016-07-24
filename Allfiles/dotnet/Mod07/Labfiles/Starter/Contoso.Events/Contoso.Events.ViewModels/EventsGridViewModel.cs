using Contoso.Events.Data;
using Contoso.Events.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Events.ViewModels
{
    public class EventsGridViewModel
    {
        public EventsGridViewModel(int pageSize, int currentPage)
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;

            using (EventsContext context = new EventsContext())
            {
                this.TotalRows = context.Events.Count();
                this.Events = context.Events.OrderByDescending(e => e.StartTime).Skip(this.PageSize * (this.CurrentPage - 1)).Take(this.PageSize).ToList();
            }
        }

        public int TotalRows { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public IList<Event> Events { get; set; }
    }
}