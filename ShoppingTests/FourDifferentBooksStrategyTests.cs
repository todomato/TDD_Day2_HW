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
    public class FourDifferentBooksStrategyTests
    {
        [TestMethod()]
        public void 四本書_八扣價位運算_320()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100}
            };
            var target = new FourDifferentBooksStrategy(Books);
            var excepted = 320;

            var actual = target.SumPrice();

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
