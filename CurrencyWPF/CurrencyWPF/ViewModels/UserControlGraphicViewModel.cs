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
    public class UserControlGraphicViewModel:BaseViewModel
    {




        public UserControlGraphicViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
           
            CoinsforcdCoins = new ObservableCollection<ICoin>(((USCurrencyRepo)repo).Coins);


        }


    }
}
