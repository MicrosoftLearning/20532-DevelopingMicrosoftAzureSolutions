using Contoso.Events.Data;
using Contoso.Events.Models;
using System;
using System.Linq;
using System.Data.Entity;

namespace Contoso.Events.ViewModels
{
    public class SignInViewModel
    {
        public SignInViewModel(string eventKey)
        {
            using (EventsContext context = new EventsContext())
            {
                context.SignInDocuments.Add(
                    new SignInDocument 
                    { 
                        EventKey = eventKey,
                        Generated = false, 
                        Document = null 
                    }
                );

                context.SaveChanges();
            }
        }

        public Event Event { get; set; }
    }
}
