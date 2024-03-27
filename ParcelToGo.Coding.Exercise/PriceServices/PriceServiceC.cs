using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceC : IPriceService
{
    public string Name => "C";
    private const int _unitPrice = 15;

    public int GetTotalPrice(int quantity)
    {
        return (_unitPrice * quantity);
    }
}
