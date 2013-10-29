using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTIL.StarbuzzCoffee.Business;

namespace CTIL.StarbuzzCoffee.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void coffeeTest()
        {
            string expect = "Coffee (22.00) | Total=22.00";
            string actual = string.Empty;
            Drinkable coffee = new Beverage("Coffee",22.00M);
            coffee.accumulatePrice();
            actual = coffee.getPrice() + coffee.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void plainTeaTest()
        {
            string expect = "PlainTea (25.00) | Total=25.00";
            string actual = string.Empty;
            Drinkable plainTea = new Beverage( "PlainTea",25.00M);
            plainTea.accumulatePrice();
            actual = plainTea.getPrice() + plainTea.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void beerTest()
        {
           string  expect = "Beer (18.00) | Total=18.00";
           string actual = string.Empty;
            Drinkable beer = new Beverage( "Beer",18.00M);
            beer.accumulatePrice();
            actual = beer.getPrice() + beer.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void cokeTest()
        {
                      
           string expect = "Coke (12.00) | Total=12.00";
           string actual = string.Empty;
            Drinkable coke = new Beverage("Coke",12.00M);
            coke.accumulatePrice();
            actual = coke.getPrice() + coke.getTotal();
            Assert.AreEqual(expect, actual);       
        }

        [TestMethod]
        public void coffeeAddMilkTest()
        {
            string expect = "Coffee (22.00) + Milk (3.50) | Total=25.50";
            string actual = string.Empty;
            Drinkable coffee = new Beverage( "Coffee",22.00M);
            Drinkable coffeeAddMilk = new Condiment(coffee, "Milk",3.50M);
            coffeeAddMilk.accumulatePrice();
            actual = coffee.getPrice() + " + " + coffeeAddMilk.getPrice() + coffeeAddMilk.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void blackTeaAddHoneyTest()
        {
            string expect = "BlackTea (25.00) + Honey (4.50) | Total=29.50";
            string actual = string.Empty;
            Drinkable blackTea = new Beverage("BlackTea",25.00M);
            Drinkable blackTeaAddHoney = new Condiment(blackTea, "Honey",4.5M);
            blackTeaAddHoney.accumulatePrice();
            actual = blackTea.getPrice() + " + " + blackTeaAddHoney.getPrice() + blackTeaAddHoney.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void beerAddLemonTest()
        {
            string expect = "Beer (18.00) + Lemon (5.00) | Total=23.00";
            string actual = string.Empty;
            Drinkable beer = new Beverage("Beer",18.00M);
            Drinkable beerAddLemon = new Condiment(beer,"Lemon",5.00M);
            beerAddLemon.accumulatePrice();
            actual = beer.getPrice() + " + " + beerAddLemon.getPrice() + beerAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void cokeAddLemonTest()
        {
            string expect = "Coke (12.00) + Lemon (5.00) | Total=17.00";
            string actual = string.Empty;
            Drinkable coke = new Beverage( "Coke",12.00M);
            Drinkable cokeAddLemon = new Condiment(coke, "Lemon", 5.00M);
            cokeAddLemon.accumulatePrice();
            actual = coke.getPrice() + " + " + cokeAddLemon.getPrice() + cokeAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }      

        [TestMethod]
        public void CoffeeAddHoneyAndMilk()
        {
            string expect = "Coffee (22.00) + Honey (4.50) + Milk (3.50) | Total=30.00";
            string actual = string.Empty;
            Drinkable coffee = new Beverage("Coffee",22.00M);
            Drinkable coffeeAddHoney = new Condiment(coffee, "Honey",4.50M);
            Drinkable coffeeAddMilk = new Condiment(coffeeAddHoney,"Milk", 3.50M);
            coffeeAddMilk.accumulatePrice();
            actual = coffee.getPrice() + " + " + coffeeAddHoney.getPrice() + " + " + coffeeAddMilk.getPrice() + coffeeAddMilk.getTotal();
            Assert.AreEqual(expect, actual);                    
        }

        [TestMethod]
        public void greenTeaAddHoneyAndMilkAndChocolateTest()
        {
            string expect = "GreenTea (22.00) + Honey (4.50) + Milk (3.50) + Chocolate (7.00) | Total=37.00";
            string actual = string.Empty;
            Drinkable greenTea = new Beverage("GreenTea",22.00M);
            Drinkable greenTeaAddHoney = new Condiment(greenTea, "Honey", 4.50M);
            Drinkable greenTeaAddMilk = new Condiment(greenTeaAddHoney, "Milk", 3.50M);
            Drinkable greenTeaAddChocolate = new Condiment(greenTeaAddMilk, "Chocolate", 7.00M);
            greenTeaAddChocolate.accumulatePrice();
            actual = greenTea.getPrice() + " + " + greenTeaAddHoney.getPrice() + " + " + greenTeaAddMilk.getPrice() + " + " + greenTeaAddChocolate.getPrice() + greenTeaAddChocolate.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void cokeAddAllTest()
        {
            string expect = "Coke (12.00) + Milk (3.50) + Honey (4.50) + Lemon (5.00) + Chocolate (7.00) + Mocha (8.00) | Total=40.00";
            string actual = string.Empty;
            Drinkable coke = new Beverage("Coke",12.00M);
            Drinkable cokeAddMilk = new Condiment(coke, "Milk", 3.50M);
            Drinkable cokeAddHoney = new Condiment(cokeAddMilk, "Honey", 4.50M);
            Drinkable cokeAddLemon = new Condiment(cokeAddHoney,"Lemon", 5.00M);
            Drinkable cokeAddChocolate = new Condiment(cokeAddLemon,"Chocolate", 7.00M);
            Drinkable cokeAddMocha = new Condiment(cokeAddChocolate,"Mocha", 8.00M);
            cokeAddMocha.accumulatePrice();
            actual = coke.getPrice() + " + " + cokeAddMilk.getPrice() + " + " + cokeAddHoney.getPrice()
                + " + " + cokeAddLemon.getPrice() + " + " + cokeAddChocolate.getPrice()
                + " + " + cokeAddMocha.getPrice() + cokeAddMocha.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsTest()
        {
            string expect = "LoveFeelings (49.00) | Total=49.00";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage( "LoveFeelings",49.00M);
            loveFeelings.accumulatePrice();
            actual = loveFeelings.getPrice() + loveFeelings.getTotal();
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void LoveFeelingsAddLemonTest()
        {
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) | Total=53.00";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage("LoveFeelings",49.00M);
            Drinkable loveFeelingsAddLemon = new Condiment(loveFeelings, "Lemon", 5.00M, 0.80M);
            loveFeelingsAddLemon.accumulatePrice();
            actual = loveFeelings.getPrice() + " + " + loveFeelingsAddLemon.getPrice() + loveFeelingsAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddAllTest()
        {
            string expect = "LoveFeelings (49.00) + Honey (4.50*80%) + Milk (3.50*80%) + Chocolate (7.00*80%) + Mocha (8.00*80%) + Lemon (5.00*80%) | Total=71.40";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage( "LoveFeelings",49.00M);
            Drinkable loveFeelingsAddHoney = new Condiment(loveFeelings,"Honey", 4.50M, 0.80M);
            Drinkable loveFeelingsAddMilk = new Condiment(loveFeelingsAddHoney, "Milk", 3.50M, 0.80M);
            Drinkable loveFeelingsAddChocolate = new Condiment(loveFeelingsAddMilk,"Chocolate", 7.00M, 0.80M);
            Drinkable loveFeelingsAddMocha = new Condiment(loveFeelingsAddChocolate, "Mocha", 8.00M, 0.80M);
            Drinkable loveFeelingsAddLemon = new Condiment(loveFeelingsAddMocha, "Lemon", 5.00M, 0.80M);
            loveFeelingsAddLemon.accumulatePrice();
            actual = loveFeelings.getPrice() + " + " + loveFeelingsAddHoney.getPrice() + " + " +
                loveFeelingsAddMilk.getPrice() + " + " + loveFeelingsAddChocolate.getPrice() + " + " +
                loveFeelingsAddMocha.getPrice() + " + " + loveFeelingsAddLemon.getPrice() +
                loveFeelingsAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BeerAddLoversEmbraceTest()
        {
            string expect = "Beer (18.00) + LoversEmbrace (21.00*80%) | Total=34.80";
            string actual = string.Empty;
            Drinkable beer = new Beverage("Beer",18.00M);
            Drinkable beerAddLoversEmbrace = new Condiment(beer, "LoversEmbrace", 21.00M, 0.80M);
            beerAddLoversEmbrace.accumulatePrice();
            actual = beer.getPrice() + " + " + beerAddLoversEmbrace.getPrice() + beerAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddLoversEmbraceTest()
        {
            string expect = "LoveFeelings (49.00) + LoversEmbrace (21.00*50%) | Total=59.50";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage("LoveFeelings",49.00M);
            Drinkable loveFeelingsAddLoversEmbrace = new Condiment(loveFeelings, "LoversEmbrace", 21.00M, 0.50M);
            loveFeelingsAddLoversEmbrace.accumulatePrice();
            actual = loveFeelings.getPrice() + " + " + loveFeelingsAddLoversEmbrace.getPrice() + loveFeelingsAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddLemonAddLoversEmbraceTest()
        {
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) + LoversEmbrace (21.00*50%) | Total=63.50";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage( "LoveFeelings",49.00M);
            Drinkable loveFeelingsAddLemon = new Condiment(loveFeelings,"Lemon", 5.00M, 0.80M);
            Drinkable loveFeelingsAddLoversEmbrace = new Condiment(loveFeelingsAddLemon, "LoversEmbrace", 21.00M, 0.50M);
            loveFeelingsAddLoversEmbrace.accumulatePrice();
            actual = loveFeelings.getPrice() + " + " + loveFeelingsAddLemon.getPrice() + " + " + loveFeelingsAddLoversEmbrace.getPrice() + loveFeelingsAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void CoffeeAddSugarTest()
        {
            string expect = "Coffee (22.00) + Sugar (1.00) | Total=23.00";
            string actual = string.Empty;
            Drinkable coffee = new Beverage( "Coffee",22.00M);
            Drinkable coffeeAddSugar = new Condiment(coffee, "Sugar", 1.00M);
            coffeeAddSugar.accumulatePrice();
            actual = coffee.getPrice() + " + " + coffeeAddSugar.getPrice() + coffeeAddSugar.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void MilkTest()
        {
            string expect = "Milk (3.50) | Total=3.50";
            string actual = string.Empty;
            Drinkable milk = new Condiment("Milk",3.50M);
            milk.accumulatePrice();
            actual = milk.getPrice() + milk.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LemonAddLoversEmbraceTest()
        {
            string expect = "Lemon (5.00) + LoversEmbrace (21.00*80%) | Total=21.80";
            string actual = string.Empty;
            Drinkable lemon = new Condiment("Lemon",5.00M);
            Drinkable lemonAddLoversEmbrace = new Condiment(lemon, "LoversEmbrace", 21.00M, 0.80M);
            lemonAddLoversEmbrace.accumulatePrice();
            actual = lemon.getPrice() + " + " + lemonAddLoversEmbrace.getPrice() + lemonAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void specialWeekTest()
        {
            DateTime nowTime = Convert.ToDateTime("2013/11/1");
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) + LoversEmbrace (21.00*50%) | Total=63.50*90%=57.15";
            string actual = string.Empty;
            Drinkable loveFeelings = new Beverage("LoveFeelings",49.00M);
            Drinkable loveFeelingsAddLemon = new Condiment(loveFeelings, "Lemon", 5.00M, 0.80M);
            Drinkable lemonAddLoversEmbrace = new Condiment(loveFeelingsAddLemon, "LoversEmbrace", 21.00M, 0.50M, nowTime);
            lemonAddLoversEmbrace.accumulatePrice();
            actual = loveFeelings.getPrice() + " + " + loveFeelingsAddLemon.getPrice() + " + " + lemonAddLoversEmbrace.getPrice() + lemonAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }
    }
}
