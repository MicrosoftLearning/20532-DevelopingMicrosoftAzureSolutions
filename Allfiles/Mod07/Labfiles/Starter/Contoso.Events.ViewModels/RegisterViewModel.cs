using Contoso.Events.Models;

namespace Contoso.Events.ViewModels
{
    public class RegisterViewModel
    {
        public Event Event { get; set; }

        public dynamic RegistrationStub { get; set; }
    }
}