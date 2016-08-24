using Contoso.Events.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;

namespace Contoso.Events.Data.Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);

            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("EventRegistrations");

            table.CreateIfNotExists();

            List<Registration> registrationList = new List<Registration>();

            using (EventsContext context = new EventsContext())
            {
                context.Database.Delete();
            }

            using (EventsContext context = new EventsContext())
            {
                context.Events.RemoveRange(context.Events);
                context.SaveChanges();

                for (int i = 0; i < 55; i++)
                {
                    var result = CreateEvent(context);
                    registrationList.AddRange(result);
                }
            }

            registrationList = registrationList.OrderBy(r => rand.Next()).ToList();

            foreach (var registrationGroup in registrationList.GroupBy(r => r.PartitionKey))
            {
                TableBatchOperation operation = new TableBatchOperation();
                foreach (var registration in registrationGroup)
                {
                    operation.Insert(registration);
                }
                table.ExecuteBatch(operation);
            }
        }

        public static Random rand = new Random();
        public static List<KeyValuePair<double, double>> latLongs = new Dictionary<double, double> { { 27.9314, -82.48298 }, { 34.079206, -118.361715 }, { 37.773684, -122.421544 }, { 29.929328, -90.084279 }, { 40.768607, -73.982946 }, { 40.743787, -74.007527 }, { 37.879672, -122.269001 }, { 41.913445, -87.648196 }, { 29.942228, -90.067237 }, { 41.884197, -87.647992 }, { 38.404439, -122.364939 }, { 40.743434, -89.573131 }, { 39.166521, -86.533099 }, { 39.764834, -86.159806 }, { 41.499668, -81.69897 }, { 41.964645, -91.661632 }, { 25.768858, -80.134976 }, { 35.776015, -78.644772 }, { 30.325408, -97.742836 }, { 29.955019, -90.069057 }, { 29.889855, -97.67165 }, { 32.788854, -79.946803 }, { 37.550584, -77.449711 }, { 36.110012, -115.172991 }, { 37.992824, -84.177623 }, { 33.585095, -111.921668 }, { 32.212933, -98.221037 }, { 42.332465, -83.046101 }, { 38.893084, -77.020185 } }.ToList();
        public static string[] names = { "Germain Arenas", "Jennifer Davey", "Abbi Byrne", "Neandro Baeza", "Autumn Prince", "Erik Collado", "Maya Steele", "Francine Fischer", "Brain Dulaney", "Gerson Toro", "Jenny Norgaard", "Erembourg Ratte", "Anthony Frizzell", "Lonnie Schindler", "Rocco Yarborough", "Vittoria Mancini", "Corinne Horn", "Vinicio Robles", "Francesca Lombardi", "Zachary Fellows", "Holly Franklin", "Ansel Loiselle", "Kari Tran", "Chad Corbitt", "Rhonda Hughes", "Aisha Witt", "Adam Bjerregaard", "Dwayne Passmore", "Abdul-Alim Mikhail", "Jibran Quraishi", "Frederic Towle", "Lucas Sondergaard", "Consuelo Navarro", "Demi Vadeboncoeur", "Adam Brooks", "Rajab Shammas", "Jeanne Vestergaard", "Ireneo Piccio", "Nazzareno Piccio", "Carey Merrill", "Roman Pilcher", "Bellamy Garnier", "Kian Goddard", "Thaddeus Danforth", "Generosa Esposito", "Wade Munger", "Margret Villarreal", "Jeanette Frandsen", "Deanna Ball", "Arnold Valenti", "Margo Ayers", "Iselda Bahena", "Vaughn Oquendo", "Agnano Brito", "Naomi Sharp", "Rosie Reeves", "Sheldon Comeaux", "Fabio Jaramillo", "Modesto Cabán", "Dan Drayton", "Den Kojima", "Victoria Holloway", "Viv Pichardo", "Ethan Rincon", "Giovanni Vera", "Armen Romo", "Delmar Pelchat", "Burnell Plourde", "Joann Chambers", "Naiyana Kunakorn", "Abby Burris", "Victoria Gray", "Patrick Lorenzen", "Daitaro Ishida", "Janna Gamble", "Nelida Zamora", "Daisuke Nakayama", "Rodrigo Romani", "Jimmie Turman", "Amalio Pizarro", "Alaine Poisson", "Abel Bevins", "Naowarat Kurusarttra", "Nickolas McLaughlin", "Linwood Guay", "Gordon Fredrickson", "Niew Leekpai", "Billie Stonge", "Mayra Stephenson", "Sonia Harrison", "Aaliyah Briggs", "Eleanor Bryan", "Sophia Garner", "Marva Cardenas", "Zachary Parsons", "Jeanie Sheppard", "Vicky Erickson", "Noreen Branch", "Freda Conley", "Elwood McGee", "Jeannette Kjaer", "Joshua Murphy", "Carlene O'Neill", "Jensigne Carlsen", "Nicholas Rose", "Letha Walls", "Pedro Fielder", "Mara Rasmussen", "Carolos Lamy" };
        public static string[] descriptions = { "Lorem ipsum dolor sit amet, &lt;strong&gt;consectetur adipiscing&lt;/strong&gt; elit. Donec vulputate, dolor vitae iaculis varius, nibh dolor ultricies massa, aliquam commodo nunc enim molestie mi. Proin molestie ornare sagittis. Fusce ultricies eleifend magna adipiscing egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla scelerisque ut elit vel dapibus. Nunc non ligula posuere, euismod eros euismod, convallis lacus. Nam lacus sem, consequat sed nisl sed, mattis dignissim enim. Phasellus sit amet eleifend massa.", "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales." };
        public static string[] regions = { "Northwest", "Northeast", "South", "Midwest", "West" };
        public static string[] departments = { "Engineering", "Executive", "Facilities and Maintenance", "Finance", "Human Resources", "Information Services", "Marketing", "Production", "Purchasing", "Quality Assurance", "Research and Development", "Sales", "Shipping and Receiving" };
        public static List<KeyValuePair<string, Type>> types = new Dictionary<string, Type> { { "Technical Conference", typeof(TechnicalConferenceRegistration) }, { "Sales Conference", typeof(SalesConferenceRegistration) }, { "General Conferece", typeof(Registration) }, { "Internal Conference", typeof(InternalConferenceRegistration) } }.ToList();

        public static List<Registration> CreateEvent(EventsContext context)
        {
            var latLong = latLongs[rand.Next(0, latLongs.Count)];
            var startTime = new DateTime(rand.Next(DateTime.Today.Year + 1, DateTime.Today.Year + 7), rand.Next(1, 13), rand.Next(1, 29), rand.Next(9, 22), rand.Next(0, 60), 0);
            var eventType = types[rand.Next(0, types.Count)];
            var name = String.Format("FY{0:yy} {0:MMMM} {1}", startTime, eventType.Key);
            var description = descriptions[rand.Next(0, descriptions.Length)];
            var registrationCount = (short)rand.Next(0, 55);
            var eventKey = String.Format("FY{0:yyMMM}{1}", startTime, eventType.Value == typeof(Registration) ? "GeneralConference" : eventType.Value.Name.Replace("Registration", String.Empty));

            int previousCount = context.Events.Count(e => e.EventKey.StartsWith(eventKey));
            if (previousCount > 0)
            {
                eventKey += (previousCount + 1);
            }

            var eventResult = context.Events.Add(new Event
            {
                EventKey = eventKey,
                StartTime = startTime,
                EndTime = startTime.AddDays(3.5d),
                Title = name,
                Description = description,
                RegistrationCount = registrationCount,
                Latitude = latLong.Key,
                Longitude = latLong.Value
            });

            context.SaveChanges();

            List<Registration> registrationList = new List<Registration>();

            if (eventType.Value == typeof(Registration))
            { registrationList.Add(new Registration(String.Format("Stub_{0}", eventResult.EventKey)) { IsStub = true }); }
            else if (eventType.Value == typeof(TechnicalConferenceRegistration))
            { registrationList.Add(new TechnicalConferenceRegistration(String.Format("Stub_{0}", eventResult.EventKey)) { IsStub = true }); }
            else if (eventType.Value == typeof(SalesConferenceRegistration))
            { registrationList.Add(new SalesConferenceRegistration(String.Format("Stub_{0}", eventResult.EventKey)) { IsStub = true, Region = String.Empty }); }
            else if (eventType.Value == typeof(InternalConferenceRegistration))
            { registrationList.Add(new InternalConferenceRegistration(String.Format("Stub_{0}", eventResult.EventKey)) { IsStub = true, EmployeeID = String.Empty, Department = String.Empty }); }

            for (int i = 0; i < registrationCount; i++)
            {
                string personName = names.Except(new string[] { name }).ToList()[rand.Next(0, names.Length - 1)];
                string firstName = personName.Split(' ')[0];
                string lastName = personName.Split(' ')[1];
                string region = regions[rand.Next(0, regions.Length)];
                string department = departments[rand.Next(0, departments.Length)];
                string employeeID = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                int numberOfKeyFobs = rand.Next(1, 5);
                int annualSales = rand.Next(15000, 350000);
                bool onMainCampus = Convert.ToBoolean(rand.Next(0, 2));
                if (eventType.Value == typeof(Registration))
                { registrationList.Add(new Registration(eventResult.EventKey) { FirstName = firstName, LastName = lastName }); }
                else if (eventType.Value == typeof(TechnicalConferenceRegistration))
                { registrationList.Add(new TechnicalConferenceRegistration(eventResult.EventKey) { FirstName = firstName, LastName = lastName, NumberOfKeyFobs = numberOfKeyFobs }); }
                else if (eventType.Value == typeof(SalesConferenceRegistration))
                { registrationList.Add(new SalesConferenceRegistration(eventResult.EventKey) { FirstName = firstName, LastName = lastName, AnnualSales = annualSales }); }
                else if (eventType.Value == typeof(InternalConferenceRegistration))
                { registrationList.Add(new InternalConferenceRegistration(eventResult.EventKey) { FirstName = firstName, LastName = lastName, EmployeeID = employeeID, Department = department }); }
            }

            return registrationList;
        }
    }
}
