using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class ThreeDifferentBooksStrategy : PriceStrategy
    {
        public ThreeDifferentBooksStrategy()
        {
            SetDiscount();
        }

        public ThreeDifferentBooksStrategy(List<Book> books) : base(books)
        {
            SetDiscount();
        }

        private void SetDiscount()
        {
            //九折
            base._discount = 0.9;
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
            if (_books.Count() == 3)
            {
                _totalPrice += (int)(_books.Sum(c => c.UnitPrice) * _discount);
                RemoveCalculatedBooks();
                CalculatePrice();
            }
        }
    }
}
