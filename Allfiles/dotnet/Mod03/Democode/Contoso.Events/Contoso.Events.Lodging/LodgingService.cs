using Contoso.Events.Models;
using System;

namespace Contoso.Events.Lodging
{
    public class LodgingService : ILodgingService
    {
        public Hotel[] GetHotels()
        {
            return new Hotel[]
            {
                new Hotel 
                { 
                    Name = "The Ritz-Carlton Golf Resort, Naples", 
                    PhoneNumber = "(239) 593-2000", 
                    Address = "2600 Tiburon Dr, Naples, FL", 
                    Website = "http://www.ritzcarlton.com", 
                    Latitude = 26.249442, 
                    Longitude = -81.76711 
                },
                new Hotel 
                { 
                    Name = "The Hermitage Hotel", 
                    PhoneNumber = "(615) 244-3121", 
                    Address = "231 6th Ave N., Nashville, TN", 
                    Website = "http://www.thehermitagehotel.com", 
                    Latitude = 36.163728,
                    Longitude = -86.782259 
                },
                new Hotel 
                { 
                    Name = "The Fairmont Olympic Hotel", 
                    PhoneNumber = "(206) 621-1700", 
                    Address = "411 University St, Seattle, Washington", 
                    Website = "http://www.fairmont.com", 
                    Latitude = 47.607863,
                    Longitude = -122.333802 
                },
                new Hotel 
                { 
                    Name = "Elysian Hotel Chicago", 
                    PhoneNumber = "(312) 646-1302", 
                    Address = "11 E Walton St, Chicago, IL", 
                    Website = "http://www.waldorfastoriachicagohotel.com ", 
                    Latitude = 41.899993,
                    Longitude = -87.62761  
                }
            };
        }
    }
}