using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CalculateLibrary
{
    public class GeneralBooksStrategy : PriceStrategy
    {

        public GeneralBooksStrategy(List<Book> books)
            : base(books)
        {
            //無折
            base.discount = 1;
        }

        public override int SumPrice()
        {
            return (int)(_books.Sum(c => c.UnitPrice) * discount);
        }
    }
}
