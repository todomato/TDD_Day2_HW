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
            // 不同集數數量
            var differentCount = _books.Count();

            // 打折邏輯
            if (differentCount == 5)
            {
                SumPrice(_books.Select(c => c.Episode), 0.75);
                RemoveCalculatedBooks();
            }
            else if (differentCount == 4)
            {
                SumPrice(_books.Select(c => c.Episode), 0.8);
                RemoveCalculatedBooks();
            }
            else if (differentCount == 3)
            {
                SumPrice(_books.Select(c => c.Episode), 0.9);
                RemoveCalculatedBooks();
            }
            else if (differentCount == 2)
            {
                SumPrice(_books.Select(c => c.Episode), 0.95);
                RemoveCalculatedBooks();
            }
            else if (differentCount == 1)
            {
                SumPrice(_books.Select(c => c.Episode), 1);
            }
        }


        /// <summary>
        /// 移除已計算的書籍,然後繼續運算(遞迴)
        /// </summary>
        private void RemoveCalculatedBooks()
        {
            foreach (var item in _books)
            {
                item.Count += -1;
            }
            _books = _books.Where(c => c.Count != 0).ToList();
            CalculateCost();
        }

        /// <summary>
        /// 加總價錢並計算折扣
        /// </summary>
        /// <param name="enumerable">加總數列</param>
        /// <param name="discount">折扣</param>
        private void SumPrice(IEnumerable<int> enumerable, double discount)
        {
            _totalCost += (int)(_books.Sum(c => c.UnitPrice) * discount);
        }

   
    }
}