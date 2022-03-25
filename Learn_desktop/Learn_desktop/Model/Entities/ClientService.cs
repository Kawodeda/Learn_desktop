using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class ClientService
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int ServiceID { get; set; }
        public DateTime StartTime { get; set; }
        public string? Comment { get; set; }
        public Client Client { get; set; }
        public Service Service { get; set; }
        public ICollection<ProductSale> ProductSale { get; set; }
        public ICollection<DocumentByService> DocumentByService { get; set; }
    }
}
