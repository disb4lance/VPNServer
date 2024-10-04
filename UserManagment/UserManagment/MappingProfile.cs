using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UserManagment
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           

            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
