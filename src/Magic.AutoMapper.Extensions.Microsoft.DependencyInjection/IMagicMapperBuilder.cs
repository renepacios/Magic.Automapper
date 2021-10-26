// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using AutoMapper;


    public interface IMagicMapperBuilder
    {
        IServiceCollection AddAutoMapper(params Assembly[] assemblies);
        IServiceCollection AddAutoMapper(Action<IMapperConfigurationExpression> configAction, params Assembly[] assemblies);
        IServiceCollection AddAutoMapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, params Assembly[] assemblies);
        IServiceCollection AddAutoMapper(Action<IMapperConfigurationExpression> configAction, IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutoMapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutoMapper(IEnumerable<Assembly> assemblies, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
        IServiceCollection AddAutoMapper(params Type[] profileAssemblyMarkerTypes);
        IServiceCollection AddAutoMapper(Action<IMapperConfigurationExpression> configAction, params Type[] profileAssemblyMarkerTypes);
        IServiceCollection AddAutoMapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction, params Type[] profileAssemblyMarkerTypes);

        IServiceCollection AddAutoMapper(Action<IMapperConfigurationExpression> configAction,
            IEnumerable<Type> profileAssemblyMarkerTypes, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);

        IServiceCollection AddAutoMapper(Action<IServiceProvider, IMapperConfigurationExpression> configAction,
            IEnumerable<Type> profileAssemblyMarkerTypes, ServiceLifetime serviceLifetime = ServiceLifetime.Transient);
    }
}
