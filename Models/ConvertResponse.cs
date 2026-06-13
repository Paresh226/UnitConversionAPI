namespace UnitConversionAPI.Models
{
    public class ConvertResponse
    {
        public double InputValue { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double ConvertedValue { get; set; }
    }
}
