using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopRazorPage.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        public Categories Category { get; set; }
    }
}
