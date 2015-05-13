using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class Product
    {
        public string Upc { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public decimal? Weight { get; set; }

        public decimal Quantity { get; set; }
    }
}