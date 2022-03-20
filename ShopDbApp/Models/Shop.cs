using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Shop
    {
        public Shop()
        {
            Workers = new HashSet<Worker>();
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ParkingArea { get; set; }

        public City City { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
