using Shopping;
using System.Collections.Generic;

namespace HarryBooks
{
    public class ShoppingCar
    {
        private List<Book> _books;
        private int _totalCost;

        public ShoppingCar(List<Book> Books)
        {
            // TODO: Complete member initialization
            this._books = Books;
        }

        public int TotalCost { get { return _totalCost; } }

        public void CalculateCost()
        {
            // 買一本無折扣
            if (_books.Count == 1)
            {
                _totalCost = _books[0].UnitPrice;
            }

            // 買兩本不同書折扣95折
            if (_books.Count == 2)
            {
                if (_books[0].Episode == _books[1].Episode)
                {
                    _totalCost = _books[0].UnitPrice + _books[1].UnitPrice;
                }
                else
                {
                    //小數無條件捨去
                    _totalCost = (int)((_books[0].UnitPrice + _books[1].UnitPrice) * 0.95);
                }
            }

        }
    }
}