namespace Contoso.Events.Models
{
    public class InternalConferenceRegistration : GeneralRegistration
    {
        public bool OnMainCampus { get; set; }
        public string Department { get; set; }
        public string EmployeeID { get; set; }
    }
}