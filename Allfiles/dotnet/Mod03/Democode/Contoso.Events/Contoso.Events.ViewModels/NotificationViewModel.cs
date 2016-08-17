using Contoso.Events.Data;
using Contoso.Events.Models;
using Microsoft.Azure.NotificationHubs;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contoso.Events.ViewModels
{
    public class NotificationViewModel
    {
        public NotificationViewModel(string eventKey)
        {
            using (EventsContext context = new EventsContext())
            {
                this.Event = context.Events.SingleOrDefault(e => e.EventKey == eventKey);
            }
        }
        public async Task SendNotification()
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://contosoevents.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=j1toC1FXT/kECuAEzaBuKLOzYT9KXsWKmbXPiKWmddo=", "events");

            String message = String.Format("Event: {0} has been updated.", this.Event.Title);
            
            string toastXml = GetXml();

            toastXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                   "<wp:Toast>" +
                        "<wp:Text1>Hello from a .NET App!</wp:Text1>" +
                   "</wp:Toast> " +
                "</wp:Notification>";

            NotificationOutcome result = await hub.SendMpnsNativeNotificationAsync(toastXml);
        }

        private static string GetXml()
        {
            string toastXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";

            XNamespace wp = "WPNotification";

            toastXml += new XDocument(
                new XElement(wp + "Notification",
                    new XAttribute(XNamespace.Xmlns + "wp", wp),
                        new XElement(wp + "Toast",
                            new XElement(wp + "Text1",
                                "Hello World"
                        )
                    )
                )
            ).ToString();

            return toastXml;
        }

        public Event Event { get; set; }
    }
}