using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Family { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Brand { get; set; }

        public DateTime dateTake { get; set; }
        public DateTime dateTurningBack { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
