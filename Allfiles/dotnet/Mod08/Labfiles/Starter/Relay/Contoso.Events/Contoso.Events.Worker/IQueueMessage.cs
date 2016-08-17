using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.Worker
{
    public interface IQueueMessage<T>
    {
        T SourceMessage { get; }

        QueueMessage GetMessage();
    }
}