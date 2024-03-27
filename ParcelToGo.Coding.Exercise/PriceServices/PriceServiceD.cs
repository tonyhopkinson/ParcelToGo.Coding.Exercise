using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceD : IPriceService
{
    public string Name => "D";
    private const int _unitPrice = 25;

    public int GetTotalPrice(int quantity)
    {
        return (_unitPrice * quantity);
    }
}
