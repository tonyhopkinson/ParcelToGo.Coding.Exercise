using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise.PriceServices;
public class PriceServiceCollection : IPriceServiceCollection
{
    private readonly List<IPriceService> _priceServices;

    public PriceServiceCollection()
    {
        _priceServices = new List<IPriceService>();
    }
    public void Add(IPriceService priceService)
    {
        _priceServices.Add(priceService);
    }

    public IPriceService? Get(string name)
    {
        return _priceServices.FirstOrDefault(x => x.Name == name);  
    }
}
