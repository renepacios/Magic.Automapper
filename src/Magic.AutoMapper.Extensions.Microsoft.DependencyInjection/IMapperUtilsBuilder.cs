// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using AutoMapper;


    public interface IMapperUtilsBuilder
    {
        IServiceCollection AddAutomapper(params Assembly[] assemblies);
        IServiceCollection AddAutomapper(Action<IMapperConfigurationExpression> configAction, params Assembly[] assemblies);
        IServiceCollection AddAutomapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, params Assembly[] assemblies);
        IServiceCollection AddAutomapper(Action<IMapperConfigurationExpression> configAction, IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutomapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutomapper(IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutomapper(params Type[] profileAssemblyMarkerTypes);
        IServiceCollection AddAutomapper(Action<IMapperConfigurationExpression> configAction, params Type[] profileAssemblyMarkerTypes);
        IServiceCollection AddAutomapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, params Type[] profileAssemblyMarkerTypes);

        IServiceCollection AddAutomapper(Action<IMapperConfigurationExpression> configAction,
            IEnumerable<Type> profileAssemblyMarkerTypes, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);

        IServiceCollection AddAutomapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction,
            IEnumerable<Type> profileAssemblyMarkerTypes, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
    }
}
