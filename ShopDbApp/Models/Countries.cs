using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Countries
    {

        public Countries()
        {
            Cities = new HashSet<Cities>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Cities> Cities { get; set; }
    }
}
