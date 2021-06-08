using AutoMapper;
using catnetcoreapi.Application.Features.Employees.Queries.GetEmployees;
using catnetcoreapi.Application.Features.Positions.Commands.CreatePosition;
using catnetcoreapi.Application.Features.Positions.Queries.GetPositions;
using catnetcoreapi.Domain.Entities;

namespace catnetcoreapi.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }

}
