using Currency;
using Currency.US;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CurrencyWPF.Models;

namespace CurrencyWPF.ViewModels
{
    public class MakeChangeViewModel : BaseViewModel
    {

        SaveableCurrencyRepo saveThis;
        
        //public decimal RepoTotal
        //{
        //    get
        //    {
        //        return repo.TotalValue();
        //    }
        //    set
        //    {
        //        RaisePropertyChangedEvent("RepoTotal");
        //        RepoTotal = value;
        //    }
        //}


        public ICommand MakeChangeCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public ICommand LoadCommand { get; set; }
         

        public MakeChangeViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            SaveCommand = new BasicCommand(SaveThisRepo);
            LoadCommand = new BasicCommand(LoadRepo);
            MakeChangeCommand = new BasicCommand(UpdateMakeChange);
            CoinsforcdCoins = new ObservableCollection<ICoin>(((USCurrencyRepo)repo).Coins);
            saveThis = new SaveableCurrencyRepo(repo.Coins);

        }


        public void SaveThisRepo()
        {
            
            saveThis.Save(repo.Coins);

        }
        //public void SaveRepo()
        //{
        //    saveThis.Save(repo.Coins);

        //}
        public void LoadRepo()
        {
            repo.Coins = saveThis.Load();


        }
        public void UpdateMakeChange()
        {

            this.dochange();
            
        }
        public void dochange()
        {
            ICurrencyRepo _repo;
            _repo = repo;
            _repo = _repo.CreateChange(RepoTotal);
            repo.Coins.Clear();
            foreach (ICoin coin in _repo.Coins)
                repo.Coins.Add(coin);

        }


    }
}
