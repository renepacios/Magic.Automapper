namespace WebApplication.ViewModels
{
    using Magic.AutoMapper;
    using Models;

    public class DataViewModel : IMapFrom<DataModel>
    {
        public int Id { get; set; }
        public string DataName { get; set; }
    }
}
