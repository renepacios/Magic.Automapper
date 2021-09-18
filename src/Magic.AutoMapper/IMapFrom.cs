namespace Magic.AutoMapper
{
    using System;
    using global::AutoMapper;

    public interface IMapFrom<T>
    {
        public Type MapFromType => typeof(T);
        public void Mapping(Profile profile) => profile.CreateMap(GetType(), typeof(T)).ReverseMap();
    }
}