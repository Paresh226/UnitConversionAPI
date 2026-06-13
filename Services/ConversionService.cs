using UnitConversionAPI.Converters;
using UnitConversionAPI.Interfaces;
using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services
{
    public class ConversionService : IConversionService
    {
        public ConvertResponse Convert(
            ConvertRequest request)
        {
            double result = request.Category
                .ToLower() switch
            {
                "length" =>
                    LengthConverter.Convert(
                        request.FromUnit,
                        request.ToUnit,
                        request.Value),

                "weight" =>
                    WeightConverter.Convert(
                        request.FromUnit,
                        request.ToUnit,
                        request.Value),

                "temperature" =>
                    TemperatureConverter.Convert(
                        request.FromUnit,
                        request.ToUnit,
                        request.Value),

                _ => throw new Exception(
                    "Invalid Category")
            };

            return new ConvertResponse
            {
                InputValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = Math.Round(result, 2)
            };
        }
    }
}