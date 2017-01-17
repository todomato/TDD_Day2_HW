using Shopping;
using System.Collections.Generic;
using System.Diagnostics;
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
            // 用集數分類
            var differentCount = _books.GroupBy(g => g.Episode).Count();

            // 判斷
            if (differentCount == 3)
            {
                SumPrice(_books.Select(c => c.Episode), 0.9);
            }
            else if (differentCount == 2)
            {
                SumPrice(_books.Select(c => c.Episode), 0.95);
            }
            else 
            {
                SumPrice(_books.Select(c => c.Episode), 1);
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