namespace ConsoleAppSample.Models
{
    using System;
    using Magic.AutoMapper;

    public class EntityDto : IMapFrom<Entity>
    {
        public int Id { get; set; }
        public string @Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}