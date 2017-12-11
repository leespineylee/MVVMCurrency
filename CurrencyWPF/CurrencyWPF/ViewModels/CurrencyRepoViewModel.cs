using Currency;
using Currency.US;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyWPF.ViewModels
{
    public class CurrencyRepoViewModel : BaseViewModel
    {

        protected string coinName;

        public string CoinName

        {
            get
            {
                return coinName;
            }
            set
            {
                if (value != coinName)
                {
                    coinName = value;
                    RaisePropertyChangedEvent("CoinName");
                }
            }
        }

        protected int coinNum;
        public int CoinNum
        {
            get { return coinNum; }
            set
            {
                if (value != CoinNum)
                {
                    coinNum = value;
                    RaisePropertyChangedEvent("CoinNum");
                }
            }

        }

        public ICommand AddCoinCommand { get; set; }
        public ICommand RemoveCoinCommand { get; set; }
        public ICommand ResetRepoCommand { get; set; }
        //public decimal RepoTotal
        //{
        //    get
        //    {
        //        return repo.TotalValue();
        //    }

        //}



        public CurrencyRepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            AddCoinCommand = new BasicCommand(AddCoinToRepo);
            RemoveCoinCommand = new BasicCommand(RemoveCoinFromRepo);
            ResetRepoCommand = new BasicCommand(ResetRepo);
            CoinsforcdCoins = new ObservableCollection<ICoin>(((USCurrencyRepo)repo).Coins);
            this.CoinNum = 1;
        }
        public ICoin GetCoinByName(string Name)
        {
            var coin = from c in CoinsforcdCoins
                       where c.ToString() == Name
                       select c;
            return coin.First();
        }
        private void AddCoinToRepo()
        {
            for(int i =0; i<this.CoinNum; i++)
            {
                this.AddCoin(GetCoinByName(coinName));
            }
            

        }
        private void ResetRepo()
        {
            USCurrencyRepo _repo = new USCurrencyRepo();
            _repo.Coins = new List<ICoin> { new Penny(), new Quarter(), new Dime(), new Nickel(), new HalfDollar(), new DollarCoin() };
            repo.Coins.Clear();
            foreach (ICoin coin in _repo.Coins)
                repo.Coins.Add(coin);
            

        }
        private void RemoveCoinFromRepo()
        {
            for (int i = 0; i < this.CoinNum; i++)
            {
                this.RemoveCoin(GetCoinByName(coinName));
            }

        }
        public void AddCoin(ICoin c)
        {
            repo.AddCoin(c);

            RaisePropertyChangedEvent("RepoTotal");

        }
        public ICoin RemoveCoin(ICoin c)
        {
            var coin = repo.RemoveCoin(c);
            RaisePropertyChangedEvent("RepoTotal");
            return coin;

        }

    }
}
