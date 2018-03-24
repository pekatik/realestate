using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class EstateModel
    {
        [Required]
        public int EstateId { get; set; }

        [Required(ErrorMessage = Constants.TitleRequired)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = Constants.DimensionRequired)]
        public int Dimension { get; set; }

        [Required(ErrorMessage = Constants.RoomsizeRequired)]
        public string RoomSize { get; set; }

        [Required(ErrorMessage = Constants.PriceRequired)]
        [Range(1, Double.PositiveInfinity, ErrorMessage = Constants.PriceRangeInvalid)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = Constants.ReleaseDateRequired)]
        public string ReleaseDate { get; set; }

        public string Description { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }
    }
}