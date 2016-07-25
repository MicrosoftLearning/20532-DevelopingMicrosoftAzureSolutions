using Contoso.Events.Models;
using System.Data.Entity;

namespace Contoso.Events.Data
{
    public class EventsContext : DbContext
    {
        static EventsContext()
        {
            Database.SetInitializer<EventsContext>(new EventsContextInitializer());
        }

        public EventsContext()
            : base("defaultConnection")
        { }

        public DbSet<Event> Events { get; set; }
    }
}