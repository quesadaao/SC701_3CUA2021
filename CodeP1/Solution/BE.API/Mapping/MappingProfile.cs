using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.API.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<data.Foci, Models.Foci>().ReverseMap();
            CreateMap<data.Groups, Models.Groups>().ReverseMap();
        }
    }
}
