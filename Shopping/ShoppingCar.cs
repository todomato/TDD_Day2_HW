
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CalculateLibrary;

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

            // TODO 責任鏈概念，先判斷5->4->3->2本書是否不同
            // 打折邏輯
            if (differentCount == 5)
            {
                //負責處理五筆不同
                PriceStrategy priceStrategy = new FiveDifferentBooksStrategy(_books);
                _totalCost += priceStrategy.SumPrice();
                RemoveCalculatedBooks();
            }
            else if (differentCount == 4)
            {
                //負責處理四筆不同
                PriceStrategy priceStrategy = new FourDifferentBooksStrategy(_books);
                _totalCost += priceStrategy.SumPrice();

                RemoveCalculatedBooks();
            }
            else if (differentCount == 3)
            {
                //負責處理三筆不同
                PriceStrategy priceStrategy = new ThreeDifferentBooksStrategy(_books);
                _totalCost += priceStrategy.SumPrice();

                RemoveCalculatedBooks();
            }
            else if (differentCount == 2)
            {
                //負責處理二筆不同
                PriceStrategy priceStrategy = new TwoDifferentBooksStrategy(_books);
                _totalCost += priceStrategy.SumPrice();

                RemoveCalculatedBooks();
            }
            else if (differentCount == 1)
            {
                PriceStrategy priceStrategy = new GeneralBooksStrategy(_books);
                _totalCost += priceStrategy.SumPrice();

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
     
   
    }
}