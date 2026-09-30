using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    internal record Hotel(string Name, string City, int Stars)
    {
        private int _stars { get; init; } = Stars;
        private int _pricePerNight { get; set; }
        public double Rating { get; set; }

        public bool IsStar()
        {
            return _stars >=4;
        }
        public void SetPricePerNight(int price)
        { 
            _pricePerNight = price;
        }

        public int SummPrice(int night) 
        {
            return _pricePerNight * night;
        }
            }

}
