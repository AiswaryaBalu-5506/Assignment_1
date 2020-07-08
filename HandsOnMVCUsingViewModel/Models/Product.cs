using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingViewModel.Models
{
    public class Product
    {
        [Required]
        public int pID { get; set; }
        [Required]
        public string pName { get; set; }
        public int price { get; set; }
        public string stock { get; set; }
    }
}
