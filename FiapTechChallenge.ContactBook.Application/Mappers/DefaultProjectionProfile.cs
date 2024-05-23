using AutoMapper;
using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;

namespace FiapTechChallenge.ContactBook.Application.Mappers
{
    public class DefaultProjectionProfile : Profile
    {
        public DefaultProjectionProfile()
        {
            CreateMap<Contact, CreateContactDto>()
            .ReverseMap();
            CreateMap<Contact, UpdateContactDto>()
                .ReverseMap();

            CreateProjection<Contact, ResponseContactDto>()
                .ForMember(x => x.RegionName, opt =>
                    opt.MapFrom(a => a.DDDNavigation.RegionNavigation.Name)
                );

        }
    }
}
