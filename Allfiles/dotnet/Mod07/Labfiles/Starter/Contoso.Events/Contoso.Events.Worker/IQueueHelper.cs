using System;

namespace Contoso.Events.Worker
{
    public interface IQueueHelper<T>
    {
        T Receive();

        void CompleteMessage(T message);

        void AbandonMessage(T message);
    }
}