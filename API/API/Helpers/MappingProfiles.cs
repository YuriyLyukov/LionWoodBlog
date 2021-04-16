using System.Collections.Generic;
using API.Contracts.V1.Responses;
using API.Domain.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Post, PostResponse>();
            CreateMap<KeyValuePair<string, int>, TopPostAuthorsResponse>()
                .ForMember(dest => dest.AuthorName,
                    opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.PostsCount,
                    opt => opt.MapFrom(src => src.Value));
        }
    }
}