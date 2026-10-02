using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza1054._9._30
{
    // A record az alábbi adatokat tárolja:
    // - Name : string – public, immutable
    // - Category : string – public, immutable
    // - Teacher : string – public, immutable
    // - Price : int – private, mutable
    // - StudentCount : int – private, mutable
    internal record Course(string Name, string Category, string Teacher)
    {
        private int _price { get; set; }
        private int _studentCount { get; set; }

        // Készíts egy public függvényt, amely paraméterként kap egy darabszámot,
        // és hozzáadja azt a StudentCount értékéhez!
        public void AddStudent(int count) 
        {
            _studentCount += count;
        }

        // Készíts egy public függvényt, amely kiszámolja,
        // hogy az adott kurzus összes hallgatója összesen mennyi bevételt jelent!
        public int TotalRevenue() 
        {
            return _price * _studentCount;
        }
        public void addPrice(int price) 
        {
            _price = price;
        }
        public int getStudentCount() 
        {
            return _studentCount;
        }

    }
}
