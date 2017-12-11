using Currency;
using CurrencyWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CurrencyWPF.ViewModels
{
    public abstract class BaseViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected virtual void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
         protected void OnPropertyChanged(string name)
      {
          PropertyChangedEventHandler handler = PropertyChanged;
          if (handler != null)
          {
              handler(this, new PropertyChangedEventArgs(name));
          }
      }
        public decimal RepoTotal
        {
            get
            {
                
                return repo.TotalValue();
            }
            set
            {
                OnPropertyChanged("RepoTotal");
                RepoTotal = value;
            }

        }

        public ICurrencyRepo repo;


        private ObservableCollection<ICoin> coinsForcbCoins;

        public ObservableCollection<ICoin> CoinsforcdCoins
        {
            get { return coinsForcbCoins; }
            set { coinsForcbCoins = value; }
        }

        public int PennyTotal
        {
            get
            {
                return repo.PennyTotalValue();
            }
        }
        public int NickelTotal
        {
            get
            {
                return repo.NickelTotalValue();
            }
        }
        public int DimeTotal
        {
            get
            {
                return repo.DimeTotalValue();
            }
        }
        public int QuarterTotal
        {
            get
            {
                return repo.QuarterTotalValue();
            }
        }
        public int HalfDollarTotal
        {
            get
            {
                return repo.HalfDollarTotalValue();
            }
        }
        public int DollarTotal
        {
            get
            {
                return repo.DollarCoinTotalValue();
            }
        }


    }


    public class BasicCommand: ICommand
    {
        private Action commandAction;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public BasicCommand(Action action)
        {
            commandAction = action;

        }
        public bool CanExecute(object parameter)
        {
            return true;

        }
        public void Execute(object parameter)
        {
            commandAction();

        }

    }
}
