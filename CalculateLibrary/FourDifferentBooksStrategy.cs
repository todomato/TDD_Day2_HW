using System.Collections.Generic;
using System.Linq;

namespace CalculateLibrary
{
    public class FourDifferentBooksStrategy : PriceStrategy
    {
        public FourDifferentBooksStrategy()
        {
            SetDiscount();
        }

        public FourDifferentBooksStrategy(List<Book> books)
            : base(books)
        {
            SetDiscount();
        }

        private void SetDiscount()
        {
            //八折
            base._discount = 0.8;
        }

        public override int SumPrice()
        {
            CalculatePrice();

            if (base._nextStrategy != null)
            {
                _nextStrategy.SetBooks(_books, _totalPrice);
                _totalPrice = _nextStrategy.SumPrice();
            }

            return _totalPrice;
        }

        private void CalculatePrice()
        {
            if (_books.Count() == 4)
            {
                _totalPrice += (int)(_books.Sum(c => c.UnitPrice) * _discount);
                RemoveCalculatedBooks();
                CalculatePrice();
            }
        }
    }
}