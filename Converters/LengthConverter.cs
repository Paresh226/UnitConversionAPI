namespace UnitConversionAPI.Converters
{
        public static class LengthConverter
        {
            private static readonly Dictionary<string, double> Units =
                new()
                {
                { "meter",1 },
                { "kilometer",1000 },
                { "centimeter",0.01 },
                { "feet",0.3048 },
                { "inch",0.0254 }
                };

            public static double Convert(
                string from,
                string to,
                double value)
            {
                var meters = value * Units[from.ToLower()];
                return meters / Units[to.ToLower()];
            }
        }
    }