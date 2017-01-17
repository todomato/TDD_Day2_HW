using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class FiveDifferentBooksStrategy : PriceStrategy
    {
        public FiveDifferentBooksStrategy(List<Book> books): base(books)
        {
            //七五折
            base.discount = 0.75;
        }

        public override int SumPrice()
        {
            return (int)(_books.Sum(c => c.UnitPrice) * discount);
        }
    }
}
