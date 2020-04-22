using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.API.Models;
using Whereabouts.Core.Models;

namespace Whereabouts.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Adress, AdressModel>().ReverseMap();
            CreateMap<TrackedItem, TrackedItemModel>().ReverseMap();
            CreateMap<Tracker, TrackerModel>().ReverseMap();
            CreateMap<TrackerType, TrackerTypeModel>().ReverseMap();
            CreateMap<Vehicle, VehicleModel>().ReverseMap();
        }
    }
}
