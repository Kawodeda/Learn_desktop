using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string? Description { get; set; }
        public double? Discount { get; set; }
        public byte[]? MainPhoto { get; set; }
        public ICollection<ServicePhoto> ServicePhoto { get; set; }
        public ICollection<ClientService> ClientService { get; set; }
    }
}
