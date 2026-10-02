using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    // A record az alábbi adatokat tárolja:
    // - Title : string – public, immutable
    // - Genre : string – public, immutable
    // - Publisher : string – public, immutable
    // - Price : int – private, mutable
    // - Rating : double – private, mutable
    internal record Game(string Title, string Genre, string Publisher)
    {
        private int _price { get; set; }
        private double _rating { get; set; }

        // Készíts egy public függvényt, amely paraméterként kap egy százalékos kedvezményt,
        // és ennek megfelelően csökkenti a játék Price értékét!
        public void ApplyDiscount(double discountPercentage) 
        {
            
            _price -= (int)(_price * (discountPercentage / 100));
        }

        // Készíts egy public függvényt, amely eldönti,
        // hogy a játék kiemelkedő értékelésű-e!
        // Egy játék akkor kiemelkedő, ha a Rating legalább 9.0.
        public bool IsHighlyRated() 
        {
            return _rating >= 9.0 ? true : false;
        }
        public void SetPrice(int price) 
        {
            _price = price;
        }
        public void SetRating(double rating) 
        {
            _rating = rating;
        }
        public int getPrice() 
        {
            return _price;
        }
        public double getRating() 
        {
            return _rating;
        }
    }
}
