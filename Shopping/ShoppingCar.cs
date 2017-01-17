using CalculateLibrary;
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

            // 責任鏈概念，先判斷5->4->3->2本書是否不同
            PriceStrategy fiveDifferentBooksStrategy = new FiveDifferentBooksStrategy(_books);
            PriceStrategy fourDifferentBooksStrategy = new FourDifferentBooksStrategy();
            PriceStrategy threeDifferentBooksStrategy = new ThreeDifferentBooksStrategy();
            PriceStrategy twoDifferentBooksStrategy = new TwoDifferentBooksStrategy();
            PriceStrategy generalBooksStrategy = new GeneralBooksStrategy();

            // 設定責任鏈
            fiveDifferentBooksStrategy.SetNextStrategy(fourDifferentBooksStrategy);
            fourDifferentBooksStrategy.SetNextStrategy(threeDifferentBooksStrategy);
            threeDifferentBooksStrategy.SetNextStrategy(twoDifferentBooksStrategy);
            twoDifferentBooksStrategy.SetNextStrategy(generalBooksStrategy);

            _totalCost += fiveDifferentBooksStrategy.SumPrice();
           
        }
    }
}