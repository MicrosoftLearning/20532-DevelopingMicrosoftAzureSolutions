using Contoso.Events.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contoso.Events.Management.Controllers
{
    public class HomeController : Controller
    {
        EventsListViewModel viewModel = new EventsListViewModel();

        public ActionResult Index()
        {
            return View(viewModel);
        }

        public ActionResult Events()
        {
            return View(viewModel);
        }
    }
}