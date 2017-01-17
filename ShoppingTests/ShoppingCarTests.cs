using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;
using System.Collections.Generic;
using ExpectedObjects;

namespace HarryBooks.Tests
{
    [TestClass()]
    public class ShoppingCarTests
    {
        [TestMethod()]
        public void Buy_1_First_Episode_Price_Should_100()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100}
            };
            var shoppingCar = new ShoppingCar(Books);
            var excepted = 100;
            
            shoppingCar.CalculateCost();

            excepted.ToExpectedObject().ShouldEqual(shoppingCar.TotalCost);
        }

        [TestMethod()]
        public void Buy_1_First_Episode_And_Second_Episode_Price_Should_190()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 2, Count = 1, UnitPrice = 100}
            };
            var shoppingCar = new ShoppingCar(Books);
            var excepted = 190;

            shoppingCar.CalculateCost();

            excepted.ToExpectedObject().ShouldEqual(shoppingCar.TotalCost);
        }

        [TestMethod()]
        public void Buy_1_First_Episode_And_Second_Episode_And_Second_Episode_Price_Should_270()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 2, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 3, Count = 1, UnitPrice = 100}
            };
            var shoppingCar = new ShoppingCar(Books);
            var excepted = 270;

            shoppingCar.CalculateCost();

            excepted.ToExpectedObject().ShouldEqual(shoppingCar.TotalCost);
        }
    }
}