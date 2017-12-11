using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    [Serializable]
    public abstract class Coin : ICoin
    {

        public int Year { get; protected set; }
        public Decimal MonetaryValue { get; protected set; }

        public string Name { get; protected set; }

    }
}
