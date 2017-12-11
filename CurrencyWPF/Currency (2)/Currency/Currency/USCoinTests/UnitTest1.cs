﻿using System;
using Currency.US;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency;

namespace USCoinTests
{

    [TestClass]
    public class USCoinTests
    {

        Penny p;
        USCoin USCoinTest;

        public USCoinTests()
        {
            p = new Penny();
            
        }


        [TestMethod]
        public void USCoinPennyConstructor()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert
            Assert.AreEqual(Currency.USCoinMintMark.D, p.MintMark); //D is the default mint mark
            Assert.AreEqual(System.DateTime.Now.Year, p.Year); //Current year is default year

        }

        [TestMethod]
        public void USCoinMintMark()
        {
            USCoinTest = new USCoin();
            // I had to implement a test USCoin here. Ask in class ****************
            //also - this is marked as abstract on diagram, but not in the examples. 
            //Arrange
            string mintNameDenver, mintNamePhili, mintNameSanFran, mintNameWestPoint;
            USCoinMintMark D, P, S, W;

            //Act 
            mintNameDenver = "Denver";
            mintNamePhili = "Philadelphia";
            mintNameSanFran = "San Francisco";
            mintNameWestPoint = "West Point";
            D = Currency.USCoinMintMark.D;
            P = Currency.USCoinMintMark.P;
            S = Currency.USCoinMintMark.S;
            W = Currency.USCoinMintMark.W;

            //Assert
            Assert.AreEqual(USCoinTest.GetMintNameFromMark(D), mintNameDenver);
            Assert.AreEqual(USCoinTest.GetMintNameFromMark(P), mintNamePhili);
            Assert.AreEqual(USCoinTest.GetMintNameFromMark(S), mintNameSanFran);
            Assert.AreEqual(USCoinTest.GetMintNameFromMark(W), mintNameWestPoint);
        }

        [TestMethod]
        public void USCoinPennyMonetaryValue()
        {
            //Arrange
            p = new Penny();
            //Act 
            //nothing should have .01;
            //Assert
            Assert.AreEqual(.01m, p.MonetaryValue);
        }

        [TestMethod]
        public void USCoinPennyAbout()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert
            Assert.AreEqual("US Penny is from 2017. It is worth $0.01. It was made in Denver", p.About());
        }
        //[TestMethod]
        //public void USCoinSerialize()
        //{
        //    //Arrange
        //    List<ICoin> coinList, readCoinList;
        //    coinList = getCoinList();
        //    //Act 

        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new MemoryStream();
        //    formatter.Serialize(stream, coinList);
        //    stream.Position = 0;
        //    readCoinList = (List<ICoin>)formatter.Deserialize(stream);
        //    //Assert
        //    foreach (Coin c in coinList)
        //    {
        //        Assert.IsTrue(c is ISerializable);
        //    }
        //    CollectionAssert.AreEqual(coinList, readCoinList);

        //}

        //private List<ICoin> getCoinList()
        //{
        //    ICoin n = new Nickel();
        //    ICoin pen = new Penny();
        //    ICoin q = new Quarter();
        //    ICoin d = new Dime();
        //    ICoin hd = new HalfDollar();
        //    ICoin doll = new DollarCoin();

        //    List<ICoin> coinList = new List<ICoin>
        //    {
        //        { doll },
        //        { hd },
        //        { q },
        //        { d },
        //        { n },
        //        { pen }
        //    };
        //    return coinList.OrderByDescending(c => c.MonetaryValue).ToList();

        //}

    }
}
