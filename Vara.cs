using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kassaapparat_app
{
    internal class Vara
    {
        public string Name { get; set; }
        public int Price { get; set; }
        

        public Vara(string name, int price)
        {
            Name = name;
            Price = price; 
            
        }

      
        public string GetCSV()
        {
            return Name + "," + Price + "," ;
        }

       

    }
}

