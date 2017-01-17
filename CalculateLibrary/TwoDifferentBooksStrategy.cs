using System.Collections.Generic;
using System.Linq;

namespace CalculateLibrary
{
    public class TwoDifferentBooksStrategy : PriceStrategy
    {
        public TwoDifferentBooksStrategy()
        {
            SetDicount();
        }

        public TwoDifferentBooksStrategy(List<Book> books)
            : base(books)
        {
            SetDicount();
        }

        private void SetDicount()
        {
            //九五折
            base._discount = 0.95;
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
            if (_books.Count() == 2)
            {
                _totalPrice += (int)(_books.Sum(c => c.UnitPrice) * _discount);
                RemoveCalculatedBooks();
                CalculatePrice();
            }
        }
    }
}