using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class ProductPhoto
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public byte[] Photo { get; set; }
        public Product Product { get; set; }
    }
}
