using Contoso.Events.Models;
using Contoso.Events.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Contoso.Events.Management.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {
            EventsListViewModel viewModel = new EventsListViewModel();

            return View(viewModel);
        }

        public ActionResult SignIn(string id)
        {
            SignInSheetViewModel viewModel = null;

            if (!String.IsNullOrEmpty(id))
            {
                viewModel = new SignInSheetViewModel(
                    eventKey: id
                );
            }

            if (viewModel == null)
            {
                return new HttpNotFoundResult();
            }

            return View(viewModel);
        }

        public async Task<ActionResult> DownloadSignIn(string id)
        {
            string filename = String.Format("{0}.docx", id);

            DownloadViewModel viewModel = new DownloadViewModel(
                blobId: filename
            );

            DownloadPayload blobData = await viewModel.GetStream();

            return File(blobData.Stream, blobData.ContentType, filename);
        }

        public async Task<ActionResult> GetSignInUrl(string id)
        {
            string filename = String.Format("{0}.docx", id);

            DownloadViewModel viewModel = new DownloadViewModel(
                blobId: filename
            );

            string blobUrl = await viewModel.GetSecureUrl();

            return Redirect(blobUrl);
        }

        public async Task<ActionResult> Notify(string id)
        {
            NotificationViewModel viewModel = new NotificationViewModel(
                eventKey: id
            );

            await viewModel.SendNotification();

            return RedirectToAction("Events");
        }
    }
}