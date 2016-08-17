using Contoso.Events.Models;
using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Contoso.Events.ViewModels
{
    public class HotelsViewModel
    {
        public HotelsViewModel()
        {
            LoadData();
        }
        private void LoadData()
        {
            List<Hotel> eventsList = new List<Hotel>();

            try
            {
                eventsList.AddRange(GetHotels());
            }
            catch (TimeoutException) { eventsList = null; }
            catch (EndpointNotFoundException) { eventsList = null; }
        }

        private static IEnumerable<Hotel> GetHotels()
        {
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", "sb10978sidney", "lodging");

            ChannelFactory<ILodgingService> cf = new ChannelFactory<ILodgingService>(
                new NetTcpRelayBinding(),
                new EndpointAddress(serviceUri)
            );

            TransportClientEndpointBehavior endpointBehavior = new TransportClientEndpointBehavior();
            endpointBehavior.TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", "f0f/xIwKqxR0IqZHuzsVmLktTTReNOg93qjJ1KUr+kA=");
            cf.Endpoint.EndpointBehaviors.Add(endpointBehavior);

            ILodgingService ch = cf.CreateChannel();
            return ch.GetHotels();
        }

        public List<Hotel> Hotels { get; set; }
    }
}