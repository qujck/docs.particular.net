﻿namespace Snippets6.Handlers
{
    using System;
    using System.Threading.Tasks;
    using NServiceBus;
    using NServiceBus.Logging;

    #region GenericMessageHandler
    
    public class GenericAsynchronousMessageHandler : IHandleMessages<Object>
    {
        static ILog Logger = LogManager.GetLogger(typeof(GenericAsynchronousMessageHandler));

        public async Task Handle(Object message)
        {
            Logger.Info(string.Format("I just received a message of type {0}.", message.GetType().Name));
            Console.WriteLine("*********************************************************************************");
            await SomeLibrary.SomeMethodAsync(message);
        }
    }

    #endregion
}


