namespace UnitConversionAPI.Models
{
    public class ConvertRequest
    {
        public string Category { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Value { get; set; }
    }
}
