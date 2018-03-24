using RealEstateApplication.Dtos;
using System.Collections.Generic;

namespace RealEstateApplication.Services
{
    public interface IEstateService
    {
        EstateDto Add(EstateDto estate);
        EstateDto Get(int id);
        EstateDto Update(EstateDto estate);
        List<EstateDto> GetAll();
    }
}
