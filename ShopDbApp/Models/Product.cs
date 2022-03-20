using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Product
    {
        public Product()
        {
            Shops = new HashSet<Shop>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }


        public Category Category { get; set; }
        public ICollection<Shop> Shops { get; set; }

        
    }
}
