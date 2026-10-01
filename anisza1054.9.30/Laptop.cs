using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    internal record Laptop(string Brand, string Model, string Processor)
    {
        private int _price { get; set; }
        private string _processor { get; set; }
        public int Memory { get; set; }

        public string GetProcess()
        {
            return _processor;
        }
        public void SetPrice(int newprice) 
        {
            _price = newprice;
        }
        public int GetPrice() 
        {
            return _price;
        }
    }

}
