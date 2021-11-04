using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWebApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set;}
        public int price { get; set; }

    }
}
