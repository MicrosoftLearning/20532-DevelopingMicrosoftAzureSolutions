namespace Contoso.Events.Models
{
    public class SalesConferenceRegistration : GeneralRegistration
    {
        public string Region { get; set; }
        public int AnnualSales { get; set; }
    }
}