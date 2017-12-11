using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    [Serializable]
    public class USCoin : Coin
    {
        public override bool Equals(object obj)
        {
            if (obj is Coin)
            {
                Coin c = obj as Coin;
                return c.Name == this.Name;

            }
            else
                return false;
           
        }
        public USCoinMintMark MintMark { get; protected set; }

        public USCoin() : this(USCoinMintMark.D)
        {

        }

        public USCoin(USCoinMintMark Mark)
        {
            this.MintMark = Mark;

        }

        public string GetMintNameFromMark(USCoinMintMark Mark)
        {



            if (Mark == USCoinMintMark.D)
                return string.Format("Denver");
            if (Mark == USCoinMintMark.P)
                return string.Format("Philadelphia");
            if (Mark == USCoinMintMark.S)
                return string.Format("San Francisco");
            if (Mark == USCoinMintMark.W)
                return string.Format("West Point");
            else
                return string.Empty;
        }


    }
    public enum USCoinMintMark
    {
        D, S, W, P
    }


}
