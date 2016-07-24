using Contoso.Events.Data;
using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            // TODO: Module 3 - Exercise 3 - Task 1: Implement Logic to Read Configuration Setting from AppSettings
            this.EventCount = 3;
        }

        public List<Event> Events { get; set; }

        public int EventCount { get; set; }
    }
}