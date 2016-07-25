using System.ServiceModel;

namespace Contoso.Events.Models
{
    [ServiceContract]
    public interface ILodgingService
    {
        [OperationContract]
        Hotel[] GetHotels();
    }
}