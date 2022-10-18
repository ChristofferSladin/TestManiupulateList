using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManiupulateList
{
    public class App
    {
        public void Run()
        {
            ChangeObj();
        }

        public void ChangeObj()
        {
            var products = new List<Product>();

            products.Add(new Product(11, "banan", "st", 30m));
            products.Add(new Product(12, "apa", "st", 20m));
            products.Add(new Product(13, "kung", "kg", 15m));
            products.Add(new Product(14, "bajs", "kg", 75m));

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.PriceType}");
            }

            Console.WriteLine("hitta id");
            var myValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Nytt namn");
            var newName = Console.ReadLine();
            Console.WriteLine("Nytt pris");
            var newPrice = decimal.Parse(Console.ReadLine());

            var obj = products.FirstOrDefault(x => x.Id == myValue);

            if (obj != null)
            {
                obj.Name = newName;
                obj.Price = newPrice;
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.PriceType}");
            }
        }

    }
}
