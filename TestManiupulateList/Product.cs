using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManiupulateList
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceType { get; set; }
        public decimal Price { get; set; }



        public Product(int id, string name, string pricType, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.PriceType = pricType;
            this.Price = price;
        }
    }


   
}
