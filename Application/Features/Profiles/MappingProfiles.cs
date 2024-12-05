using Application.Features.Boards;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Board, AddBoardCommand>().ReverseMap();
        }
    }
}
