using System.Collections.Generic;
using System.Linq;

namespace CalculateLibrary
{
    public class FiveDifferentBooksStrategy : PriceStrategy
    {
        public FiveDifferentBooksStrategy()
        {
            SetDiscount();
        }

        public FiveDifferentBooksStrategy(List<Book> books)
            : base(books)
        {
            SetDiscount();
        }

        private void SetDiscount()
        {
            //七五折
            base._discount = 0.75;
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
            if (_books.Count() == 5)
            {
                _totalPrice += (int)(_books.Sum(c => c.UnitPrice) * _discount);
                RemoveCalculatedBooks();

                if (_books.Count() == 5)
                {
                    CalculatePrice();
                }
            }
        }

    }
}