using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class FourDifferentBooksStrategy : PriceStrategy
    {

        public FourDifferentBooksStrategy(List<Book> books)
            : base(books)
        {
            //八折
            base.discount = 0.8;
        }

        public override int SumPrice()
        {
            return (int)(_books.Sum(c => c.UnitPrice) * discount);
        }
    }
}
