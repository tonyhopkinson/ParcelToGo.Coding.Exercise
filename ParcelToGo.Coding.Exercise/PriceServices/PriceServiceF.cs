using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceF : IPriceService
{
    private const int _discountQuantity = 2;
    private const int _unitPrice = 8;
    private const int _discountPrice = 15;
    public string Name => "F";

    public int GetTotalPrice(int quantity)
    {
        return (_discountPrice * (quantity / _discountQuantity)) + (quantity % _discountQuantity * _unitPrice); 
    }
}
