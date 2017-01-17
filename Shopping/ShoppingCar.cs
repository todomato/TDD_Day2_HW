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

        public int CalculateCost()
        {
            // 買一本無折扣
            if (_books.Count == 1)
	        {
                _totalCost = _books[0].UnitPrice;    
	        }

            return 0;
        }
    }
}