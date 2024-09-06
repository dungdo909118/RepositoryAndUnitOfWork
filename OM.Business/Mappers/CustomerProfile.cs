using AutoMapper;
using OM.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Mappers
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<OM.Data.Entities.Customer, CustomerModel>()
                .ForMember(des => des.FullName, src => src.MapFrom(x => x.FirstName + " " + x.LastName));
        }
    }
}
