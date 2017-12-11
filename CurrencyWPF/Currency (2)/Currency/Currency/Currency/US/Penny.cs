using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.US
{
    [Serializable]
    public class Penny : USCoin
    {
        public Penny(): this(USCoinMintMark.D)
        {
       

        }
        public Penny(USCoinMintMark Mark)
        {
            this.MintMark = Mark;
            this.MonetaryValue = .01m;
            this.Year = DateTime.Now.Year;
            this.Name = "Penny";
        }
        public  string About()
        {
           
            return string.Format("US {0} is from {1}. It is worth ${2}. It was made in {3}", this.Name, this.Year, this.MonetaryValue, GetMintNameFromMark(this.MintMark));
        }


    }



}





