
// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
   
    public static class ServiceCollectionExtensions
    {
        public static IMagicMapperBuilder AddMagicAutoMapper(this IServiceCollection services) 
            => new MagicMapperBuilder(services);

    }
}
