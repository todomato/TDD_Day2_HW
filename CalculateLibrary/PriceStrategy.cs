using System.Collections.Generic;
using System.Linq;

namespace CalculateLibrary
{
    public abstract class PriceStrategy
    {
        protected List<Book> _books;
        protected double _discount { get; set; }
        protected int _totalPrice { get; set; }
        protected PriceStrategy _nextStrategy { get; set; }

        public PriceStrategy()
        {
        }

        public PriceStrategy(List<Book> books)
        {
            _books = books;
        }

        /// <summary>
        /// 價位加總策略
        /// </summary>
        /// <returns></returns>
        public abstract int SumPrice();

        /// <summary>
        /// 設定下一個策略執行者
        /// </summary>
        /// <param name="strategy"></param>
        public void SetNextStrategy(PriceStrategy strategy)
        {
            _nextStrategy = strategy;
        }

        /// <summary>
        /// 移除已計算的書籍,然後繼續運算(遞迴)
        /// </summary>
        protected void RemoveCalculatedBooks()
        {
            foreach (var item in _books)
            {
                item.Count += -1;
            }
            _books = _books.Where(c => c.Count != 0).ToList();
        }

        /// <summary>
        /// 設定當前Books
        /// </summary>
        /// <returns></returns>
        public void SetBooks(List<Book> books, int totalPrice)
        {
            _books = books;
            _totalPrice = totalPrice;
        }

    }
}