using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab_Exercises___IS110_v26.Lab_Exercise5___.Codes
{

    /*
    ---- Øvelse 2: ----

      ⨠ Lag en klasse Product med:
           -> Id (int)
           -> Name (string)
           -> Category (string)
           -> Price (decimal)
        
      ⨠ Opprett en List av type Product med minst 10 produkter (Legg inn 10 produkter).

      ⨠ Bruk LINQ til å:
           -> Finne alle produkter i en bestemt kategori (brukeren skriver kategori)
           -> Finne alle produkter med pris mellom to verdier (brukeren skriver min/max)
           -> Finne alle produkter som koster mer enn en gitt pris fra brukeren
           -> Sorter produkter etter pris stigende
           -> Grupper produktene etter kategori og skriv ut kategori + antall produkter

      ⨠ Bruk løkker til å:
           -> Skrive ut produktene pent formatert
           -> Beregne totalprisen for alle produktene

     */
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    internal class _2_Exercise
    {
        public static void Run()
        {
            // Lager en Liste - Variant 1:
            var list = new List<Product>
            {
                new Product { ID = 100, Name = "Fourth Wing", Category = "Books", Price = 299.99m }, // hvorfor 'm' bak 299.99?
                new Product { ID = 101, Name = "Iron Flame", Category = "Books", Price = 299.99m }, // hvorfor 'm' bak 299.99?
                new Product { ID = 102, Name = "Onyx Storm", Category = "Books", Price = 299.99m },
                new Product { ID = 187, Name = "iPhone 60 Pro", Category = "Electronics", Price = 10000.00m },
                new Product { ID = 188, Name = "OnePlus Nord 4", Category = "Electronics", Price = 4584.00m },
                new Product { ID = 273, Name = "Trip to Portugal", Category = "Travel", Price = 20570.65m },
                new Product { ID = 274, Name = "Trip to Romania", Category = "Travel", Price = 14650.89m },
                new Product { ID = 842, Name = "Giftcard to Amazon", Category = "Gift", Price = 500.00m },
                new Product { ID = 843, Name = "Giftcard to the mall", Category = "Gift", Price = 700.00m },
                new Product { ID = 960, Name = "Cookies", Category = "Food", Price = 85.59m },
            };

        }
    }
}
