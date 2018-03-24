using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstate
{
    public static class Constants
    {
        public const string FieldRequired = " alanı gerekli. ";

        public const string PriceRequired = "Fiyat" + FieldRequired;
        public const string PriceRangeInvalid = "Lütfen geçerli fiyat yazın. ";
        public const string TitleRequired = "Başlık" + FieldRequired;
        public const string DimensionRequired = "Ölçü" + FieldRequired;
        public const string RoomsizeRequired = "Oda sayısı" + FieldRequired;
        public const string ReleaseDateRequired = "Yayınlanma tarihi" + FieldRequired;

        public const string UploadPath = "/Content/upload/estate/";
    }
}