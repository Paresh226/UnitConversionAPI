using UnitConversionAPI.Models;

namespace UnitConversionAPI.Interfaces
{
    public interface IConversionService
    {
        ConvertResponse Convert(ConvertRequest request);

    }
}
