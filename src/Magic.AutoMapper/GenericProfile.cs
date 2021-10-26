namespace Magic.AutoMapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using global::AutoMapper;

    public static class MagicAutoMapperHelpers
    {
        public static void AddMagicAutoMapperProfile(this IMapperConfigurationExpression cfg) =>
            cfg.AddProfile(new GenericProfile()); 
        //typeof(Magic.AutoMapper.GenericProfile))(typeof(Magic.AutoMapper.GenericProfile));

        public static void AddMagicAutoMapperProfile(this IMapperConfigurationExpression cfg, IEnumerable<Assembly> assemblies)
        {
            cfg.AddProfile(new GenericProfile(assemblies));
        }
    }

    public class GenericProfile : Profile
    {
        internal GenericProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetEntryAssembly());

            //Console.WriteLine(Assembly.GetCallingAssembly().ToString());
            //Console.WriteLine(Assembly.GetEntryAssembly()?.ToString());
            //Console.WriteLine(Assembly.GetExecutingAssembly().ToString());

        }


        internal GenericProfile(Assembly assembly) => ApplyMappingsFromAssembly(assembly);

        internal GenericProfile(IEnumerable<Assembly> assemblies)
        {
            foreach (Assembly assembly in assemblies)
            {
                ApplyMappingsFromAssembly(assembly);
            }
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                //var metodos =
                //    type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Default);

                //var defaultMembers =
                //    type.GetDefaultMembers();
              var interfaceType=  type.GetInterfaces().FirstOrDefault(w => w.Name.StartsWith("IMapFrom"));
              if (interfaceType != null)
              {
                  var method = interfaceType.GetMethod("Mapping");
                  method?.Invoke(instance, new object[] {this});
              }
                 
                //var methodInfo = type.GetMethod("Mapping");
                //methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}