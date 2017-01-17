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
    public class GeneralBooksStrategyTests
    {

        [TestMethod()]
        public void 兩本書無則扣價位運算_200()
        {
            var Books = new List<Book>()
            {
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100},
                new Book(){ Name = "Harry", Episode = 1, Count = 1, UnitPrice = 100}

            };
            var target = new GeneralBooksStrategy(Books);
            var excepted = 200;

            var actual = target.SumPrice();

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
