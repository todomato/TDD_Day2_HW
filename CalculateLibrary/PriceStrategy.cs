using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public abstract class PriceStrategy
    {
        protected List<Book> _books;
        protected double discount { get; set; }

        public PriceStrategy (List<Book> books)
	    {
            _books = books;
	    }

        public abstract int SumPrice();
        
    
    }
}
