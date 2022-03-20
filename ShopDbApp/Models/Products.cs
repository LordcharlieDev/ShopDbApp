using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Products
    {
        public Products()
        {
            Shops = new HashSet<Shops>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }


        public Categories Category { get; set; }
        public ICollection<Shops> Shops { get; set; }

        
    }
}
