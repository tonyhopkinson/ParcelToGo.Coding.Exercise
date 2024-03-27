using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceB : IPriceService
{
    private const int _discountQuantity = 2;
    private const int _unitPrice = 12;
    private const int _discountPrice = 20;
    public string Name => "B";

    public int GetTotalPrice(int quantity)
    {
        return (_discountPrice * (quantity / _discountQuantity)) + (quantity % _discountQuantity * _unitPrice);
    }
}
