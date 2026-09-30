namespace anisza1054._9._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friend!");
            List<Smartphone> smartphones = new List<Smartphone>()
{
    new Smartphone("Samsung", "Galaxy S24", 2024){ _rating=9.1 },
    new Smartphone("Apple", "iPhone 15", 2023) { _rating = 9.3 },
    new Smartphone("Xiaomi", "Redmi Note 13", 2024) { _rating = 8.4 },
    new Smartphone("Google", "Pixel 8", 2023) { _rating = 9.0 },
    new Smartphone("Samsung", "Galaxy A55", 2024) { _rating = 8.6 },
    new Smartphone("OnePlus", "OnePlus 12", 2024) { _rating = 8.9 },
    new Smartphone("Apple", "iPhone 14", 2022) { _rating = 8.8 },
    new Smartphone("Xiaomi", "Xiaomi 14", 2024) { _rating = 9.2 }   
};
            smartphones[0].SetPrivce(329000);
            smartphones[1].SetPrivce(349000);
            smartphones[2].SetPrivce(119000);
            smartphones[3].SetPrivce(279000);
            smartphones[4].SetPrivce(299000);
            smartphones[5].SetPrivce(169000);
            smartphones[6].SetPrivce(289000);
            smartphones[7].SetPrivce(319000);
            Console.WriteLine("--------------");

            smartphones.Where(x => x.GetReleasYear() == 2024).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            Console.WriteLine(smartphones.OrderByDescending(x => x._rating).Select(x => x.Model).First().ToList());
            

            Console.WriteLine("--------------");
            int CountBrand(string brand)
        {
                return smartphones.Where(x => x.Brand == brand).Count();
        }
            Console.WriteLine(CountBrand("samsung"));
        Console.WriteLine("--------------");


            List<Hotel> hotels = new List<Hotel>()
{
    new Hotel("Grand Palace", "Budapest", 5) { Rating = 9.4},
    new Hotel("City Hotel", "Budapest", 3) { Rating = 9.4},
    new Hotel("Blue Sea Resort", "Split", 4 ) { Rating = 9.1},
    new Hotel("Royal Beach", "Barcelona", 5) { Rating = 9.3},
    new Hotel("Mountain View", "Salzburg", 4 ) { Rating = 8.8},
    new Hotel("Central Stay", "Prague", 3 ) { Rating =8.5},
    new Hotel("Luxury Garden", "Vienna", 5) { Rating = 9.2},
    new Hotel("Sunset Hotel", "Split", 4) { Rating = 8.9}
};
            hotels[0].SetPricePerNight(68000);
            hotels[1].SetPricePerNight(32000);
            hotels[2].SetPricePerNight(54000);
            hotels[4].SetPricePerNight(82000);
            hotels[5].SetPricePerNight(46000);
            hotels[6].SetPricePerNight(28000);
            hotels[7].SetPricePerNight(75000);
            hotels[8].SetPricePerNight(49000);
            Console.WriteLine(hotels.OrderBy(x => x.SummPrice(1)).Select(x => x.Name).First());
            
            Console.WriteLine("--------------");
            List<string> InCity(string city) 
            {
                return hotels.Where(x=>x.City == city).Select(x => x.Name).ToList();
            }
            InCity("Budapest").ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");

        }
    }
}
