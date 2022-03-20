using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class City
    {
        public City()
        {
            Shops = new HashSet<Shop>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public ICollection<Shop> Shops { get; set; }
        public Country Country { get; set; }
    }
}
