using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Positions
    {
        public Positions()
        {
            Workers = new HashSet<Workers>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Workers> Workers { get; set; }
    }
}
