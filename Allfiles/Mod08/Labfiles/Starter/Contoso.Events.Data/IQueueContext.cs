using System.Threading.Tasks;

namespace Contoso.Events.Data
{
    public interface IQueueContext
    {
        Task SendQueueMessageAsync(string eventKey);
    }
}