using Contoso.Events.Models;
using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.Lodging
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Contoso.Events.Lodging program hosts the LodgingService WCF service
            ServiceHost sh = new ServiceHost(typeof(LodgingService));

            sh.AddServiceEndpoint(
               typeof(ILodgingService), new NetTcpBinding(),
               "net.tcp://localhost:8000/lodging");

            // -------------------------------------
            // Add additional service endpoints here
            // -------------------------------------

            //sh.AddServiceEndpoint(
            //   typeof(ILodgingService), new NetTcpRelayBinding(),
            //   ServiceBusEnvironment.CreateServiceUri("sb", "sb20532jadams", "lodging"))
            //    .Behaviors.Add(new TransportClientEndpointBehavior
            //    {
            //        TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "<your access key here>")
            //    });

            sh.Open();

            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();

            sh.Close();
        }
    }
}
