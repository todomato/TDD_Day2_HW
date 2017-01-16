using System.Collections.Generic;

namespace HarryBooks
{
    public class ShoppingCar
    {
        private List<Shopping.Book> Books;

        public ShoppingCar(List<Shopping.Book> Books)
        {
            // TODO: Complete member initialization
            this.Books = Books;
        }

        public int TotalCost { get; set; }

        public int CalculateCost()
        {
            return 0;
        }
    }
}