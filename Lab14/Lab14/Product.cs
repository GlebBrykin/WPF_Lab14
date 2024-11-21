using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public enum ProductCategory
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public string Image
        {
            get;
            set;
        }
        public ProductCategory Category
        {
            get;
            set;
        }
    }
}
