using AutoMapper;
using SFAApi.Dto;
using SFAModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFAApi.Core
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
