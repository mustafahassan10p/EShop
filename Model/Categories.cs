using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopRazorPage.Model
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int MaxNumberOfProducts { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int DisplayOrder { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
