namespace UnitConversionAPI.Converters
{
    public static class TemperatureConverter
    {
        public static double Convert(
            string from,
            string to,
            double value)
        {
            from = from.ToLower();
            to = to.ToLower();

            if (from == to)
                return value;

            double celsius = from switch
            {
                "celsius" => value,
                "fahrenheit" => (value - 32) * 5 / 9,
                "kelvin" => value - 273.15,
                _ => throw new Exception("Invalid Unit")
            };

            return to switch
            {
                "celsius" => celsius,
                "fahrenheit" => (celsius * 9 / 5) + 32,
                "kelvin" => celsius + 273.15,
                _ => throw new Exception("Invalid Unit")
            };
        }
    }
}