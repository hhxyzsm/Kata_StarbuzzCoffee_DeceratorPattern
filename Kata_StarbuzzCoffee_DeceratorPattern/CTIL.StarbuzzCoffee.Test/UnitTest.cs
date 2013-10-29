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
        public void BeverageTest()
        {
            string expect = "Coffee (22.00) | Total=22.00";
            string actual = "";
            IDrink coffee = new Beverage(22.00M, "Coffee");
            coffee.decorateDrink();
            actual = coffee.printF() + coffee.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "PlainTea (25.00) | Total=25.00";
            actual = "";
            IDrink plainTea = new Beverage(25.00M, "PlainTea");
            plainTea.decorateDrink();
            actual = plainTea.printF() + plainTea.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "Beer (18.00) | Total=18.00";
            actual = "";
            IDrink beer = new Beverage(18.00M, "Beer");
            beer.decorateDrink();
            actual = beer.printF() + beer.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "Coke (12.00) | Total=12.00";
            actual = "";
            IDrink coke = new Beverage(12.00M, "Coke");
            coke.decorateDrink();
            actual = coke.printF() + coke.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BeverageAddCondimentTest()
        {
            string expect = "Coffee (22.00) + Milk (3.50) | Total=25.50";
            string actual = "";
            IDrink coffee = new Beverage(22.00M, "Coffee");
            IDrink coffeeAddMilk = new Condiment(coffee, 3.50M, "Milk");
            coffeeAddMilk.decorateDrink();
            actual = coffee.printF() + " + " + coffeeAddMilk.printF() + coffeeAddMilk.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "BlackTea (25.00) + Honey (4.50) | Total=29.50";
            actual = "";
            IDrink blackTea = new Beverage(25.00M, "BlackTea");
            IDrink blackTeaAddHoney = new Condiment(blackTea, 4.5M, "Honey");
            blackTeaAddHoney.decorateDrink();
            actual = blackTea.printF() + " + " + blackTeaAddHoney.printF() + blackTeaAddHoney.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "Beer (18.00) + Lemon (5.00) | Total=23.00";
            actual = "";
            IDrink beer = new Beverage(18.00M, "Beer");
            IDrink beerAddLemon = new Condiment(beer, 5.00M, "Lemon");
            beerAddLemon.decorateDrink();
            actual = beer.printF() + " + " + beerAddLemon.printF() + beerAddLemon.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "Coke (12.00) + Lemon (5.00) | Total=17.00";
            actual = "";
            IDrink coke = new Beverage(12.00M, "Coke");
            IDrink cokeAddLemon = new Condiment(coke, 5.00M, "Lemon");
            cokeAddLemon.decorateDrink();
            actual = coke.printF() + " + " + cokeAddLemon.printF() + cokeAddLemon.getTotal();
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void CoffeeAddMilkAddHoney()
        {
            string expect = "Coffee (22.00) + Honey (4.50) + Milk (3.50) | Total=30.00";
            string actual = "";
            IDrink coffee = new Beverage(22.00M, "Coffee");
            IDrink coffeeAddHoney = new Condiment(coffee, 4.50M, "Honey");
            IDrink coffeeAddMilk = new Condiment(coffeeAddHoney, 3.50M, "Milk");
            coffeeAddMilk.decorateDrink();
            actual = coffee.printF() + " + " + coffeeAddHoney.printF() + " + " + coffeeAddMilk.printF() + coffeeAddMilk.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "GreenTea (22.00) + Honey (4.50) + Milk (3.50) + Chocolate (7.00) | Total=37.00";
            actual = "";
            IDrink greenTea = new Beverage(22.00M, "GreenTea");
            IDrink greenTeaAddHoney = new Condiment(greenTea, 4.50M, "Honey");
            IDrink greenTeaAddMilk = new Condiment(greenTeaAddHoney, 3.50M, "Milk");
            IDrink greenTeaAddChocolate = new Condiment(greenTeaAddMilk, 7.00M, "Chocolate");
            greenTeaAddChocolate.decorateDrink();
            actual = greenTea.printF() + " + " + greenTeaAddHoney.printF() + " + " + greenTeaAddMilk.printF() + " + " + greenTeaAddChocolate.printF() + greenTeaAddChocolate.getTotal();
            Assert.AreEqual(expect, actual);

            expect = "Coke (12.00) + Milk (3.50) + Honey (4.50) + Lemon (5.00) + Chocolate (7.00) + Mocha (8.00) | Total=40.00";
            actual = "";
            IDrink coke = new Beverage(12.00M, "Coke");
            IDrink cokeAddMilk = new Condiment(coke, 3.50M, "Milk");
            IDrink cokeAddHoney = new Condiment(cokeAddMilk, 4.50M, "Honey");
            IDrink cokeAddLemon = new Condiment(cokeAddHoney, 5.00M, "Lemon");
            IDrink cokeAddChocolate = new Condiment(cokeAddLemon, 7.00M, "Chocolate");
            IDrink cokeAddMocha = new Condiment(cokeAddChocolate, 8.00M, "Mocha");
            cokeAddMocha.decorateDrink();
            actual = coke.printF() + " + " + cokeAddMilk.printF() + " + " + cokeAddHoney.printF()
                + " + " + cokeAddLemon.printF() + " + " + cokeAddChocolate.printF()
                + " + " + cokeAddMocha.printF() + cokeAddMocha.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelings()
        {
            string expect = "LoveFeelings (49.00) | Total=49.00";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            loveFeelings.decorateDrink();
            actual = loveFeelings.printF() + loveFeelings.getTotal();
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void LoveFeelingsAddLemon()
        {
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) | Total=53.00";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            IDrink loveFeelingsAddLemon = new Condiment(loveFeelings, 5.0M, 0.80M, "Lemon");
            loveFeelingsAddLemon.decorateDrink();
            actual = loveFeelings.printF() + " + " + loveFeelingsAddLemon.printF() + loveFeelingsAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddAll()
        {
            string expect = "LoveFeelings (49.00) + Honey (4.50*80%) + Milk (3.50*80%) + Chocolate (7.00*80%) + Mocha (8.00*80%) + Lemon (5.00*80%) | Total=71.40";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            IDrink loveFeelingsAddHoney = new Condiment(loveFeelings, 4.50M, 0.80M, "Honey");
            IDrink loveFeelingsAddMilk = new Condiment(loveFeelingsAddHoney, 3.50M, 0.80M, "Milk");
            IDrink loveFeelingsAddChocolate = new Condiment(loveFeelingsAddMilk, 7.00M, 0.80M, "Chocolate");
            IDrink loveFeelingsAddMocha = new Condiment(loveFeelingsAddChocolate, 8.00M, 0.80M, "Mocha");
            IDrink loveFeelingsAddLemon = new Condiment(loveFeelingsAddMocha, 5.00M, 0.80M, "Lemon");
            loveFeelingsAddLemon.decorateDrink();
            actual = loveFeelings.printF() + " + " + loveFeelingsAddHoney.printF() + " + " +
                loveFeelingsAddMilk.printF() + " + " + loveFeelingsAddChocolate.printF() + " + " +
                loveFeelingsAddMocha.printF() + " + " + loveFeelingsAddLemon.printF() +
                loveFeelingsAddLemon.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void BeerAddLoversEmbrace()
        {
            string expect = "Beer (18.00) + LoversEmbrace (21.00*80%) | Total=34.80";
            string actual = "";
            IDrink beer = new Beverage(18.00M, "Beer");
            IDrink beerAddLoversEmbrace = new Condiment(beer, 21.00M, 0.80M, "LoversEmbrace");
            beerAddLoversEmbrace.decorateDrink();
            actual = beer.printF() + " + " + beerAddLoversEmbrace.printF() + beerAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddLoversEmbrace()
        {
            string expect = "LoveFeelings (49.00) + LoversEmbrace (21.00*50%) | Total=59.50";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            IDrink loveFeelingsAddLoversEmbrace = new Condiment(loveFeelings, 21.00M, 0.50M, "LoversEmbrace");
            loveFeelingsAddLoversEmbrace.decorateDrink();
            actual = loveFeelings.printF() + " + " + loveFeelingsAddLoversEmbrace.printF() + loveFeelingsAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoveFeelingsAddLemonAddLoversEmbrace()
        {
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) + LoversEmbrace (21.00*50%) | Total=63.50";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            IDrink loveFeelingsAddLemon = new Condiment(loveFeelings, 5.00M, 0.80M, "Lemon");
            IDrink loveFeelingsAddLoversEmbrace = new Condiment(loveFeelingsAddLemon, 21.00M, 0.50M, "LoversEmbrace");
            loveFeelingsAddLoversEmbrace.decorateDrink();
            actual = loveFeelings.printF() + " + " + loveFeelingsAddLemon.printF() + " + " + loveFeelingsAddLoversEmbrace.printF() + loveFeelingsAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void CoffeeAddSugar()
        {
            string expect = "Coffee (22.00) + Sugar (1.00) | Total=23.00";
            string actual = "";
            IDrink coffee = new Beverage(22.00M, "Coffee");
            IDrink coffeeAddSugar = new Condiment(coffee, 1.00M, "Sugar");
            coffeeAddSugar.decorateDrink();
            actual = coffee.printF() + " + " + coffeeAddSugar.printF() + coffeeAddSugar.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void OneMilk()
        {
            string expect = "Milk (3.50) | Total=3.50";
            string actual = "";
            IDrink milk = new Condiment(3.50M, "Milk");
            milk.decorateDrink();
            actual = milk.printF() + milk.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LemonAddLoversEmbrace()
        {
            string expect = "Lemon (5.00) + LoversEmbrace (21.00*80%) | Total=21.80";
            string actual = "";
            IDrink lemon = new Condiment(5.00M, "Lemon");
            IDrink lemonAddLoversEmbrace = new Condiment(lemon, 21.00M, 0.80M, "LoversEmbrace");
            lemonAddLoversEmbrace.decorateDrink();
            actual = lemon.printF() + " + " + lemonAddLoversEmbrace.printF() + lemonAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Friday()
        {
            DateTime nowTime = Convert.ToDateTime("2013/11/1");
            string expect = "LoveFeelings (49.00) + Lemon (5.00*80%) + LoversEmbrace (21.00*50%) | Total=63.50*90%=57.15";
            string actual = "";
            IDrink loveFeelings = new Beverage(49.00M, "LoveFeelings");
            IDrink loveFeelingsAddLemon = new Condiment(loveFeelings, 5.00M, 0.80M, "Lemon");
            IDrink lemonAddLoversEmbrace = new Condiment(loveFeelingsAddLemon, 21.00M, 0.50M, "LoversEmbrace", nowTime);
            lemonAddLoversEmbrace.decorateDrink();
            actual = loveFeelings.printF() + " + " + loveFeelingsAddLemon.printF() + " + " + lemonAddLoversEmbrace.printF() + lemonAddLoversEmbrace.getTotal();
            Assert.AreEqual(expect, actual);
        }
    }
}
