using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTestApp
{
    public class Product
    {
        public static int Id;
        public string productName { get; set; }
        public string productBarcode { get; set; }

        public Product(string name, string code)
        {
            Id = 3;
            this.productName = name;
            this.productBarcode = code;
        }

        public override string ToString()
        {
            return Id++  + " " + this.productName + " " + this.productBarcode;
        }
    }
    }
