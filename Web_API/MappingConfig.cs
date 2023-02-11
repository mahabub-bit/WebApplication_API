using AutoMapper;
using Web_API.Models;
using Web_API.Models.Dto;


namespace Web_API
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Company, CompanyCreateDTO>().ReverseMap();
            CreateMap<Company, CompanyUpdateDTO>().ReverseMap();

            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();

            CreateMap<CategoryType, CategoryTypeDTO>().ReverseMap();
            CreateMap<CategoryType, CategoryTypeCreateDTO>().ReverseMap();
            CreateMap<CategoryType, CategoryTypeUpdateDTO>().ReverseMap();


            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<Service, ServiceCreateDTO>().ReverseMap();
            CreateMap<Service, ServiceUpdateDTO>().ReverseMap();
        }
    }
}
