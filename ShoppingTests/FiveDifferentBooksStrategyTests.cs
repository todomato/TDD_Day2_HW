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
    public class FiveDifferentBooksStrategyTests
    {
        [TestMethod()]
        public void 五本書_七五扣價位運算_375()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100}
            };
            var target = new FiveDifferentBooksStrategy(Books);
            var excepted = 375;

            var actual = target.SumPrice();

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
