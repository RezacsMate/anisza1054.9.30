using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

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
                return hotels.Where(x => x.City == city).Select(x => x.Name).ToList();
            }
            InCity("Budapest").ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            List<Laptop> laptops = new List<Laptop>()
{
    new Laptop("Lenovo", "ThinkPad E14", "Intel i5"){Memory= 16 },
    new Laptop("Apple", "MacBook Air M3", "Apple M3") { Memory = 16 },
    new Laptop("Asus", "ROG Strix G16", "Intel i7") { Memory = 32 },
    new Laptop("Acer", "Aspire 5", "AMD Ryzen 5") { Memory = 16 },
    new Laptop("HP", "ProBook 450", "Intel i5") { Memory = 16 },
    new Laptop("Dell", "Inspiron 15", "Intel i7") { Memory = 32 },
    new Laptop("Lenovo", "IdeaPad Slim 3", "AMD Ryzen 5") { Memory = 8 },
    new Laptop("Asus", "VivoBook 15", "Intel i5") { Memory = 8 },
    new Laptop("Apple", "MacBook Pro M3", "Apple M3 Pro") { Memory = 36 },
    new Laptop("Acer", "Nitro 5", "Intel i7") { Memory = 32 }
};
            laptops[0].SetPrice(319000);
            laptops[1].SetPrice(489000);
            laptops[2].SetPrice(649000);
            laptops[3].SetPrice(279000);
            laptops[4].SetPrice(349000);
            laptops[5].SetPrice(399000);
            laptops[6].SetPrice(249000);
            laptops[7].SetPrice(289000);
            laptops[8].SetPrice(799000);
            laptops[9].SetPrice(519000);
            Console.WriteLine("--------------");
            Console.WriteLine(laptops.Average(x => x.GetPrice()));
            laptops.Where(x => x.GetPrice() < laptops.Average(x => x.GetPrice())).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine(x));
            List<string> getModels(int minimemory, int maxPrice)
            {
                return laptops.Where(x => x.GetPrice() <= maxPrice && x.Memory >= minimemory).Select(x => x.Model).ToList();
            }
            getModels(16, 4000000).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            laptops.OrderByDescending(x => x.Memory).Select(x => x.Model).First();
            Console.WriteLine(laptops.OrderByDescending(x => x.Memory).Select(x => x.Model).First()
);
            Console.WriteLine("--------------");
            List<Restaurant> restaurants = new List<Restaurant>()
{
    new Restaurant("Bella Italia", "Budapest", "Italian"),
    new Restaurant("Burger House", "Budapest", "Burger"),
    new Restaurant("Sakura", "Budapest", "Japanese"),
    new Restaurant("Pasta Roma", "Rome", "Italian"),
    new Restaurant("Tokyo Garden", "Vienna", "Japanese"),
    new Restaurant("Steak Corner", "Budapest", "Steak"),
    new Restaurant("Pizza Napoli", "Rome", "Italian"),
    new Restaurant("Grill House", "Vienna", "Steak"),
    new Restaurant("Sushi World", "Prague", "Japanese"),
    new Restaurant("Street Burger", "Prague", "Burger")
};
            restaurants[0].SetPrice(8500);
            restaurants[1].SetPrice(5500);
            restaurants[2].SetPrice(12000);
            restaurants[3].SetPrice(9500);
            restaurants[4].SetPrice(13500);
            restaurants[5].SetPrice(15000);
            restaurants[6].SetPrice(7000);
            restaurants[7].SetPrice(14000);
            restaurants[8].SetPrice(11000);
            restaurants[9].SetPrice(5000);
            restaurants[0].setRating(9.1);
            restaurants[0].setRating(8.4);
            restaurants[0].setRating(9.4);
            restaurants[0].setRating(8.9);
            restaurants[0].setRating(9.2);
            restaurants[0].setRating(9.0);
            restaurants[0].setRating(8.7);
            restaurants[0].setRating(8.8);
            restaurants[0].setRating(9.3);
            restaurants[0].setRating(8.2);
            // Készíts egy függvényt, amely paraméterként kap egy kategóriát,
            // és visszaadja az adott kategóriába tartozó éttermek Name értékét!
            List<string> asd(string newCategory)
            {
                return restaurants.Where(x => x.Category == newCategory).Select(x => x.Name).ToList();
            }
            asd("Burger").ForEach(x => Console.WriteLine(x));
            // LINQ segítségével számold meg, hány legalább 9.0 értékelésű étterem található a listában!
            Console.WriteLine(restaurants.Where(x => x.Getrating() >= 9.0).Count());
            // LINQ segítségével keresd meg a legdrágább éttermet,
            // és add vissza annak Name értékét!
            restaurants.OrderByDescending(x => x.Getprice()).Select(x => x.Name).First();
            // LINQ segítségével add vissza a különböző városok neveit!
            // Egy város csak egyszer szerepeljen az eredményben!
            restaurants.Select(x => x.City.Distinct()).ToList();
            Console.WriteLine("--------------");
            List<Series> series = new List<Series>()
{
    new Series("Breaking Bad", "Drama", "AMC" ),
    new Series("Stranger Things", "SciFi", "Netflix"),
    new Series("The Boys", "Action", "Amazon"),
    new Series("Dark", "SciFi", "Netflix"),
    new Series("The Crown", "Drama", "Netflix")
};

            series[0].AddEpis(62);
            series[1].AddEpis(34);
            series[2].AddEpis(32);
            series[3].AddEpis(26);
            series[4].AddEpis(60);
            series[5].setRating(9.5);

            series[0].setRating(8.7);
            series[1].setRating(8.8);
            series[2].setRating(8.6);
            series[3].setRating(8.1);
            series[4].setRating(8.5);
            series[5].setRating(8.4);
            // Készíts egy függvényt, amely paraméterként kap egy stúdiót,
            // és visszaadja az adott stúdióhoz tartozó sorozatok Title értékét!
            List<string> GetTitle(string studio)
            {
                return series.Where(x => x.Studio == studio).Select(x => x.Title).ToList();
            }
            GetTitle("Netflix").ForEach(x => Console.WriteLine(x));
            // LINQ segítségével keresd meg a legtöbb epizóddal rendelkező sorozat Title értékét!
            Console.WriteLine(series.OrderByDescending(x => x.getEpiode()).Select(x => x.Title).First());

            // LINQ segítségével számítsd ki azoknak a sorozatoknak az átlagos értékelését,
            // amelyek legalább 20 epizódból állnak!
            series.Where(x => x.getEpiode() > 20).Average(x => x.getRationg());
            // LINQ segítségével add vissza a különböző műfajokat!
            // Egy műfaj csak egyszer szerepeljen az eredményben!
            series.Select(x => x.Genre.Distinct());
            Console.WriteLine("--------------");
            List<Product> products = new List<Product>()
{
    new Product("Galaxy S24", "Phone", "Samsung"),
    new Product("iPhone 15", "Phone", "Apple"),
    new Product("Pixel 8", "Phone", "Google"),
    new Product("ThinkPad E14", "Laptop", "Lenovo"),
    new Product("MacBook Air", "Laptop", "Apple"),
    new Product("ROG Strix", "Laptop", "Asus"),
    new Product("Galaxy Tab S9", "Tablet", "Samsung"),

};
            products[0].SetPrice(329000);
            products[1].SetPrice(349000);
            products[2].SetPrice(279000);
            products[3].SetPrice(319000);
            products[4].SetPrice(489000);
            products[5].SetPrice(649000);
            products[6].SetPrice(299000);
            products[0].AddStock(15);
            products[1].AddStock(12);
            products[2].AddStock(8);
            products[3].AddStock(10);
            products[4].AddStock(7);
            products[5].AddStock(5);
            products[6].AddStock(9);
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");

            // LINQ segítségével Category szerint csoportosítsd a termékeket,
            // majd add vissza kategóriánként, hogy hány termék tartozik az adott kategóriához!
            foreach (KeyValuePair<string, int> x in products.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.Count()))

            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }
            // LINQ segítségével Manufacturer szerint csoportosítsd a termékeket,
            // majd add vissza gyártónként a termékek átlagos árát!
            foreach (KeyValuePair<string, double> x in products.GroupBy(x => x.Manufactoring).ToDictionary(x => x.Key, x => x.Average(x => x.getPrice()))) 
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }
            // LINQ segítségével Category szerint csoportosítsd a termékeket,
            // majd keresd meg minden kategória legdrágább termékének Name értékét!
            foreach (KeyValuePair<string, string> x in products.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.OrderByDescending(y => y.getPrice()).Select(x => x.Name).First()))
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

            // LINQ segítségével keresd meg azt a kategóriát,
            // amelyhez összesen a legtöbb raktáron lévő termék tartozik!
            Console.WriteLine(
                    products.GroupBy(x => x.Category).OrderByDescending(x => x.Sum(x => x.getStock())).ToDictionary(x => x.Key, x => x.Sum(x => x.getStock())).First().Key
                );
        }
    }
}
