using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Position
    {
        public Position()
        {
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
