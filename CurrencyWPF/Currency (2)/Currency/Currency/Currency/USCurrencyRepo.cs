using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    [Serializable]
    public class USCurrencyRepo : ICurrencyRepo, ISerializable
    {
        public USCurrencyRepo()
        {

            Coins = new List<ICoin>();

        }

        public List<ICoin> Coins
        {
            get;

            set;
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);

        }
        public Decimal TotalValue()
        {
            Decimal total = Coins.Sum(item => item.MonetaryValue);
            return total;

        }
        public int PennyTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("Penny"));
            return count;

        }
        public int NickelTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("Nickel"));
            return count;

        }
        public int DimeTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("Dime"));
            return count;

        }
        public int QuarterTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("Quarter"));
            return count;

        }
        public int HalfDollarTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("HalfDollar"));
            return count;

        }
        public int DollarCoinTotalValue()
        {
            int count = Coins.Count(i => i.Name.Equals("DollarCoin"));
            return count;

        }
        public string About()
        {
            return string.Empty;
        }


        public int GetCoinCount()
        {
            if (Coins == null)
                return 0;
            else
                return Coins.Count();

        }

        public ICoin RemoveCoin(ICoin c)
        {
           
            Coins.Remove(c);
            return c;
        }

        public ICurrencyRepo CreateChange(Decimal Amount)
        {

            USCurrencyRepo repo = new USCurrencyRepo();
            US.Penny p = new US.Penny();
            US.HalfDollar h = new US.HalfDollar();
            US.Quarter q = new US.Quarter();
            US.Nickel n = new US.Nickel();
            US.DollarCoin d = new US.DollarCoin();
            US.Dime m = new US.Dime();


            // this is the greedy algorithm for making change.
            while ((Amount % 1m) < Amount)
            {
                repo.AddCoin(d);
                Amount = Amount - 1m;

            }
            while ((Amount % .50m) < Amount)
            {
                repo.AddCoin(h);
                Amount = Amount - .50m;

            }
            while ((Amount % .25m) < Amount)
            {
                repo.AddCoin(q);
                Amount = Amount - .25m;

            }
            while ((Amount % .10m) < Amount)
            {
                repo.AddCoin(m);
                Amount = Amount - .10m;

            }
            while ((Amount % .05m) < Amount)
            {
                repo.AddCoin(n);
                Amount = Amount - .05m;

            }
            while ((Amount % .01m) < Amount)
            {
                repo.AddCoin(p);
                Amount = Amount - .01m;

            }


            return repo;
        }

        public ICurrencyRepo CreateChange(Decimal AmountTendered, Decimal TotalCost)
        {
            USCurrencyRepo repo = new USCurrencyRepo();
            decimal newCost = AmountTendered - TotalCost;

            return CreateChange(newCost);


        }
        public ICurrencyRepo Reduce()
        {
            USCurrencyRepo repo = new USCurrencyRepo();
            decimal Amount = 0m;
            for (int i = 0; i < Coins.Count; i++)
            {
                Amount = Amount + Coins[i].MonetaryValue;
            }


          
            US.Penny p = new US.Penny();
            US.HalfDollar h = new US.HalfDollar();
            US.Quarter q = new US.Quarter();
            US.Nickel n = new US.Nickel();
            US.DollarCoin d = new US.DollarCoin();
            US.Dime m = new US.Dime();



            while ((Amount % 1m) < Amount)
            {
                repo.AddCoin(d);
                Amount = Amount - 1m;

            }
            while ((Amount % .50m) < Amount)
            {
                repo.AddCoin(h);
                Amount = Amount - .50m;

            }
            while ((Amount % .25m) < Amount)
            {
                repo.AddCoin(q);
                Amount = Amount - .25m;

            }
            while ((Amount % .10m) < Amount)
            {
                repo.AddCoin(m);
                Amount = Amount - .10m;

            }
            while ((Amount % .05m) < Amount)
            {
                repo.AddCoin(n);
                Amount = Amount - .05m;

            }
            while ((Amount % .01m) < Amount)
            {
                repo.AddCoin(p);
                Amount = Amount - .01m;

            }
            return repo;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ICoin[] coins = Coins.ToArray();

            info.AddValue("Coins", coins);
        }

        public USCurrencyRepo(SerializationInfo info, StreamingContext context)
        {
            ICoin[] coins = info.GetValue("Coins", typeof(Coin[])) as Coin[];
            this.Coins = coins.ToList();
        }
    }
}
