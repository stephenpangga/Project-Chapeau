using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal VAT { get; set; }

        public MenuCategory(string id, string name, decimal vat)
        {
            Id = id;
            Name = name;
            VAT = vat;
        }
    }
}
