namespace WebApplication.ViewModels
{
    using System;
    using Magic.AutoMapper;
    using Models;

    public class DataViewModelDetails : IMapFrom<DataModel>
    {
        public int Id { get; set; }
        public string DataName { get; set; }
        public string Summary { get; set; }
        public DateTime Random { get; set; }
    }
}