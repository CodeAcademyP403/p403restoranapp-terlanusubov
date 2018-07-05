using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Full_App
{
   public class OrderedProduct
    {
        public string OfisiantName { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }

    public class Basket
    {
       public List<OrderedProduct> orderedProducts = new List<OrderedProduct>();
    }
}
