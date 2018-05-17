using Contoso.Events.Data;
using Contoso.Events.Models;
using Contoso.Events.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Events.Management.Controllers
{
    [Route("[controller]")]
    public class EventsController : Controller
    {
        [HttpGet]
        [Route("{page:int?}", Name = "EventList")]
        public IActionResult Index([FromServices] EventsContext eventsContext, [FromServices] IOptions<ApplicationSettings> appSettings, int? page)
        {
            int currentPage = page ?? 1;
            int totalRows = eventsContext.Events.Count();
            int pageSize = appSettings.Value.GridPageSize;
            var pagedEvents = eventsContext.Events
                .OrderByDescending(e => e.StartTime)
                .Skip(pageSize * (currentPage - 1))
                .Take(pageSize);

            EventsGridViewModel viewModel = new EventsGridViewModel
            {
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalRows = totalRows,
                Events = pagedEvents
            };

            return View(viewModel);
        }

        [HttpGet]
        [Route("detail/{key}", Name = "EventDetail")]
        public IActionResult Detail([FromServices] EventsContext eventsContext, string key)
        {
            var matchedEvent = eventsContext.Events
                .SingleOrDefault(e => e.EventKey == key);

            EventDetailViewModel viewModel = new EventDetailViewModel
            {
                Event = matchedEvent
            };

            return View(viewModel);
        }

        [HttpGet]
        [Route("register/{key}", Name = "EventRegister")]
        public async Task<IActionResult> Register([FromServices] EventsContext eventsContext, [FromServices] RegistrationContext registrationsContext, string key)
        {
            var matchedEvent = await eventsContext.Events.SingleOrDefaultAsync(e => e.EventKey == key);
            var registrationStub = default(GeneralRegistration);
            if (matchedEvent.EventRegistrationType == RegistrationType.Internal)
            {
                registrationStub = new InternalConferenceRegistration { EventKey = matchedEvent.EventKey };
            }
            else if (matchedEvent.EventRegistrationType == RegistrationType.Sales)
            {
                registrationStub = new SalesConferenceRegistration { EventKey = matchedEvent.EventKey };
            }
            else if (matchedEvent.EventRegistrationType == RegistrationType.Technical)
            {
                registrationStub = new TechnicalConferenceRegistration { EventKey = matchedEvent.EventKey };
            }
            else
            {
                registrationStub = new GeneralRegistration { EventKey = matchedEvent.EventKey };
            }

            RegisterViewModel viewModel = new RegisterViewModel
            {
                Event = matchedEvent,
                RegistrationStub = registrationStub
            };

            return View(viewModel);
        }

        [HttpPost]
        [Route("register/{key}", Name = "SubmitRegistration")]
        public async Task<IActionResult> Register([FromServices] EventsContext eventsContext, [FromServices] RegistrationContext registrationsContext, [FromForm] IFormCollection form, string key)
        {
            dynamic registration = new ExpandoObject();
            foreach (var name in form.Keys.Except(new List<string> { "__RequestVerificationToken" }))
                (registration as IDictionary<string, object>)[name.Replace("RegistrationStub.", String.Empty)] = form[name].FirstOrDefault();

            string viewModel = await registrationsContext.UploadEventRegistrationAsync(registration);

            Event eventItem = await eventsContext.Events.SingleOrDefaultAsync(e => e.EventKey == key);
            eventItem.RegistrationCount++;
            await eventsContext.SaveChangesAsync();

            return View("Registered", viewModel);
        }
    }
}