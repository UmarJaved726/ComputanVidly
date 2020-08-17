using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputanVidely.Models;
using ComputanVidely.DTOs;

namespace ComputanVidely.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}