using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelToGo.Coding.Exercise.Interfaces;
public interface IPriceService
{
    int GetTotalPrice(int quantity);
    string Name { get; }
}
