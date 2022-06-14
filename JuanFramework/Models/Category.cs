using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFramework.Models
{
    public class Category :BaseEntity
    {
        public int Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
