using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anbar_App.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
        public Company Company { get; set; }
    }
}
