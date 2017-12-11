using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyWPF.ViewModels;
using Currency;
using Currency.US;
using System.Collections.ObjectModel;

namespace UnitTestWpfAppCurrency
{
    [TestClass]
    public class UnitTestCurrencyRepoViewModel
    {

        ICurrencyRepo repo;
        CurrencyRepoViewModel vm;

        public UnitTestCurrencyRepoViewModel()
        {

        }

        [TestMethod]
        public void Coins_For_ComboBoxCoins_Collections_AreSame() 
        {
            //Arrange
            repo = new USCurrencyRepo();
            vm = new CurrencyRepoViewModel(repo);

            ObservableCollection<ICoin> testCoinsforcdCoins;

            //Act
            testCoinsforcdCoins = vm.CoinsforcdCoins;
            //Assert
            CollectionAssert.AreEqual(((USCurrencyRepo)repo).Coins, testCoinsforcdCoins);

        }

        //TODO test INotifyPropertyChanged
    }
}
