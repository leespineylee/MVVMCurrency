using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.US
{
    [Serializable]
    public class Quarter : USCoin
    {
        public string About()
        {
            return string.Format("US {0} is from {1}. It is worth ${2}. It was made in {3}", this.Name, this.Year, this.MonetaryValue, GetMintNameFromMark(this.MintMark));
        }

        public Quarter(): this(USCoinMintMark.D)
        {


        }


        public Quarter(USCoinMintMark Mark)
        {
            this.MintMark = Mark;
            this.MonetaryValue = .25m;
            this.Year = DateTime.Now.Year;
            this.Name = "Quarter";
        }
    }
}
