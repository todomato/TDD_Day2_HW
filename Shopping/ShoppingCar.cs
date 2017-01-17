using Shopping;
using System.Collections.Generic;
using System.Linq;

namespace HarryBooks
{
    public class ShoppingCar
    {
        private List<Book> _books;
        private int _totalCost;

        public ShoppingCar(List<Book> Books)
        {
            this._books = Books;
        }

        public int TotalCost { get { return _totalCost; } }

        public void CalculateCost()
        {
            // 買一本無折扣
            if (_books.Count == 1)
            {
                SumPrice(_books.Select(c => c.Episode), 1);
            }

            // 買兩本不同書折扣95折
            if (_books.Count == 2)
            {
                if (_books[0].Episode == _books[1].Episode)
                {
                    SumPrice(_books.Select(c => c.Episode), 1);
                }
                else
                {
                    SumPrice(_books.Select(c => c.Episode), 0.95);
                }
            }

            // 三本不同9折
            if (_books.Count == 3)
            {
                if (_books[0].Episode != _books[1].Episode &&
                    _books[1].Episode != _books[2].Episode &&
                    _books[2].Episode != _books[0].Episode)
                {
                    SumPrice(_books.Select(c => c.Episode), 0.9);
                }
                else
                {
                    //判斷兩本相同&三本相同
                }
            }

        }


        /// <summary>
        /// 加總價錢並計算折扣
        /// </summary>
        /// <param name="enumerable">加總數列</param>
        /// <param name="discount">折扣</param>
        private void SumPrice(IEnumerable<int> enumerable, double discount)
        {
            _totalCost = (int)(_books.Sum(c => c.UnitPrice) * discount);
        }

   
    }
}