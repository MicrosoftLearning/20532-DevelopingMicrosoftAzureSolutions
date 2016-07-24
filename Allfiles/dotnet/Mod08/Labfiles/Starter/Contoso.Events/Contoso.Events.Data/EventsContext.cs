using Contoso.Events.Models;
using System.Data.Entity;
using System.Linq;

namespace Contoso.Events.Data
{
    public class EventsContext : DbContext
    {
        static EventsContext()
        {
            Database.SetInitializer<EventsContext>(new EventsContextInitializer());
        }

        public EventsContext()
            : base("EventsContextConnectionString")
        { }

        public DbSet<Event> Events { get; set; }
    }
}