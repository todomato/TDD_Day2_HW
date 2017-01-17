using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;
namespace CalculateLibrary.Tests
{
    [TestClass()]
    public class TwoDifferentBooksStrategyTests
    {
        [TestMethod()]
        public void 兩本書_九五扣價位運算_190()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100}
            };
            var target = new TwoDifferentBooksStrategy(Books);
            var excepted = 190;

            var actual = target.SumPrice();

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
