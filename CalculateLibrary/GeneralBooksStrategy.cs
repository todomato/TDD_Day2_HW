using System.Collections.Generic;
using System.Linq;

namespace CalculateLibrary
{
    public class GeneralBooksStrategy : PriceStrategy
    {
        public GeneralBooksStrategy()
        {
            SetDiscount();
        }

        public GeneralBooksStrategy(List<Book> books)
            : base(books)
        {
            SetDiscount();
        }

        private void SetDiscount()
        {
            //無折
            base._discount = 1;
        }

        public override int SumPrice()
        {
             _totalPrice += (int)(_books.Sum(c => c.UnitPrice) * _discount);

            return _totalPrice;
        }
    }
}