using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class AttachedProduct
    {
        public int MainProductID { get; set; }
        public int AttachedProductID { get; set; }
        public Product MainProduct { get; set; }
        public Product Product { get; set; }
    }
}
