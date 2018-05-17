namespace Contoso.Events.Models
{
    public class CosmosSettings
    {
        public string DatabaseId { get; set; }
        
        public string CollectionId { get; set; }
        
        public string EndpointUrl { get; set; }
        
        public string AuthorizationKey { get; set; }
    }
}