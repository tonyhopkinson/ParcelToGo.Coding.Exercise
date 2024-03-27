using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceA : IPriceService
{
    private const int _discountQuantity = 3;
    private const int _unitPrice = 10;
    private const int _discountPrice = 25;
    public string Name => "A";

    public int GetTotalPrice(int quantity)
    {
        return (_discountPrice * (quantity / _discountQuantity)) + (quantity % _discountQuantity * _unitPrice);
    }
}
