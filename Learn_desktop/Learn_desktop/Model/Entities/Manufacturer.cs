using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateOnly? StartDate { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
