using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RealEstateApplication.Dtos;
using RealEstateData;

namespace RealEstateApplication.Services
{
    public class EstateService : IEstateService
    {
        private readonly IRepository<Estate> _estateRepository;

        public EstateService(IRepository<Estate> estateRepository)
        {
            _estateRepository = estateRepository;
        }

        public EstateDto Add(EstateDto estate)
        {
            var data = Mapper.Map<Estate>(estate);
            _estateRepository.Insert(data);
            _estateRepository.SaveAll();
            return Mapper.Map<EstateDto>(data);
        }

        public EstateDto Get(int id)
        {
            var result = _estateRepository.Table.FirstOrDefault(x => x.EstateId == id);
            return Mapper.Map<EstateDto>(result);
        }

        public List<EstateDto> GetAll()
        {
            var result = _estateRepository.Table.ToList();
            return Mapper.Map<List<EstateDto>>(result);
        }

        public EstateDto Update(EstateDto estate)
        {            
            var result = _estateRepository.Table.FirstOrDefault(x => x.EstateId == estate.EstateId);
            result.Description = estate.Description;
            result.Dimension = estate.Dimension;
            result.Image = estate.Image;
            result.Price = estate.Price;
            result.ReleaseDate = estate.ReleaseDate;
            result.RoomSize = estate.RoomSize;
            result.Title = estate.Title;
            _estateRepository.SaveAll();
            return estate;
        }
    }
}
