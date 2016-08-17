using Contoso.Events.ViewModels;
using Contoso.Events.ViewModels.Dynamic;
using Microsoft.Azure;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Contoso.Events.Web.Controllers
{
    public class RegisterController : ApiController
    {
        public dynamic Post(JToken registrationToken)
        {
            dynamic registration = DynamicEntity.GenerateDynamicItem(registrationToken);

            Guid registrationKey = StoreRegistration(registration);

            UpdateEventRegistrationCount(registrationToken);

            if (RoleEnvironment.IsAvailable)
            {
                var response = Request.CreateResponse(HttpStatusCode.Moved);
                var url = Url.Route("Default", new { controller = "Home", action = "Registered", id = registrationKey });
                response.StatusCode = HttpStatusCode.Redirect;
                response.Headers.Location = new Uri(ToAbsoluteUrl(url), UriKind.Absolute);
                return response;
            }
            else
            {
                return RedirectToRoute("Default", new { controller = "Home", action = "Registered", id = registrationKey });
            }
        }

        private Guid StoreRegistration(dynamic registration)
        {
            var storageAccount = Microsoft.WindowsAzure.Storage.CloudStorageAccount.Parse(ConfigurationManager.AppSettings["Microsoft.WindowsAzure.Storage.ConnectionString"]);

            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("EventRegistrations");

            var operation = TableOperation.Insert(registration);
            table.Execute(operation);

            return Guid.Parse(registration.RowKey);
        }

        private void UpdateEventRegistrationCount(JToken registrationToken)
        {
            int eventId = Int32.Parse(registrationToken["Event.Id"].ToString());

            EventIncrementViewModel.IncrementEvent(eventId);
        }

        public string ToAbsoluteUrl(string relativeUrl)
        {
            if (string.IsNullOrEmpty(relativeUrl))
                return relativeUrl;

            if (HttpContext.Current == null)
                return relativeUrl;

            if (relativeUrl.StartsWith("/"))
                relativeUrl = relativeUrl.Insert(0, "~");
            if (!relativeUrl.StartsWith("~/"))
                relativeUrl = relativeUrl.Insert(0, "~/");

            var url = HttpContext.Current.Request.Url;
            var port = url.Port != 80 ? (":" + (url.Port - 1)) : String.Empty;

            return String.Format("{0}://{1}{2}{3}",
                url.Scheme, url.Host, port, VirtualPathUtility.ToAbsolute(relativeUrl));
        }
    }
}