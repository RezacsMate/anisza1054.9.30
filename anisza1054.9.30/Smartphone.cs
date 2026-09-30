
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    public record Smartphone(string Brand, string Model, int ReleasYear)

    {
        private int _releasYear { get; init; } = ReleasYear;
        private int _price { get; set; }
        public double _rating { get; set; }

        public int GetReleasYear()
        {
            return _releasYear;
        }
        public void SetPrivce(int newPrice) 
        {
            _price  = newPrice;
        }
        public void UpdatePrice(int precent) 
        {
            _price = _price * (precent/100);
        }
        


    }
}
