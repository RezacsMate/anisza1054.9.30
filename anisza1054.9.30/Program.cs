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
    
};
            hotels[0].SetPricePerNight(68000);
            hotels[1].SetPricePerNight(32000);
            hotels[2].SetPricePerNight(54000);
            hotels[4].SetPricePerNight(82000);
            hotels[5].SetPricePerNight(46000);
            hotels[6].SetPricePerNight(28000);
            
            
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
            

            series[0].setRating(8.7);
            series[1].setRating(8.8);
            series[2].setRating(8.6);
            series[3].setRating(8.1);
            series[4].setRating(8.5);
            
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
            Console.WriteLine("--------------");
            List<Course> courses = new List<Course>()
{
    new Course("CSharp Basics", "Programming", "Kovacs Adam"),
    new Course("Advanced CSharp", "Programming", "Nagy Peter"),
    new Course("Python Basics", "Programming", "Szabo Anna"),
    new Course("Web Development", "Programming", "Toth Mark"),
    new Course("English Beginner", "Language", "Smith John"),
    new Course("English Advanced", "Language", "Smith John"),
    new Course("German Beginner", "Language", "Muller Anna"),
    new Course("Excel Basics", "Office", "Kiss Eva"),
    new Course("Advanced Excel", "Office", "Kiss Eva"),
    new Course("PowerPoint Master", "Office", "Horvath Bela"),
    new Course("Digital Marketing", "Marketing", "Varga Nora"),
    new Course("Social Media Marketing", "Marketing", "Varga Nora"),
    new Course("Sales Basics", "Business", "Farkas David"),
    new Course("Leadership", "Business", "Molnar Peter"),
    new Course("Finance Basics", "Business", "Farkas David")
};
            courses[0].AddStudent(24);
            courses[1].AddStudent(18);
            courses[2].AddStudent(31);
            courses[3].AddStudent(27);
            courses[4].AddStudent(35);
            courses[5].AddStudent(21);
            courses[6].AddStudent(28);
            courses[7].AddStudent(40);
            courses[8].AddStudent(26);
            courses[9].AddStudent(19);
            courses[10].AddStudent(22);
            courses[11].AddStudent(29);
            courses[12].AddStudent(33);
            courses[13].AddStudent(17);
            courses[14].AddStudent(25);
            courses[0].addPrice(25000);
            courses[1].addPrice(35000);
            courses[2].addPrice(22000);
            courses[3].addPrice(30000);
            courses[4].addPrice(18000);
            courses[5].addPrice(24000);
            courses[6].addPrice(19000);
            courses[7].addPrice(15000);
            courses[8].addPrice(23000);
            courses[9].addPrice(17000);
            courses[10].addPrice(28000);
            courses[11].addPrice(26000);
            courses[12].addPrice(21000);
            courses[13].addPrice(32000);
            courses[14].addPrice(27000);

            // LINQ segítségével Category szerint csoportosítsd a kurzusokat,
            // majd add vissza kategóriánként a tanulók összesített számát!
            foreach (KeyValuePair<string, int> x in courses.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.Sum(x => x.getStudentCount())).ToList()) 
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }



            // LINQ segítségével Teacher szerint csoportosítsd a kurzusokat,
            // majd add vissza oktatónként, hogy hány kurzust tart!
            foreach (KeyValuePair<string, int> x in courses.GroupBy(x => x.Teacher).ToDictionary(x => x.Key, x => x.Count()).ToList())
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }


            // LINQ segítségével Category szerint csoportosítsd a kurzusokat,
            // majd keresd meg minden kategóriában a legdrágább kurzus Name értékét!
            foreach (KeyValuePair<string, string> x in courses.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.OrderByDescending(x => x.TotalRevenue()).First().Name).ToList())
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

            // LINQ segítségével Teacher szerint csoportosítsd a kurzusokat,
            // majd keresd meg azt az oktatót,
            // akinek a kurzusaira összesen a legtöbb tanuló jár!
            Console.WriteLine(
                courses.GroupBy(x => x.Teacher).OrderByDescending(x => x.Sum(x => x.getStudentCount())).ToDictionary(x => x.Key, x => x.Sum(x => x.getStudentCount())).First().Key
            );

            Console.WriteLine("--------------");
            List<Game> games = new List<Game>()
{
    new Game("The Witcher 3", "RPG", "CD Projekt"),
    new Game("Cyberpunk 2077", "RPG", "CD Projekt"),
    new Game("Thronebreaker", "RPG", "CD Projekt"),
    new Game("GTA V", "Action", "Rockstar Games"),
    new Game("Red Dead Redemption 2", "Action", "Rockstar Games"),
    new Game("Max Payne 3", "Action", "Rockstar Games"),
    new Game("FIFA 23", "Sports", "Electronic Arts"),
    new Game("Battlefield 2042", "Shooter", "Electronic Arts"),
    new Game("Need for Speed Heat", "Racing", "Electronic Arts"),
    new Game("The Sims 4", "Simulation", "Electronic Arts"),
    new Game("God of War", "Action", "Sony"),
    new Game("God of War Ragnarok", "Action", "Sony"),
    new Game("Gran Turismo 7", "Racing", "Sony"),
    new Game("Spider Man 2", "Action", "Sony"),
    new Game("Super Mario Odyssey", "Platformer", "Nintendo"),
    new Game("Mario Kart 8 Deluxe", "Racing", "Nintendo"),
    new Game("Pokemon Scarlet", "RPG", "Nintendo"),
    new Game("Super Smash Bros Ultimate", "Fighting", "Nintendo")
};
            games[0].SetPrice(11990);
            games[1].SetPrice(19990);
            games[2].SetPrice(6990);
            games[3].SetPrice(9990);
            games[4].SetPrice(18990);
            games[5].SetPrice(5990);
            games[6].SetPrice(12990);
            games[7].SetPrice(15990);
            games[8].SetPrice(10990);
            games[9].SetPrice(4990);
            games[10].SetPrice(13990);
            games[11].SetPrice(22990);
            games[12].SetPrice(20990);
            games[13].SetPrice(23990);
            games[14].SetPrice(17990);
            games[15].SetPrice(18990);
            games[16].SetPrice(19990);
            games[17].SetPrice(19990);
            games[0].SetRating(9.7);
            games[1].SetRating(8.6);
            games[2].SetRating(8.1);
            games[3].SetRating(9.4);
            games[4].SetRating(9.6);
            games[5].SetRating(8.5);
            games[6].SetRating(7.4);
            games[7].SetRating(6.8);
            games[8].SetRating(7.8);
            games[9].SetRating(8.0);
            games[10].SetRating(9.5);
            games[11].SetRating(9.4);
            games[12].SetRating(8.7);
            games[13].SetRating(9.0);
            games[14].SetRating(9.6);
            games[15].SetRating(9.3);
            games[16].SetRating(7.5);
            games[17].SetRating(9.2);
            // LINQ segítségével Publisher szerint csoportosítsd a játékokat,
            // majd add vissza kiadónként, hogy hány játék tartozik az adott kiadóhoz!
            foreach (KeyValuePair<string, int> x in games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x.Count()))
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

            // LINQ segítségével Genre szerint csoportosítsd a játékokat,
            // majd add vissza műfajonként a játékok átlagos árát!
            foreach (KeyValuePair<string, double> x in games.GroupBy(x => x.Genre).ToDictionary(x => x.Key, x => x.Average(y => y.getPrice())))
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

            // LINQ segítségével Publisher szerint csoportosítsd a játékokat,
            // majd keresd meg minden kiadó legjobb értékelésű játékának Title értékét!
            foreach (KeyValuePair<string, string> x in games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x.OrderByDescending(y => y.getRating()).First().Title))
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

            // LINQ segítségével Genre szerint csoportosítsd a játékokat,
            // majd keresd meg azt a műfajt,
            // amelynek a legmagasabb az átlagos értékelése!
            Console.WriteLine(
                games.GroupBy(x => x.Genre).OrderByDescending(x => x.Average(y => y.getRating())).ToDictionary(x => x.Key, x => x.Average(y => y.getRating())).First().Key
            );

            // LINQ segítségével Publisher szerint csoportosítsd a játékokat,
            // számítsd ki kiadónként a játékok összesített árát,
            // majd rendezd a kiadókat az összesített ár szerint csökkenő sorrendbe!
            foreach (KeyValuePair<string, int> x in games.GroupBy(x => x.Publisher).OrderByDescending(x=>x.Sum(x=>x.getPrice())).ToDictionary(x => x.Key, x => x.Sum(y => y.getPrice())))
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }

        }
    }
}
