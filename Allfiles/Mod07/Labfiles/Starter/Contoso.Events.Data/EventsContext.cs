using Contoso.Events.Models;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Events.Data
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options) 
            : base(options)
        { }

        public DbSet<Event> Events { get; set; }
    }
}