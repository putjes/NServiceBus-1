﻿namespace MyRequestResponseEndpoint
{
    using System;
    using NServiceBus;
    using NServiceBus.ActiveMQ;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, UsingTransport<ActiveMQ>
    {
    }

    public class MyClass:IWantToRunWhenBusStartsAndStops
    {
        public void Start()
        {
            Console.Out.WriteLine("The MyRequestResponseEndpoint is now started and ready to accept messages");
        }

        public void Stop()
        {
            
        }
    }
}
