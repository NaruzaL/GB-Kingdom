using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gummi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string origin { get; set; }
    }
}
