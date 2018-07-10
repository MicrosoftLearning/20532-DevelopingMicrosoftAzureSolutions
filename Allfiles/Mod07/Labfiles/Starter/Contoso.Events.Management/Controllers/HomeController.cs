using Contoso.Events.Data;
using Contoso.Events.Models;
using Contoso.Events.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Events.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string PROCESSING_URI = "uri://processing";

        [HttpGet]
        [Route("", Name = "Home")]
        public async Task<IActionResult> Index([FromServices] EventsContext eventsContext, [FromServices] IOptions<ApplicationSettings> settings)
        {
            var events = await eventsContext.Events.OrderBy(e => e.StartTime).Take(settings.Value.LatestEventCount).ToListAsync<Event>();

            EventsListViewModel viewModel = new EventsListViewModel
            {
                Events = events,
                LatestEventCount = settings.Value.LatestEventCount
            };

            return View(viewModel);
        }

        [HttpGet]
        [Route("{id}", Name = "SignIn")]
        public async Task<IActionResult> SignIn([FromServices] EventsContext eventsContext, [FromServices] BlobContext blobContext, int id)
        {
            var eventItem = await eventsContext.Events.SingleOrDefaultAsync(e => e.Id == id);

            SignInSheetState signInSheetState = default(SignInSheetState);

            if (String.IsNullOrEmpty(eventItem.SignInDocumentUrl))
            {
                using (Stream stream = new MemoryStream())
                {
                    await blobContext.UploadBlobAsync($"{eventItem.EventKey}.docx", stream);
                }
                eventItem.SignInDocumentUrl = PROCESSING_URI;
                await eventsContext.SaveChangesAsync();
                signInSheetState = SignInSheetState.SignInDocumentProcessing;
            }
            else if (eventItem.SignInDocumentUrl == PROCESSING_URI)
            {
                signInSheetState = SignInSheetState.SignInDocumentProcessing;
            }
            else
            {
                signInSheetState = SignInSheetState.SignInDocumentAlreadyExists;
            }

            SignInSheetViewModel viewModel = new SignInSheetViewModel
            {
                Event = eventItem,
                SignInSheetState = signInSheetState
            };

            return View(viewModel);
        }

        [HttpGet]
        [Route("{id}/download/{blob}", Name = "SignInDownload")]
        public async Task<ActionResult> DownloadSignIn([FromServices] BlobContext blobContext, string id, string blob)
        {
            string blobName = $"{blob}";
            DownloadPayload blobData = await blobContext.GetStreamAsync(blobName);

            return File(blobData.Stream, blobData.ContentType, blobName);
        }

        [HttpGet]
        [Route("{id}/link/{blob}", Name = "SignInLink")]
        public async Task<ActionResult> GetSignInUrl([FromServices] BlobContext blobContext, string id, string blob)
        {
            string blobName = $"{blob}";
            string blobUrl = await blobContext.GetSecureUrlAsync(blobName);

            return Redirect(blobUrl);
        }
    }
}
