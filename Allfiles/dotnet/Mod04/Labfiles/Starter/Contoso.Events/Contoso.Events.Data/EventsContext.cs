using Contoso.Events.Models;
using System.Configuration;
using System.Data.Entity;

namespace Contoso.Events.Data
{
    public class EventsContext : DbContext
    {
        static EventsContext()
        {

        }

        public EventsContext()
            : base("EventsContextConnectionString")
        {
            Database.CommandTimeout = int.Parse(ConfigurationManager.AppSettings["Consoso.Events.Data.CommandTimeoutInSeconds"]);
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<SignInDocument> SignInDocuments { get; set; }
    }
}