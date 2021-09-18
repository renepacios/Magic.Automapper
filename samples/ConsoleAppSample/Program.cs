using System;

namespace ConsoleAppSample
{
    using AutoMapper;
    using Models;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic AutoMapper Application Test");

            var config = new MapperConfiguration(cfg => cfg.AddProfile(typeof(Magic.AutoMapper.GenericProfile)));
            var mapper = new Mapper(config);

            var entity = new Entity()
            {
                BirthDay = DateTime.Now,
                Id = 1,
                Name = "Test Entity"
            };

            ShowValues(entity);



            var dto = mapper.Map<EntityDto>(entity);

            ShowValues(dto);


        }


        private static void ShowValues<T>(T obj, string title = "")
        {
            if (string.IsNullOrEmpty(title)) title = obj.GetType().ToString();

            
            Console.WriteLine($"\n{title}");
            Enumerable.Range(0, title.Length).ForEach((i, _) => Console.Write("-"));
            Console.WriteLine(string.Empty);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
        }
    }
}
