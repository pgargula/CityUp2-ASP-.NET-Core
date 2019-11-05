using AutoMapper;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserRegisterDTO>();
            CreateMap<UserRegisterDTO,User>();
        }
    }
}
