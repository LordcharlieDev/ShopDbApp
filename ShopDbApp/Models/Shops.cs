using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Shops
    {
        public Shops()
        {
            Workers = new HashSet<Workers>();
            Products = new HashSet<Products>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ParkingArea { get; set; }

        public Cities City { get; set; }
        public ICollection<Workers> Workers { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
