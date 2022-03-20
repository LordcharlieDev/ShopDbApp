using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        [Required]
        public int Name { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
