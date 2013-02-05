﻿namespace NServiceBus.AcceptanceTesting.Support
{
    using System;

    public interface IScenarioWithEndpointBehavior<TContext> where TContext : ScenarioContext
    {
        IScenarioWithEndpointBehavior<TContext> WithEndpoint<T>() where T : EndpointBuilder;

        IScenarioWithEndpointBehavior<TContext> Done(Func<TContext, bool> func);

        void Run();

        IAdvancedScenarioWithEndpointBehavior<TContext> Repeat(Action<RunDescriptorsBuilder> runtimeDescriptor);

    }

    public interface IAdvancedScenarioWithEndpointBehavior<TContext> where TContext : ScenarioContext
    {
        IAdvancedScenarioWithEndpointBehavior<TContext> Should(Action<TContext> should);

        void Run();
    }
}