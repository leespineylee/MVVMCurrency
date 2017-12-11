using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyWPF.Views;
using Currency;
using System.Collections.Generic;
using Currency.US;
using CurrencyWPF;
using CurrencyWPF.Models;

namespace UnitTestWpfAppCurrency
{
    [TestClass]
    public class UnitTestSaveableCurrencyRepo
    {

        SaveableCurrencyRepo repo;

        public UnitTestSaveableCurrencyRepo()
        {
            repo = new SaveableCurrencyRepo(
                new List<ICoin>()
                {
                    new Penny(),
                    new Nickel(),
                    new Quarter()
                });
        }

        [TestMethod]
        public void SaveableCurrenyRepo_Saving_DefaultPath()
        {
            //Arrange
            string realPath;
            string defaultPath;

            //Act
            defaultPath = "MyFile.bin";
            realPath = repo.Path;

            //Assert
            Assert.AreEqual(defaultPath, realPath);
        }

        [TestMethod]
        public void SaveableCurrenyRepo_Saving_Load()
        {
            List<ICoin> RepoCoins()
            {
                ICoin p = new Penny();
                ICoin h = new HalfDollar();
                ICoin dc = new DollarCoin();
                ICoin q = new Quarter();
                ICoin d = new Dime();
                ICoin n = new Nickel();

                List<ICoin> Repo_list = new List<ICoin>
                {
                    {p}


                };
                return Repo_list;
            }
            //Arrange
            List<ICoin> loadedCoins;
            loadedCoins = RepoCoins();
            
            //Act
            repo.Save(loadedCoins);
            repo.Load();
           

            //Assert
            Assert.AreEqual(repo.Coins.Count, loadedCoins.Count);

            CollectionAssert.AreEqual(repo.Coins, loadedCoins);

        }

    }
}
