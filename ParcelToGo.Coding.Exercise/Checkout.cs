using ParcelToGo.Coding.Exercise.Interfaces;

namespace ParcelToGo.Coding.Exercise;
public class Checkout : ICheckout
{
    private readonly Dictionary<string, int> _services;
    private readonly IPriceServiceCollection _priceServices;
    public Checkout(IPriceServiceCollection priceServices)
    {
        _services = new Dictionary<string, int>();
        _priceServices = priceServices;
    }

    public int GetTotalPrice()
    {
        int result = 0;
        foreach(var pair in _services) 
        {
            result += _priceServices.Get(pair.Key)!.GetTotalPrice(pair.Value);
        }
        return result;
    }

    public void Scan(string service)
    {
        if (!_services.ContainsKey(service)) 
        { 
            _services.Add(service, 0);
        }
        _services[service] += 1;
    }
}
