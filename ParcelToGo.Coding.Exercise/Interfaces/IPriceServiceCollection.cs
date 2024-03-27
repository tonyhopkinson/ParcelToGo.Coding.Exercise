using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelToGo.Coding.Exercise.Interfaces;
public interface IPriceServiceCollection
{
    void Add(IPriceService priceService);
    IPriceService? Get(string name);
}
