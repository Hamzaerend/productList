using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNett
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fiyat { get; set; }

        public int Stok { get; set; }
    }
}
