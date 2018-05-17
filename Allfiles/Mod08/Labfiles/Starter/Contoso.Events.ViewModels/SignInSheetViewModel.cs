using Contoso.Events.Models;

namespace Contoso.Events.ViewModels
{
    public class SignInSheetViewModel
    {
        public Event Event { get; set; }

        public SignInSheetState SignInSheetState { get; set; }
    }
}