﻿using Microsoft.ServiceBus.Messaging;

namespace ServiceBusQueuesLab.Contracts
{
    public interface IQueueFactory
    {
        /// <summary>
        /// Provides a queue from which message are received and passed on to
        /// processing
        /// </summary>
        /// <returns></returns>
        QueueClient Create();
    }
}