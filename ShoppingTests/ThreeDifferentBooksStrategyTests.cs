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
    public class ThreeDifferentBooksStrategyTests
    {
        [TestMethod()]
        public void 三本書_九扣價位運算_270()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 2, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 3, Count = 1, UnitPrice = 100}
            };
            var target = new ThreeDifferentBooksStrategy(Books);
            var excepted = 270;

            var actual = target.SumPrice();

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
