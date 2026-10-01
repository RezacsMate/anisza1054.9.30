using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    internal record Series(string Title, string Genre, string Studio)
    {
        private int _episodes { get; set; } =0;
        private double _rating { get; set; }

        // Készíts egy public függvényt, amely paraméterként kap egy epizódszámot,
        // és hozzáadja azt az Episodes jelenlegi értékéhez!
        public void AddEpis(int episode) 
        {
;           _episodes += episode;
        }
        // Készíts egy public függvényt, amely eldönti,
        // hogy a sorozat hosszúnak számít-e!
        // Egy sorozat akkor számít hosszúnak, ha legalább 40 epizódból áll.
        public bool IsLong() 
        {
            return _episodes > 40? true: false;
        }
        public void setRating(double rating) 
        {
            _rating = rating;
        }
        public int getEpiode() 
        {
            return _episodes;
        }
        public double getRationg()
        {
            return _rating;
        }
        
    }
}
