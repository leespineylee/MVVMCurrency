using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public interface ICurrency
    {
        Decimal MonetaryValue { get; }
        string Name { get; }
    }
}
