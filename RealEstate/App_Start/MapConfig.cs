using AutoMapper;
using RealEstate.Models;
using RealEstateApplication.Dtos;
using RealEstateData;
using System;

namespace RealEstate.App_Start
{
    public static class MapConfig
    {
        public static void Map()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<EstateModel, EstateDto>().ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.Now));
                    cfg.CreateMap<EstateDto, EstateModel>().ForMember(dest => dest.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate.ToShortDateString()));

                    cfg.CreateMap<EstateDto, Estate>().ReverseMap();
                }
            );            
        }
    }
}