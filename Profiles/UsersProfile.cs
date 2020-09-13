using AutoMapper;
using userAuth.DTOs;
using userAuth.Models;

namespace userAuth.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
        }
    }
}