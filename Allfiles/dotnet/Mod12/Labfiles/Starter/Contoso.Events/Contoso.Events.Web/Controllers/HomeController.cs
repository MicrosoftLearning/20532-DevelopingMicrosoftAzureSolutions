using Contoso.Events.Models;
using Contoso.Events.ViewModels;
using Microsoft.ServiceBus;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Mvc;

namespace Contoso.Events.Web.Controllers
{
    public class HomeController : Controller
    {
        private const int EVENTS_GRID_SIZE = 10;
        
        public ActionResult Index()
        {
            UpcomingEventsViewModel viewModel = new UpcomingEventsViewModel();

            return View(viewModel);
        }

        public ActionResult Events(int? id)
        {
            EventsGridViewModel viewModel = new EventsGridViewModel(
                pageSize: EVENTS_GRID_SIZE,
                currentPage: id ?? 1
            );

            return View(viewModel);
        }

        public ActionResult Event(string id)
        {
            EventViewModel viewModel = null;

            if (!String.IsNullOrEmpty(id))
            {
                viewModel = new EventViewModel(
                    eventKey: id
                );
            }

            if (viewModel == null)
            {
                return new HttpNotFoundResult();
            }

            return View(viewModel);
        }

        public ActionResult Register(string id)
        {
            RegisterViewModel viewModel = null;

            if (!String.IsNullOrEmpty(id))
            {
                viewModel = new RegisterViewModel(
                    eventKey: id
                );
            }

            if (viewModel == null)
            {
                return new HttpNotFoundResult();
            }

            return View(viewModel);
        }

        public ActionResult Registered(Guid? id)
        {
            return View(id);
        }

        [ChildActionOnly]
        public ActionResult Hotels()
        {
            HotelsViewModel viewModel = new HotelsViewModel();

            return PartialView("_Hotels", viewModel);
        }
    }
}