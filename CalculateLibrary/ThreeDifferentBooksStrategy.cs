using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class ThreeDifferentBooksStrategy : PriceStrategy
    {

        public ThreeDifferentBooksStrategy(List<Book> books) : base(books)
        {
            //九折
            base.discount = 0.9;
        }

        public override int SumPrice()
        {
            return (int)(_books.Sum(c => c.UnitPrice) * discount);
        }
    }
}
