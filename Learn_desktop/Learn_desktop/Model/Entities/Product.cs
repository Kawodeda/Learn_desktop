using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
        public byte[]? MainPhoto { get; set; }
        public bool IsActive { get; set; }
        public int? ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ICollection<ProductPhoto> ProductPhoto { get; set; }
        public ICollection<AttachedProduct> AttachedProduct { get; set; }
        public ICollection<ProductSale> ProductSale { get; set; }
    }
}
