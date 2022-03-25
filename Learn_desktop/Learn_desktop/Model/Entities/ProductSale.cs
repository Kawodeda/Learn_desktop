using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class ProductSale
    {
        public int ID { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int? ClientServiceID { get; set; }
        public Product Product { get; set; }
        public ClientService ClientService { get; set; }
    }
}
