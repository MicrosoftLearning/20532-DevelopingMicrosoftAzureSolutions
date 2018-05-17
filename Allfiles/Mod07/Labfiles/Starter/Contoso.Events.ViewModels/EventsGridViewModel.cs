using Contoso.Events.Models;
using System.Collections.Generic;

namespace Contoso.Events.ViewModels
{
    public class EventsGridViewModel
    {
        public int TotalRows { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}