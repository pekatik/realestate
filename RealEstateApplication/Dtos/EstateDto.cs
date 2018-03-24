using System;

namespace RealEstateApplication.Dtos
{
    public class EstateDto
    {
        public int EstateId { get; set; }
        public string Title { get; set; }
        public int Dimension { get; set; }
        public string RoomSize { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
