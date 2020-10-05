using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace CommandProfile
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
             CreateMap<Command, CommandReadDto>();
        }
    }
   
}