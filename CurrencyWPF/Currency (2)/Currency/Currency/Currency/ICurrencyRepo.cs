using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public interface ICurrencyRepo
    {
        List<ICoin> Coins { get; set; }

        void AddCoin(ICoin c);
        string About();
        int GetCoinCount();
        ICoin RemoveCoin(ICoin c);

        Decimal TotalValue();
        int PennyTotalValue();
        int NickelTotalValue();
        int DimeTotalValue();
        int QuarterTotalValue();
        int HalfDollarTotalValue();
        int DollarCoinTotalValue();

        ICurrencyRepo CreateChange(Decimal Amount);
        
        ICurrencyRepo CreateChange(Decimal AmountTendered, Decimal TotalCost);
        ICurrencyRepo Reduce();
    }
}
