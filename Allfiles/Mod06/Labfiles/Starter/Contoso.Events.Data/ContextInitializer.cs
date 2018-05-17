using Bogus;
using Contoso.Events.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Events.Data
{
    public class ContextInitializer
    {
        private int _eventCount = 15;

        public async Task InitializeAsync(EventsContext eventsContext, RegistrationContext registrationContext)
        {
            await eventsContext.Database.EnsureCreatedAsync();
            await registrationContext.ConfigureConnectionAsync();

            List<Event> events = new List<Event>();
            if (await eventsContext.Events.AnyAsync())
            {
                events = await eventsContext.Events.ToListAsync();
            }
            else
            {
                events = GenerateEvents();
                await eventsContext.Events.AddRangeAsync(events);
                await eventsContext.SaveChangesAsync();
            }

            if (await registrationContext.GetRegistrantCountAsync() == 0)
            {
                List<GeneralRegistration> registrations = GenerateRegistrants(events);
                foreach (var registrant in registrations)
                {
                    await registrationContext.UploadEventRegistrationAsync(registrant);
                }
            }
        }

        private List<Event> GenerateEvents()
        {
            return new Faker<Event>().Rules((f, e) =>
            {
                e.StartTime = f.Date.Future(3).Date.AddHours(f.Random.Number(8, 10));
                e.EndTime = e.StartTime.AddHours(f.Random.Number(19) / 2.0);
                e.EventRegistrationType = f.Random.Enum<RegistrationType>();
                e.Title = $"{e.StartTime:yyyy} {e.StartTime:MMMM} {e.EventRegistrationType.ToString()} Conference";
                e.EventKey = $"fy{e.Title.Replace(" ", String.Empty).ToLower()}{f.UniqueIndex:00}".Replace("fy20", "fy");
                e.RegistrationCount = f.Random.Bool(0.25f) ? 0 : f.Random.Number(0, 5);
                e.Description = f.Lorem.Sentences(f.Random.Number(2, 5));
                e.Latitude = f.Address.Latitude(35.21445, 43.72547);
                e.Longitude = f.Address.Longitude(-118.49088, -80.41048);
            }
            ).Generate(_eventCount).ToList<Event>();
        }

        private List<GeneralRegistration> GenerateRegistrants(IEnumerable<Event> events)
        {
            return events
                .SelectMany(e => Enumerable.Range(0, e.RegistrationCount).Select(x => e.EventKey))
                .Select(k =>
                        new Faker<GeneralRegistration>().Rules((f, e) =>
                        {
                            e.FirstName = f.Name.FirstName();
                            e.LastName = f.Name.LastName();
                            e.EventKey = k;
                        }
                        ).Generate()
                ).ToList<GeneralRegistration>();
        }
    }
}