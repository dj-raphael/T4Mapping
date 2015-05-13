using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class TaxDto
    {
        public int Id { get; set; }

        public decimal? Sales { get; set; }

        public decimal? RepeatRange { get; set; }

        public string Description { get; set; }

        public string Identifier { get; set; }

        public float? TaxRate { get; set; }
    }
}
