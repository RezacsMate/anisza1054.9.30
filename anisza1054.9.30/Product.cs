using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    internal record Product(string Name, string Category, string Manufactoring)
    {
        private int Price { get; set; }
        private int Stock { get; set; }

        public void AddStock(int stock) 
        {
            Stock += stock;
        }
        public void SetPrice(int price) 
        {
            Price = price;
        }
        public int getStock ()
        {
            return Stock;
         }
        public int getPrice()
        {
            return Price;
        }
        public int sumPrice() 
        {
            return Price * Stock;
        }
    }
}
