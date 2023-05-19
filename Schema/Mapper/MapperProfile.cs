using AutoMapper;
using Entities;
using Entities.Concrete;
using Schema.StaffMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Staff, StaffResponse>();
            CreateMap<StaffRequest, Staff>();
        }

    }
}
