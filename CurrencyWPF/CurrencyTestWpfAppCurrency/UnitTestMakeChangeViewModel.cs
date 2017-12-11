using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CurrencyWPF.ViewModels;
using System.ComponentModel;
using Currency.US;
using Currency;

namespace UnitTestWpfAppCurrency
{
    [TestClass]
    public class UnitTestMakeChangeViewModel
    {

        MakeChangeViewModel vm;

        public UnitTestMakeChangeViewModel()
        {
            vm = new MakeChangeViewModel(new Currency.USCurrencyRepo());
        }

        //[TestMethod]
        //public void NotifyPropertyChanged_tests()
        //{
        //    //Arrange
        //    List<string> receivedEvents = new List<string>();

        //    vm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
        //    {
        //        receivedEvents.Add(e.PropertyName);
        //    };

        ////    //Act
        //    vm.RepoTotal = 1;
        //    vm.OCoins.Add(new Penny());

        //    //Assert

        //    Assert.AreEqual(receivedEvents[0], "RepoTotal");

        //}
    }
}
