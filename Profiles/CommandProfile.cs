using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace CommandProfile
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //source -> Target
             CreateMap<Command, CommandReadDto>();
             CreateMap<CommandCreateDto, Command>();
        }
    }
   
}