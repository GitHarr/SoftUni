namespace Employee.App.Core
{
    using AutoMapper;
    using Employee.App.Core.DTOs;
    using Models;

    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<Employee, ManagerDto>()
                .ForMember(dest => dest.EmployeesDto, from => from.MapFrom(x => x.ManagerEmployees))
                .ReverseMap();

            CreateMap<Employee, EmployeePersonalInfoDto>().ReverseMap();
        }
    }
}
