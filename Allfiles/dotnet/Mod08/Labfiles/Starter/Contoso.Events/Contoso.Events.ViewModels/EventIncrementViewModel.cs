using Contoso.Events.Data;
using Contoso.Events.Models;
using System;
using System.Linq;

namespace Contoso.Events.ViewModels
{
    public class EventIncrementViewModel
    {
        public static void IncrementEvent(int eventId)
        {
            using (EventsContext context = new EventsContext())
            {
                Event eventItem = context.Events.Single(e => e.Id == eventId);
                eventItem.RegistrationCount++;
                context.SaveChanges();
            }
        }
    }
}