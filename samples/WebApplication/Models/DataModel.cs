namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DataModel
    {
        public int Id { get; set; }
        public string DataName { get; set; }
        public string Summary { get; set; }
        public DateTime Random { get; set; }

        internal static IEnumerable<DataModel> GetData(int count = 10)
        {
            var data = Enumerable
                .Range(1, count)
                .Select(i => new DataModel()
                {
                    Id = i,
                    DataName = $"Name {i}",
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                    Random = DateTime.Now.AddDays(i * -1)
                });

            foreach (var d in data)
            {
                yield return d;
            }

        }



    }
}