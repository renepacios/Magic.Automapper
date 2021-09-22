
// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
   
    public static class ServiceCollectionExtensions
    {
        public static IMapperUtilsBuilder AddMapperUtils(this IServiceCollection services) 
            => new MapperUtilsBuilder(services);

    }
}
