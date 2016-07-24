using System;

namespace Contoso.Events.Worker
{
    public interface IQueueHelper<T>
    {
        IQueueMessage<T> Receive();

        void CompleteMessage(T message);

        void AbandonMessage(T message);
    }
}