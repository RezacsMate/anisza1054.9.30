using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    internal record Restaurant(string Name, string City, string Category)
    {
        private int _averigePrice { get; set; }
        private double _rating{ get; set; }
        // Készíts egy public függvényt, amely paraméterként kap egy új értékelést!

        // Csak akkor módosítsa a Rating értékét, ha az új érték 0 és 10 közé esik!
        public void setRating(double newrating) 
        {
            _rating = newrating >= 0.0&& newrating <=10? newrating : _rating;
        }
        // Készíts egy public függvényt, amely eldönti,
        // hogy az étterem drágának számít-e!
        // Egy étterem akkor számít drágának, ha az AveragePrice legalább 12000 Ft.
        public bool IsExpensive() 
        {
            return _averigePrice >= 1200;
        }
        public void SetPrice(int price)
        {
            _averigePrice = price;
        }
        public double Getrating()
        {
            return _rating;
        }
        public int G()
        {
            return _rating;
        }
    }
}
