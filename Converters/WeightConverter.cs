namespace UnitConversionAPI.Converters
{
    public static class WeightConverter
    {
        private static readonly Dictionary<string, double> Units =
            new()
            {
                { "kilogram",1 },
                { "gram",0.001 },
                { "pound",0.453592 },
                { "ton",1000 }
            };

        public static double Convert(
            string from,
            string to,
            double value)
        {
            var kg = value * Units[from.ToLower()];
            return kg / Units[to.ToLower()];
        }
    }
}