﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class Cities
    {
        public Cities()
        {
            Shops = new HashSet<Shops>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public ICollection<Shops> Shops { get; set; }
        public Countries Country { get; set; }
    }
}
