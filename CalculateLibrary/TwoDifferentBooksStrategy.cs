using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class TwoDifferentBooksStrategy : PriceStrategy
    {

        public TwoDifferentBooksStrategy(List<Book> books)
            : base(books)
        {
            //九五折
            base.discount = 0.95;
        }

        public override int SumPrice()
        {
            return (int)(_books.Sum(c => c.UnitPrice) * discount);
        }
    }
}
